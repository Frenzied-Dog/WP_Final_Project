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

    public partial class NotifyChunk : UserControl {
        public NotifyType type;
        public int act_ID;

        public NotifyChunk() {
            InitializeComponent();
        }

        public NotifyChunk(NotifyType type, MainDataSet.ActivitiesRow act) {
            InitializeComponent();
            this.type = type;
            act_ID = act.ID;

            switch (type) {
            case NotifyType.NEW_EVENT:
                TitlePicBox.Image = Properties.Resources.好康通知;
                ConfirmPicBox.Image = Properties.Resources.查看更多Btn;
                MainLabel.Text = $"{ act.GetParentRow("FK_Activity_ToUser").Field<string>("NickName") }" +
                    $"在 { act.EstimateTime.ToString("g") } 舉辦了活動，地點是 { act.Place }" +
                    $"。我們認為你會有興趣，點擊去看看吧！";
                break;
            case NotifyType.EVENT_CANCELED:
                TitlePicBox.Image = Properties.Resources.取消通知;
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn;
                MainLabel.Text = $"您曾報名 { act.EstimateTime.ToString("g") } 於 { act.Place } 之活動，" +
                    $"主辦人因個人因素取消活動，請記得不要白跑一趟喔！";
                break;
            case NotifyType.EVENT_SOON:
                TitlePicBox.Image = Properties.Resources.活動提醒;
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn;
                MainLabel.Text = $"您曾報名 { act.EstimateTime.ToString("g") } 於 { act.Place } 之活動，" +
                    $"活動再10分鐘就要開始囉！該從床上爬起來了！";
                break;
            }
        }

        private void ConfirmPicBox_Click(object sender, EventArgs e) {
            switch (type) {
            case NotifyType.NEW_EVENT:
                break;
            case NotifyType.EVENT_CANCELED:
                break;
            case NotifyType.EVENT_SOON:
                break;
            }
        }

        private void ConfirmPicBox_MouseEnter(object sender, EventArgs e) {
            switch (type) {
            case NotifyType.NEW_EVENT:
                ConfirmPicBox.Image = Properties.Resources.查看更多Btn_2;
                break;
            case NotifyType.EVENT_CANCELED:
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn_2;
                break;
            case NotifyType.EVENT_SOON:
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn_2;
                break;
            }
        }

        private void ConfirmPicBox_MouseLeave(object sender, EventArgs e) {
            switch (type) {
            case NotifyType.NEW_EVENT:
                ConfirmPicBox.Image = Properties.Resources.查看更多Btn;
                break;
            case NotifyType.EVENT_CANCELED:
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn;
                break;
            case NotifyType.EVENT_SOON:
                ConfirmPicBox.Image = Properties.Resources.我知道了Btn;
                break;
            }
        }
    }
}
