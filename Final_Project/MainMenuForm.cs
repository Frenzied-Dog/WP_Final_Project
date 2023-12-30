using Newtonsoft.Json.Linq;
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
    public partial class MainMenuForm : Form {
        //MainDataSet db;
        MyProfileForm profileForm;
        MyEventForm eventForm;
        //CreateEventForm createEventForm;
        NotificationForm notifyForm;
        DataRow[] Acts;
        int ActIndex = 0;
        string UID = "";
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        Label[] eventLabels = new Label[6];

        public MainMenuForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            this.UID = UID;
            profileForm = new MyProfileForm(db, UID);
            eventForm = new MyEventForm(db, UID);
            //createEventForm = new CreateEventForm(db);
            notifyForm = new NotificationForm(db);
            BudgetComboBox.DataSource = budgets;
            TimeComboBox.DataSource = times;
            BudgetComboBox.SelectedIndex = 0;
            TimeComboBox.SelectedIndex = 0;
            eventLabels = new Label[6] { DateLabel, TimeLabel, ShopLabel, AddressLabel, CountLabel, IntroLabel };
            foreach (var label in eventLabels) {
                label.Text = "";
            }

            ReloadEvent();
        }

        void ReloadEvent() {
            string filter = "Deleted = 0";
            ActivityAdapter.Fill(db.Activities);
            if (BudgetComboBox.SelectedIndex > 0 && TimeComboBox.SelectedIndex > 0) {
                filter += $" AND Budget = {BudgetComboBox.SelectedIndex} AND PreferTime = {TimeComboBox.SelectedIndex}";
            } else if (BudgetComboBox.SelectedIndex > 0) {
                filter += $" AND Budget = {BudgetComboBox.SelectedIndex}";
            } else if (TimeComboBox.SelectedIndex > 0) {
                filter += $" AND PreferTime = {TimeComboBox.SelectedIndex}";
            }
            Acts = db.Activities.Select(filter);

            if (Acts.Length == 0) {
                DateLabel.Text = "------";
                TimeLabel.Text = "------";
                ShopLabel.Text = "------";
                AddressLabel.Text = "-------";
                CountLabel.Text = "------";
                IntroLabel.Text = "------";
                IndexLabel.Text = "0/0";
                return;
            }

            ActIndex = 0;
            LoadEvent();
        }

        void LoadEvent() {
            var act = Acts[ActIndex];
            DateLabel.Text = act.Field<DateTime>("EstimateTime").ToString("d");
            TimeLabel.Text = act.Field<DateTime>("EstimateTime").ToString("t");
            ShopLabel.Text = act.Field<string>("Place");
            AddressLabel.Text = act.Field<string>("Address");
            IntroLabel.Text = act.Field<string>("Intro");

            UA_Adapter.FillByAct(db.User_Activity, act.Field<int>("ID"));
            CountLabel.Text = db.User_Activity.Count.ToString();
            IndexLabel.Text = $"{ActIndex + 1}/{Acts.Length}";

            //UAA_Adapter.Fill(db.User_Activity_A, act.Field<int>("ID"));
            //CountLabel.Text = db.User_Activity_A.Count.ToString();
            //IndexLabel.Text = $"{ActIndex + 1}/{Acts.Length}";
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void MenuPicBox_Click(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                profileForm.ShowDialog();
                break;
            case "MyEvent":
                eventForm.ShowDialog();
                ReloadEvent();
                break;
            case "CreateEvent":
                new CreateEventForm(db, UID).ShowDialog();
                ReloadEvent();
                break;
            case "Notify":
                notifyForm.ShowDialog();
                break;
            default:
                break;
            }
        }

        private void MenuPicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                picBox.Image = Properties.Resources.MyProfileBtn_2;
                break;
            case "MyEvent":
                picBox.Image = Properties.Resources.MyEventBtn_2;
                break;
            case "CreateEvent":
                picBox.Image = Properties.Resources.CreatEventBtn_2;
                break;
            case "Notify":
                picBox.Image = Properties.Resources.NotiticationBtn_2;
                break;
            case "Left":
                picBox.Image = Properties.Resources.LeftBtn_2;
                break;
            case "Right":
                picBox.Image = Properties.Resources.RightBtn_2;
                break;
            case "Sign":
                picBox.Image = Properties.Resources.一鍵報名Btn_2;
                break;
            default:
                break;
            }
        }

        private void MenuPicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                picBox.Image = Properties.Resources.MyProfileBtn;
                break;
            case "MyEvent":
                picBox.Image = Properties.Resources.MyEventBtn;
                break;
            case "CreateEvent":
                picBox.Image = Properties.Resources.CreatEventBtn;
                break;
            case "Notify":
                picBox.Image = Properties.Resources.NotiticationBtn;
                break;
            case "Left":
                picBox.Image = Properties.Resources.LeftBtn;
                break;
            case "Right":
                picBox.Image = Properties.Resources.RightBtn;
                break;
            case "Sign":
                picBox.Image = Properties.Resources.一鍵報名Btn;
                break;
            default:
                break;
            }
        }

        private void ArrowPicBox_Click(object sender, EventArgs e) {
            if (Acts.Length == 0) return;
            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            //if (n == "Left" && ActIndex > 0) ActIndex--;
            //else if (n == "Right" && ActIndex < Acts.Length - 1) ActIndex++;
            //else return;
            if (n == "Left") {
                ActIndex--;
                if (ActIndex < 0) ActIndex = Acts.Length - 1;
            } else if (n == "Right") {
                ActIndex++;
                if (ActIndex >= Acts.Length) ActIndex = 0;
            }
            else return;
            LoadEvent();
        }

        private void SignPicBox_Click(object sender, EventArgs e) {
            int actID = Acts[ActIndex].Field<int>("ID");

            if (Acts[ActIndex].Field<string>("MainUserId").Trim(' ') == UID) {
                MessageBox.Show("你是主揪你還報啥XDD", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (db.User_Activity.Select($"UserID = '{UID}' AND ActivityID = {actID}").Count() != 0) {
                MessageBox.Show("你已經報名過了!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UA_Adapter.Insert(UID, actID);
            UA_Adapter.FillByAct(db.User_Activity, actID);
            //db.User_Activity_A.AddUser_Activity_ARow(db.Users.FindByID(db.Me[0].ID), db.Activities.FindByID(Acts[ActIndex].Field<int>("ID")));
            //UAA_Adapter.Update(db.User_Activity_A);
            MessageBox.Show("報名成功!\n可至上方 My Event 處查看活動", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEvent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ReloadEvent();
        }
    }
}
