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

namespace Final_Project {
    public partial class LoginForm : Form {
        public static IPublicClientApplication PublicClientApp;
        static string graphAPI_Me = "https://graph.microsoft.com/v1.0/me";
        string name = "";
        string ID = "";
        Final_ProjectDataSet db;
        Final_ProjectDataSetTableAdapters.MeTableAdapter MeAdapter = new Final_ProjectDataSetTableAdapters.MeTableAdapter();

        public LoginForm(Final_ProjectDataSet db) {
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

            } catch (MsalUiRequiredException ex) {
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

            MeAdapter.Fill(db.Me, ID);
            if (db.Me.Count == 0) {
                (new NewUserForm(db)).Show();
            } else {
                MessageBox.Show($"歡迎回來，{name}！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new NewUserForm(db)).Show();
            }

            Close();
        }
    }
}
