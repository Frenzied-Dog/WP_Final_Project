using Final_Project.MainDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project {
    public partial class CreateEventForm : Form {
        MapForm Maps;
        string UID = "";
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };

        public CreateEventForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            this.UID = UID;
            Maps = new MapForm();
            BudgetComboBox.DataSource = budgets;
            DatePicker.Value = DateTime.Now;
            TimePicker.Value = DateTime.Now;
        }

        private void CreatePicBox_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            if (ShopTextBox.Text == "" || AddressTextBox.Text == "") {
                MessageBox.Show("請輸入店名及地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            DateTime est = DatePicker.Value.Date.Add(TimePicker.Value.TimeOfDay);
            string intro = IntroTextBox.Text;
            // check if est is in the past
            if (est.CompareTo(DateTime.Now) < 0) {
                MessageBox.Show("活動時間不得為過去時間", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // check if est is in the future
            if (est.CompareTo(DateTime.Now.AddMonths(1)) > 0) {
                MessageBox.Show("活動時間不得超過一個月", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            MessageBox.Show("活動時間：" + est.ToString() + "\n\r預算：" + budgets[BudgetComboBox.SelectedIndex] + "\n\r地點：" + ShopTextBox.Text, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (intro == "") {
                intro = "好吧看來有人不想介紹@@";
            }

            int hr = TimePicker.Value.Hour;
            int preferTime = 0;
            if (hr >= 6 && hr < 11) preferTime = 1;
            else if (hr >= 11 && hr < 13) preferTime = 2;
            else if (hr >= 13 && hr < 18) preferTime = 3;
            else if (hr >= 18 && hr < 23) preferTime = 4;
            else if (hr >= 23 || hr < 1) preferTime = 5;
            else if (hr >= 1 && hr < 6) preferTime = 6;

            int id = rnd.Next();
            db.Activities.AddActivitiesRow(id, ShopTextBox.Text, AddressTextBox.Text, db.Users.FindByID(UID), est, preferTime, intro, BudgetComboBox.SelectedIndex, DateTime.Now, false);
            ActivityAdapter.Update(db.Activities);

            var tmp = db.User_Activity.AddUser_ActivityRow(db.Users.FindByID(UID), db.Activities.FindByID(id));
            UA_Adapter.Update(tmp);

            MessageBox.Show("活動已發布～\n\r祝您結交志同道合的朋友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UseMapPicBox_Click(object sender, EventArgs e) {
            if (Maps.ShowDialog() == DialogResult.OK) {
                ShopTextBox.Text = Maps.ShopName;
                AddressTextBox.Text = Maps.Address;
            } 
        }

        private void PicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Create":
                picBox.Image = Properties.Resources.發布活動btn_2;
                break;
            case "UseMap":
                picBox.Image = Properties.Resources.使用地圖Btn_2;
                break;
            default:
                break;
            }
        }

        private void PicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Create":
                picBox.Image = Properties.Resources.發布活動btn;
                break;
            case "UseMap":
                picBox.Image = Properties.Resources.使用地圖Btn;
                break;
            default:
                break;
            }
        }
    }
}
