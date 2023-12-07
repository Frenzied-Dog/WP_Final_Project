using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class Form2 : Form {
        public string ShopName = "";
        public string Address = "";

        public Form2() {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e) {
            
            var res = await webView21.ExecuteScriptAsync("document.querySelector('h1[class=\"DUwDvf lfPIob\"]').textContent");
            if (!res.Equals("null")) ShopName = res.Substring(1, res.Length - 2);

            res = await webView21.ExecuteScriptAsync("document.querySelector('div[class=\"Io6YTe fontBodyMedium kR99db \"]').textContent");
            if (!res.Equals("null")) Address = res.Substring(1, res.Length - 2);

            Close();
        }

        async private void button2_Click(object sender, EventArgs e) {
            await webView21.ExecuteScriptAsync("document.querySelector(\"#passive-assist\").remove()");
            await webView21.ExecuteScriptAsync("document.querySelector(\"#minimap\").remove()");
            await webView21.ExecuteScriptAsync("document.querySelector(\"#vasquette\").remove()");
            await webView21.ExecuteScriptAsync("document.querySelector('div[class=\"app-horizontal-widget-holder Hk4XGb\"]').remove()");
        }

        private void button3_Click(object sender, EventArgs e) {
            webView21.Reload();
        }
    }
}
