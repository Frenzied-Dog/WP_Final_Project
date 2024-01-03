using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public enum NotifyType { NEW_EVENT, EVENT_CANCELED, EVENT_SOON };

    public partial class MainMenuForm : Form {
        MyProfileForm profileForm;
        MyEventForm eventForm;
        NotificationForm notifyForm;
        List<int> Acts;
        int ActIndex = 0;
        int t = 0;
        string UID = "";
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        Label[] eventLabels = new Label[6];

        public MainMenuForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            this.UID = UID;
            Acts = new List<int>();

            profileForm = new MyProfileForm(db, UID);
            eventForm = new MyEventForm(db, UID);
            BudgetComboBox.DataSource = budgets;
            TimeComboBox.DataSource = times;
            BudgetComboBox.SelectedIndex = 0;
            TimeComboBox.SelectedIndex = 0;
            eventLabels = new Label[6] { DateLabel, TimeLabel, ShopLabel, AddressLabel, CountLabel, IntroLabel };
            foreach (var label in eventLabels) {
                label.Text = "";
            }
            UsersAdapter.Fill(db.Users);
            UA_Adapter.Fill(db.User_Activity);
            ActivityAdapter.Fill(db.Activities);
            notifyForm = new NotificationForm(this, db, UID);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(NotifyLabel.ClientRectangle);
            NotifyLabel.Region = new Region(gp);
            gp = new GraphicsPath();
            gp.AddEllipse(SpotPicBox.ClientRectangle);
            SpotPicBox.Region = new Region(gp);

            ActIndex = 0;
            Tmr_Tick(null, null);
        }

        void ReloadEvent() {
            Acts.Clear();
            string filter = "Deleted = False";

            if (BudgetComboBox.SelectedIndex > 0) {
                filter += $" AND Budget = {BudgetComboBox.SelectedIndex}";
            } else if (TimeComboBox.SelectedIndex > 0) {
                filter += $" AND PreferTime = {TimeComboBox.SelectedIndex}";
            }
            var tmp = db.Activities.Select(filter);

            if (tmp.Length == 0) {
                DateLabel.Text = "------";
                TimeLabel.Text = "------";
                ShopLabel.Text = "------";
                AddressLabel.Text = "-------";
                CountLabel.Text = "------";
                IntroLabel.Text = "------";
                IndexLabel.Text = "0/0";
                return;
            }

            foreach (var act in tmp)
                Acts.Add(act.Field<int>("ID"));

            if (ActIndex > Acts.Count-1) ActIndex = 0;
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

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        public void ShowInformation(int actID) {
            BudgetComboBox.SelectedIndex = 0;
            TimeComboBox.SelectedIndex = 0;

            int index = Acts.FindIndex(x => x == actID);
            if (index == -1) return;
            ActIndex = index;
            LoadEvent();
            MainPanel.VerticalScroll.Value = MainPanel.VerticalScroll.Maximum;
        }

        private void MenuPicBox_Click(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                profileForm.ShowDialog();
                break;
            case "MyEvent":
                eventForm.ShowDialog();
                ActIndex = 0;
                ReloadEvent();
                break;
            case "CreateEvent":
                new CreateEventForm(db, UID).ShowDialog();
                ActIndex = 0;
                ReloadEvent();
                break;
            case "Notify":
                notifyForm.ShowDialog();
                if (notifyForm.count == 0) {
                    SpotPicBox.Visible = false;
                    NotifyLabel.Visible = false;
                } else {
                    SpotPicBox.Visible = true;
                    NotifyLabel.Visible = true;
                    int c = notifyForm.count;
                    NotifyLabel.Text = c.ToString();
                }
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
            if (Acts.Count == 0) return;
            PictureBox picBox = (PictureBox)sender;
            string n = picBox.Name.Substring(0, picBox.Name.Length - 6);
            //if (n == "Left" && ActIndex > 0) ActIndex--;
            //else if (n == "Right" && ActIndex < Acts.Count - 1) ActIndex++;
            //else return;
            if (n == "Left") {
                ActIndex--;
                if (ActIndex < 0) ActIndex = Acts.Count - 1;
            } else if (n == "Right") {
                ActIndex++;
                if (ActIndex >= Acts.Count) ActIndex = 0;
            } else return;
            LoadEvent();
        }

        private void SignPicBox_Click(object sender, EventArgs e) {
            int actID = Acts[ActIndex];

            if (db.Activities.FindByID(Acts[ActIndex]).MainUserId.Trim(' ') == UID) {
                MessageBox.Show("你是主揪你還報啥XDD", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (db.User_Activity.Select($"UserID = '{UID}' AND ActivityID = {actID}").Count() != 0) {
                MessageBox.Show("你已經報名過了!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tmp = db.User_Activity.AddUser_ActivityRow(db.Users.FindByID(UID), db.Activities.FindByID(actID));
            UA_Adapter.Update(tmp);

            MessageBox.Show("報名成功!\n可至上方 My Event 處查看活動", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEvent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ActIndex = 0;
            ReloadEvent();
        }

        private void Tmr_Tick(object sender, EventArgs e) {
            t++;
            if (t == 1) {
                t = 0;
                UsersAdapter.Fill(db.Users);
            }
            UA_Adapter.Fill(db.User_Activity);
            ActivityAdapter.Fill(db.Activities);

            notifyForm.Check();
            ReloadEvent();
            if (notifyForm.count == 0) {
                SpotPicBox.Visible = false;
                NotifyLabel.Visible = false;
            } else {
                SpotPicBox.Visible = true;
                NotifyLabel.Visible = true;
                int c = notifyForm.count;
                NotifyLabel.Text = c.ToString();
            }
        }
    }
}
