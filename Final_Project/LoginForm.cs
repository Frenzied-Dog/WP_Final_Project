using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Final_Project.MainDataSetTableAdapters;
using System.Drawing.Imaging;

namespace Final_Project {
    public partial class LoginForm : Form {
        public static IPublicClientApplication PublicClientApp;
        static string graphAPI_Me = "https://graph.microsoft.com/v1.0/me";
        string name = "";
        string ID = "";
        string DevID = "E24116128";

        public LoginForm(MainDataSet db) {
            InitializeComponent();
            PublicClientApp = PublicClientApplicationBuilder.Create("9cbbf580-d751-42ec-97d0-01d35df3fa7c")
                 .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                 .WithAuthority(AzureCloudInstance.AzurePublic, "c2e7753f-aa05-4abc-8c02-293ad122ca19")
                 .Build();

            this.db = db;
        }

        private void LoginPicBox_MouseEnter(object sender, EventArgs e) {
            LoginPicBox.Image = Properties.Resources.Btn2_2;
        }

        private void LoginPicBox_MouseLeave(object sender, EventArgs e) {
            LoginPicBox.Image = Properties.Resources.Btn1_2;
        }

        async private void LoginPicBox_Click(object sender, EventArgs e) {
            ID = TextBox_ID.Text;

            if (ID == "") {
                MessageBox.Show("請輸入學號", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] scopes = { "User.Read" }; //User.ReadBasic.All
            AuthenticationResult authResult = null;
            var accounts = await PublicClientApp.GetAccountsAsync();

            try {
                authResult = await PublicClientApp.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();

            } catch (MsalUiRequiredException) {
                try {
                    authResult = await PublicClientApp.AcquireTokenInteractive(scopes)
                        .WithPrompt(Prompt.SelectAccount)
                        .WithLoginHint($"{ID}@ncku.edu.tw")
                        .ExecuteAsync();

                } catch (MsalException msalex) {
                    MessageBox.Show($"Error Acquiring Token:\r\n{msalex}");
                    return;
                }
            }

            if (authResult == null) return;

            var httpClient = new System.Net.Http.HttpClient();
            System.Net.Http.HttpResponseMessage response;
            try {
                var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, graphAPI_Me);
                //Add the token in Authorization header
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authResult.AccessToken);
                response = await httpClient.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                var resultDic = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
                name = resultDic["displayName"].ToString().Split(' ').First();
            } catch (Exception ex) {
                ex.Message.ToString();
                MessageBox.Show(ex.ToString());
                return;
            }

            var me = UsersAdapter.GetDataByID(ID)[0];

            if (me == null) {
                new NewUserForm(db, TextBox_ID.Text, name).Show();
            } else {
                MessageBox.Show($"歡迎回來，{name}！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new MainMenuForm(db, ID).Show();
            }

            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void DevLoginBtn_Click(object sender, EventArgs e) {
            new MainMenuForm(db, DevID).Show();
            Close();
        }

        private void DevNewUserBtn_Click(object sender, EventArgs e) {
            new NewUserForm(db, TextBox_ID.Text, textBox1.Text).Show();
            Close();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e) {
            var user = UsersAdapter.GetDataByID(ID)[0];

            if (user == null) MessageBox.Show("查無此人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                string name = user.Name;
                UsersAdapter.Delete(ID);
                MessageBox.Show($"已刪除{name}的資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetAvatarBtn_Click(object sender, EventArgs e) {
            // hot fix avatar
            using (MemoryStream mStream = new MemoryStream()) {
                Bitmap img = Properties.Resources.CuteDog;
                img.Save(mStream, ImageFormat.Bmp);
                var defaultAvatar = mStream.ToArray();

                UsersTableAdapter UserAdapter = new UsersTableAdapter();
                UserAdapter.Fill(db.Users);
                foreach (var user in db.Users) {
                    user.Pic = defaultAvatar;
                }
                UserAdapter.Update(db.Users);
            };
        }

        private void DevLoginAsBtn_Click(object sender, EventArgs e) {
            ID = TextBox_ID.Text;
            var me = UsersAdapter.GetDataByID(ID)[0];

            if (me == null) {
                MessageBox.Show("查無此用戶!");
            } else {
                MessageBox.Show($"歡迎回來，{me.Name}！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new MainMenuForm(db, ID).Show();
            }
            Close();
        }

        private void TextBox_ID_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                LoginPicBox_Click(sender, e);
            }
        }
    }
}
