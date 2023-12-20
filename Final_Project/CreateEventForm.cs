using Final_Project.Final_ProjectDataSetTableAdapters;
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

        public CreateEventForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
            Maps = new MapForm();
        }

        private void CreatePicBox_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            if (ShopTextBox.Text == "" || AddressTextBox.Text == "") {
                MessageBox.Show("請輸入店名及地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = rnd.Next();
            //db.Activities.AddActivitiesRow(id, ShopTextBox.Text, AddressTextBox.Text, db.Me[0].Id, , IntroTextBox.Text, DateTime.Now);
            db.User_Activity.AddUser_ActivityRow(db.Me[0].Id, id);
            ActivityAdapter.Update(db.Activities);
            User_ActivityAdapter.Update(db.User_Activity);

            MessageBox.Show("活動已發布～\n\r祝您結交志同道合的朋友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UseMapPicBox_Click(object sender, EventArgs e) {
            Maps.ShowDialog();
            ShopTextBox.Text = Maps.ShopName;
            AddressTextBox.Text = Maps.Address;
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
