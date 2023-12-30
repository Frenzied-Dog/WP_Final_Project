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
        //List<DataRow> acts = new List<DataRow>();

        public MyEventForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            this.UID = UID;

            eventLabels = new Label[6] { DateLabel, TimeLabel, ShopLabel, AddressLabel, CountLabel, IntroLabel };
            foreach (var label in eventLabels) {
                label.Text = "";
            }
        }

        void ReloadEvent() {
            //acts.Clear();
            ActivityAdapter.FillByUID(db.Activities, UID, false);
            //UA_Adapter.FillByUser(db.User_Activity, UID, false);


            if (db.Activities.Count == 0) {
            //if (acts.Count == 0) {
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
            var act = db.Activities[ActIndex];
            //var act = acts[ActIndex];

            DateLabel.Text = act.Field<DateTime>("EstimateTime").ToString("d");
            TimeLabel.Text = act.Field<DateTime>("EstimateTime").ToString("t");
            ShopLabel.Text = act.Field<string>("Place");
            AddressLabel.Text = act.Field<string>("Address");
            IntroLabel.Text = act.Field<string>("Intro");

            UA_Adapter.FillByAct(db.User_Activity, act.Field<int>("ID"));
            CountLabel.Text = db.User_Activity.Count.ToString();
            IndexLabel.Text = $"{ActIndex + 1}/{db.Activities.Count}";
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
            if (db.Activities.Count == 0) return;

            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            //if (n == "Left" && ActIndex > 0) ActIndex--;
            //else if (n == "Right" && ActIndex < db.User_Activity_U.Count - 1) ActIndex++;
            //else return;
            if (n == "Left") {
                ActIndex--;
                if (ActIndex < 0) ActIndex = db.Activities.Count - 1;
            } else if (n == "Right") {
                ActIndex++;
                if (ActIndex >= db.Activities.Count) ActIndex = 0;
            } else return;
            LoadEvent();
        }

        private void PicBox_Click(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            var act = db.Activities[ActIndex];

            if (n == "Discuss") {
                new DiscussionForm(db, act.ID, UID).ShowDialog();
            } else if (n == "Cancel") {
                if (act.MainUserId.Trim(' ') == UID) {
                    if (MessageBox.Show("你是主揪欸@@\n確定要取消活動嗎?", "取消活動", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        act.Deleted = true;
                        ActivityAdapter.Update(act);


                        var tmp = UA_Adapter.GetDataByUser(UID, true).Select($"ActivityID = {act.ID}")[0];
                        tmp.Delete();
                        UA_Adapter.Update(tmp);
                        //foreach(var uv in db.User_Activity_A) uv.Delete();
                        //UAA_Adapter.Update(db.User_Activity_A);
                        //db.User_Activity_U.Select($"UserID = '{db.Me[0].ID}' AND ActivityID = {acts[ActIndex].Field<int>("ID")}")[0].Delete();
                        //UAU_Adapter.Update(db.User_Activity_U);
                        //acts.RemoveAt(ActIndex);
                        MessageBox.Show("活動已取消", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (ActIndex > 0) ActIndex--;
                        ReloadEvent();
                    }
                } else if (MessageBox.Show("確定要取消報名嗎?", "取消報名", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    var tmp = UA_Adapter.GetDataByUser(UID, false).Select($"ActivityID = {act.ID}")[0];
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
