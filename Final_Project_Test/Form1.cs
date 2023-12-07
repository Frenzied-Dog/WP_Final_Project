using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Final_ProjectDataSetTableAdapters;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Newtonsoft.Json;


namespace Final_Project {
    public partial class Form1 : Form { 
        public static IPublicClientApplication PublicClientApp;
        static string graphAPI_Me = "https://graph.microsoft.com/v1.0/me";
        Form3 f3 = new Form3();
        Form2 f2 = new Form2();


        public Form1() {
            InitializeComponent();

            PublicClientApp = PublicClientApplicationBuilder.Create("9cbbf580-d751-42ec-97d0-01d35df3fa7c")
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                .WithAuthority(AzureCloudInstance.AzurePublic, "c2e7753f-aa05-4abc-8c02-293ad122ca19")
                .Build();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: 這行程式碼會將資料載入 'FPds.Users' 資料表。您可以視需要進行移動或移除。
            //this.usersTableAdapter.Fill(this.FPds.Users);

        }

        async private void button1_Click(object sender, EventArgs e) {
            string id = "E24116128";

            string[] scopes = { "User.Read" }; //User.ReadBasic.All
            AuthenticationResult authResult = null;
            var accounts = await PublicClientApp.GetAccountsAsync();

            try {
                authResult = await PublicClientApp.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();
                    label1.Text = authResult.Account.Environment;
            } catch (MsalUiRequiredException ex) {
                try {
                    authResult = await PublicClientApp.AcquireTokenInteractive(scopes)
                        .WithPrompt(Prompt.SelectAccount)
                        .WithLoginHint($"{id}@ncku.edu.tw")
                        .ExecuteAsync();
                    label1.Text = authResult.Account.Username;
                } catch (MsalException msalex) {
                    MessageBox.Show($"Error Acquiring Token:\r\n{msalex}");
                }
            }

            if (authResult != null) {
                var httpClient = new System.Net.Http.HttpClient();
                System.Net.Http.HttpResponseMessage response;
                try {
                    var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, graphAPI_Me);
                    //Add the token in Authorization header
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authResult.AccessToken);
                    response = await httpClient.SendAsync(request);
                    var content = await response.Content.ReadAsStringAsync();
                    var resultDic = JsonConvert.DeserializeObject<Dictionary<string,object>>(content);
                    //textBox1.Text = resultDic["displayName"].ToString().Split(' ')[0];
                    textBox1.Text = content;
                } catch (Exception ex) {
                    textBox1.Text = ex.ToString();
                }
            }
        }

        async private void button2_Click(object sender, EventArgs e) {
            var accounts = await PublicClientApp.GetAccountsAsync();
            await PublicClientApp.RemoveAsync(accounts.FirstOrDefault());
            label1.Text = "Signed Out";
        }

        private void button3_Click(object sender, EventArgs e) {
            f2.ShowDialog();

            label2.Text = f2.ShopName + "\r\n" + f2.Address;
        }

        private void button4_Click(object sender, EventArgs e) {
            FPds.Users.Rows.Add("E2411","Hank");
            // Maybe should use TRY
            //usersTableAdapter.Update(FPds.Users);
        }

        private void button5_Click(object sender, EventArgs e) {
            f3.ShowDialog();
        }
    }
}

