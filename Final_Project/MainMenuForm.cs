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
        //Final_ProjectDataSet db;
        MyProfileForm profileForm;
        MyEventForm eventForm;
        CreateEventForm createEventForm;
        NotificationForm notifyForm;
        DataRow[] Acts;
        int ActIndex = 0;
        string[] budgets = { "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        Label[] eventLabels = new Label[6];

        public MainMenuForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
            profileForm = new MyProfileForm(db);
            eventForm = new MyEventForm(db);
            createEventForm = new CreateEventForm(db);
            notifyForm = new NotificationForm(db);
            BudgetComboBox.DataSource = budgets;
            TimeComboBox.DataSource = times;
            BudgetComboBox.SelectedIndex = -1;
            TimeComboBox.SelectedIndex = -1;
            eventLabels = new Label[6] { DateLabel, TimeLabel, ShopLabel, AddressLabel, CountLabel, IntroLabel };
            foreach (var label in eventLabels) {
                label.Text = "";
            }
            
            ReloadEvent();
            PlaceHolder.Text = "";
        }

        void ReloadEvent() {
            string filter = "";
            ActivityAdapter.Fill(db.Activities);
            if (BudgetComboBox.SelectedIndex != -1 && TimeComboBox.SelectedIndex != -1) {
                filter = $"Budget = {BudgetComboBox.SelectedIndex} AND PreferTime = {TimeComboBox.SelectedIndex}";
            } else if (BudgetComboBox.SelectedIndex != -1) {
                filter = $"Budget = {BudgetComboBox.SelectedIndex}";
            } else if (TimeComboBox.SelectedIndex != -1) {
                filter = $"PreferTime = {TimeComboBox.SelectedIndex}";
            }
            Acts = db.Activities.Select(filter);
            ActIndex = 0;
            LoadEvent();
        }

        void LoadEvent() {
            DateLabel.Text = ((DateTime)Acts[ActIndex]["EstimateTime"]).ToString("d");
            TimeLabel.Text = ((DateTime)Acts[ActIndex]["EstimateTime"]).ToString("t");
            ShopLabel.Text = (string)Acts[ActIndex]["Place"];
            AddressLabel.Text = (string)Acts[ActIndex]["Address"];
            IntroLabel.Text = (string)Acts[ActIndex]["Intro"];

            UAA_Adapter.Fill(db.User_Activity_A, (int)Acts[ActIndex]["ID"]);
            
            CountLabel.Text = db.User_Activity_A.Count.ToString();
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
                break;
            case "CreateEvent":
                createEventForm.ShowDialog();
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
            switch (picBox.Name.Substring(0,picBox.Name.Length-6)) {
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
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Left":
                if (ActIndex > 0) {
                    ActIndex--;
                    LoadEvent();
                }
                break;
            case "Right":
                if (ActIndex < Acts.Length - 1) {
                    ActIndex++;
                    LoadEvent();
                }
                break;
            }
        }

        private void SignPicBox_Click(object sender, EventArgs e) {

        }
    }
}
