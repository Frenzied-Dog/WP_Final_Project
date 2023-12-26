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
        bool Loading = true;
        DataRow[] Acts;
        int ActIndex = 0;
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        Label[] eventLabels = new Label[6];

        public MainMenuForm(MainDataSet db) {
            InitializeComponent();
            this.db = db;
            profileForm = new MyProfileForm(db);
            eventForm = new MyEventForm(db);
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
            PlaceHolder.Text = "";
            Loading = false;
        }

        void ReloadEvent() {
            string filter = "";
            ActivityAdapter.Fill(db.Activities);
            if (BudgetComboBox.SelectedIndex > 0 && TimeComboBox.SelectedIndex > 0) {
                filter = $"Budget = {BudgetComboBox.SelectedIndex - 1} AND PreferTime = {TimeComboBox.SelectedIndex - 1}";
            } else if (BudgetComboBox.SelectedIndex > 0) {
                filter = $"Budget = {BudgetComboBox.SelectedIndex - 1}";
            } else if (TimeComboBox.SelectedIndex > 0) {
                filter = $"PreferTime = {TimeComboBox.SelectedIndex - 1}";
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

            UAA_Adapter.Fill(db.User_Activity_A, act.Field<int>("ID"));
            CountLabel.Text = db.User_Activity_A.Count.ToString();
            IndexLabel.Text = $"{ActIndex + 1}/{Acts.Length}";
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
                new CreateEventForm(db).ShowDialog();
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
            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            if (n == "Left" && ActIndex > 0) ActIndex--;
            else if (n == "Right" && ActIndex < Acts.Length - 1) ActIndex++;
            else return;
            LoadEvent();
        }

        private void SignPicBox_Click(object sender, EventArgs e) {
            if (db.Activities.FindByID(db.User_Activity_A[0].ActivityID).MainUserId.Trim(' ') == db.Me[0].ID.Trim(' ')) {
                MessageBox.Show("你是主揪你還報啥XDD", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (db.User_Activity_A.Select($"UserID = '{db.Me[0].ID}'").Count() != 0) {
                MessageBox.Show("你已經報名過了!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.User_Activity_A.AddUser_Activity_ARow(db.Me[0].ID, (int)Acts[ActIndex]["ID"]);
            UAA_Adapter.Update(db.User_Activity_A);
            MessageBox.Show("報名成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEvent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (Loading) return;
            ReloadEvent();
        }
    }
}
