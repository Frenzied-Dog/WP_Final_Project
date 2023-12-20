using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class MyProfileForm : Form {
        string[] budgets = { "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        bool modifying = false;

        public MyProfileForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;

            //將 Profile Photo 變成圓形框  https://www.jb51.net/article/220686.htm
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ProfilePhoto.ClientRectangle);
            BudgetComboBox.DataSource = budgets;
            PreferTimeComboBox.DataSource = times;

            ProfilePhoto.Region = new Region(gp);

            ID_Label.Text = db.Me[0].Id;
            NickNameLabel.Text = db.Me[0].NickName;
            MajorTextBox.Text = db.Me[0]["Major"] != DBNull.Value ? db.Me[0].Major : "";
            GenderTextBox.Text = db.Me[0]["Gender"] != DBNull.Value ? db.Me[0].Gender : "";
            SelfTextBox.Text = db.Me[0]["AboutMe"] != DBNull.Value ? db.Me[0].AboutMe : "";
            BudgetComboBox.SelectedIndex = db.Me[0].Budget;
            PreferTimeComboBox.SelectedIndex = db.Me[0].PreferTime;
            ProfilePhoto.Image = Image.FromStream(new MemoryStream(db.Me[0].Pic));
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void ModifyPicBox_Click(object sender, EventArgs e) {
            modifying = !modifying;
            if (modifying) {
                MajorTextBox.ReadOnly = false;
                GenderTextBox.ReadOnly = false;
                SelfTextBox.ReadOnly = false;
                BudgetComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                PreferTimeComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                ModifyPicBox.Image = Properties.Resources.儲存更動Btn_2;
            } else {
                MajorTextBox.ReadOnly = true;
                GenderTextBox.ReadOnly = true;
                SelfTextBox.ReadOnly = true;
                BudgetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                PreferTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                ModifyPicBox.Image = Properties.Resources.編輯資料Btn_2;

            }
        }

        private void PicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Modify":
                if (modifying) picBox.Image = Properties.Resources.儲存更動Btn_2;
                else picBox.Image = Properties.Resources.編輯資料Btn_2;
                break;
            case "ReUpload":
                picBox.Image = Properties.Resources.ReUpload_2;
                break;
            case "ChangeNick":
                picBox.Image = Properties.Resources.ChangeNickName_2;
                break;
            default:
                break;
            }


        }

        private void PicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Modify":
                if (modifying)  picBox.Image = Properties.Resources.儲存更動Btn;
                else picBox.Image = Properties.Resources.編輯資料Btn;
                break;
            case "ReUpload":
                picBox.Image = Properties.Resources.ReUpload;
                break;
            case "ChangeNick":
                picBox.Image = Properties.Resources.ChangeNickName;
                break;
            default:
                break;
            }
        }
    }
}
