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
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Newtonsoft.Json;


namespace Final_Project {
    public partial class Form1 : Form { 
        public static IPublicClientApplication PublicClientApp;
        static string graphAPI = "https://graph.microsoft.com/v1.0/me";


        public Form1() {
            InitializeComponent();

            PublicClientApp = PublicClientApplicationBuilder.Create("9cbbf580-d751-42ec-97d0-01d35df3fa7c")
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                .WithAuthority(AzureCloudInstance.AzurePublic, "c2e7753f-aa05-4abc-8c02-293ad122ca19")
                .Build();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        async private void button1_Click(object sender, EventArgs e) {
            string id = "E24116128";

            string[] scopes = { "User.Read" };
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
                    label1.Text = $"Error Acquiring Token:\r\n{msalex}";
                }
            }

            if (authResult != null) {
                var httpClient = new System.Net.Http.HttpClient();
                System.Net.Http.HttpResponseMessage response;
                try {
                    var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, graphAPI);
                    //Add the token in Authorization header
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authResult.AccessToken);
                    response = await httpClient.SendAsync(request);
                    var content = await response.Content.ReadAsStringAsync();
                    var resultDic = JsonConvert.DeserializeObject<Dictionary<string,object>>(content);
                    textBox1.Text = resultDic["displayName"].ToString().Split(' ')[0];
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

        async private void button3_Click(object sender, EventArgs e) {
            var res = await webView21.ExecuteScriptAsync("document.querySelector('h1[class=\"DUwDvf lfPIob\"]').textContent");
            if (res.Equals("null")) res = "";
            else label2.Text = res.Substring(1,res.Length-2);

            res = await webView21.ExecuteScriptAsync("document.querySelector('div[class=\"Io6YTe fontBodyMedium kR99db \"]').textContent");
            if (res.Equals("null")) res = "";
            else res = "\n\r" + res.Substring(7, res.Length - 8);
            label2.Text += res;
        }
    }
}

