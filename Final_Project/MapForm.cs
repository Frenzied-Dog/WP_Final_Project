using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class MapForm : Form {
        public string ShopName = "";
        public string Address = "";

        public MapForm() {
            InitializeComponent();
        }

        async private void ConfirmPicBox_Click(object sender, EventArgs e) {
            var res = await Map.ExecuteScriptAsync("document.querySelector('h1[class=\"DUwDvf lfPIob\"]').textContent");
            if (!res.Equals("null")) ShopName = res.Substring(1, res.Length - 2);

            res = await Map.ExecuteScriptAsync("document.querySelector('div[class=\"Io6YTe fontBodyMedium kR99db \"]').textContent");
            if (!res.Equals("null")) Address = res.Substring(1, res.Length - 2);

            Close();
        }

        private void PicBox_Enter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) { 
            case "Confirm":
                ConfirmPicBox.Image = Properties.Resources.地點確認Btn_2;
                break;
            case "Reset":
                ResetPicBox.Image = Properties.Resources.重設地圖Btn_2;
                break;
            }
        }

        private void PicBox_Leave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Confirm":
                ConfirmPicBox.Image = Properties.Resources.地點確認Btn;
                break;
            case "Reset":
                ResetPicBox.Image = Properties.Resources.重設地圖Btn;
                break;
            }
        }

        async private void Map_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e) {
            await Map.ExecuteScriptAsync("document.querySelector(\"#passive-assist\").remove()");
            await Map.ExecuteScriptAsync("document.querySelector(\"#minimap\").remove()");
            await Map.ExecuteScriptAsync("document.querySelector(\"#vasquette\").remove()");
            await Map.ExecuteScriptAsync("document.querySelector('div[class=\"app-horizontal-widget-holder Hk4XGb\"]').remove()");
        }

        private void ResetPicBox_Click(object sender, EventArgs e) {
            Map.Source = new Uri("https://www.google.com.tw/maps");
        }
    }
}
