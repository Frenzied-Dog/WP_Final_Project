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
    public partial class MyEventForm : Form {
        int ActIndex = 0;
        string UID = "";
        Label[] eventLabels = new Label[6];
        List<int> Acts;
        //List<DataRow> acts = new List<DataRow>();

        public MyEventForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            this.UID = UID;
            Acts = new List<int>();

            eventLabels = new Label[6] { DateLabel, TimeLabel, ShopLabel, AddressLabel, CountLabel, IntroLabel };
            foreach (var label in eventLabels) {
                label.Text = "";
            }
        }

        void ReloadEvent() {
            Acts.Clear();

            foreach (var ua in db.User_Activity.Select($"UserID = '{UID}'")) {
                var tmp = db.Activities.FindByID(ua.Field<int>("ActivityID"));
                if (!tmp.Deleted) Acts.Add(tmp.ID);
            }

            if (Acts.Count == 0) {
                DateLabel.Text = "------";
                TimeLabel.Text = "------";
                ShopLabel.Text = "------";
                AddressLabel.Text = "-------";
                CountLabel.Text = "------";
                IntroLabel.Text = "------";
                IndexLabel.Text = "0/0";
                return;
            }

            LoadEvent();
        }

        void LoadEvent() {
            var act = db.Activities.FindByID(Acts[ActIndex]);

            DateLabel.Text = act.EstimateTime.ToString("d");
            TimeLabel.Text = act.EstimateTime.ToString("t");
            ShopLabel.Text = act.Place;
            AddressLabel.Text = act.Address;
            IntroLabel.Text = act.Intro;

            var tmp = act.GetChildRows("FK_UA_ToActivity");
            CountLabel.Text = tmp.Length.ToString();
            IndexLabel.Text = $"{ActIndex + 1}/{Acts.Count}";
        }

        private void PicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Discuss":
                picBox.Image = Properties.Resources.討論版Btn_2;
                break;
            case "Cancel":
                picBox.Image = Properties.Resources.取消報名Btn_2;
                break;
            case "Left":
                picBox.Image = Properties.Resources.LeftBtn_2;
                break;
            case "Right":
                picBox.Image = Properties.Resources.RightBtn_2;
                break;
            default:
                break;
            }
        }

        private void PicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Discuss":
                picBox.Image = Properties.Resources.討論版Btn;
                break;
            case "Cancel":
                picBox.Image = Properties.Resources.取消報名Btn;
                break;
            case "Left":
                picBox.Image = Properties.Resources.LeftBtn;
                break;
            case "Right":
                picBox.Image = Properties.Resources.RightBtn;
                break;
            default:
                break;
            }
        }

        private void ArrowPicBox_Click(object sender, EventArgs e) {
            if (Acts.Count == 0) return;

            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);

            if (n == "Left") {
                ActIndex--;
                if (ActIndex < 0) ActIndex = Acts.Count - 1;
            } else if (n == "Right") {
                ActIndex++;
                if (ActIndex >= Acts.Count) ActIndex = 0;
            } else return;
            LoadEvent();
        }

        private void PicBox_Click(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            var act = db.Activities.FindByID(Acts[ActIndex]);

            if (n == "Discuss") {
                new DiscussionForm(db, act.ID, UID).ShowDialog();
            } else if (n == "Cancel") {
                if (act.MainUserId.Trim(' ') == UID) {
                    if (MessageBox.Show("你是主揪欸@@\n確定要取消活動嗎?", "取消活動", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        act.Deleted = true;
                        ActivityAdapter.Update(act);

                        var tmp = db.User_Activity.Select($"UserID = '{UID}' AND ActivityID = {act.ID}")[0];
                        tmp.Delete();
                        UA_Adapter.Update(tmp);

                        MessageBox.Show("活動已取消", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (ActIndex > 0) ActIndex--;
                        ReloadEvent();
                    }
                } else if (MessageBox.Show("確定要取消報名嗎?", "取消報名", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    var tmp = db.User_Activity.Select($"UserID = '{UID}' AND ActivityID = {act.ID}")[0];
                    tmp.Delete();
                    UA_Adapter.Update(tmp);

                    MessageBox.Show("已取消報名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (ActIndex > 0) ActIndex--;
                    ReloadEvent();
                }
            } else return;
        }

        private void MyEventForm_Load(object sender, EventArgs e) {
            UsersAdapter.Fill(db.Users);
            ActIndex = 0;
            ReloadEvent();
        }
    }
}
