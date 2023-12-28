using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
	public partial class NewUserForm : Form {
		//MainDataSet db;
		string ID, name;
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };

        public NewUserForm(MainDataSet db, string ID, string name) {
			InitializeComponent();
			this.db = db;
			this.ID = ID;
			this.name = name;
			BudgetComboBox.DataSource = budgets;
			PreferTimeComboBox.DataSource = times;
		}

		private void CommitPicBox_Click(object sender, EventArgs e) {
			string major = MajorTextBox.Text;
			string gender = GenderTextBox.Text;
			string nickname = NicknameTextBox.Text;
			int budgetType = BudgetComboBox.SelectedIndex;
			int preferTime = PreferTimeComboBox.SelectedIndex;
			string aboutMe = AboutMeTextBox.Text;

			if (major == "Ex: 電機115" || major == "") {
				MessageBox.Show("請輸入系級!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (budgetType == -1 && BudgetComboBox.Text != "") {
				MessageBox.Show("請選擇預算類型or留空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			
			if (preferTime == -1 && PreferTimeComboBox.Text != "") {
				MessageBox.Show("請選擇偏好時間or留空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (gender == "Ex: 男 ( 選填 )") gender = "";
			if (nickname == "( 選填 )") nickname = name;
			if (aboutMe == "可以說說您的興趣與喜歡吃的食物等等，讓大家\r\n能夠更認識你！ ( 選填 )")
				aboutMe = "這傢伙人狠話不多...啥都沒留:(";

			using (MemoryStream mStream = new MemoryStream()) {
				Bitmap img = Properties.Resources.CuteDog;
				img.Save(mStream, ImageFormat.Bmp);
				var defaultAvatar =  mStream.ToArray();

				db.Me.AddMeRow(ID, name, nickname, major, budgetType, preferTime, defaultAvatar, aboutMe, gender);
				MeAdapter.Update(db.Me);
				//MeAdapter.Insert(ID, name, nickname, major, budgetType, preferTime, defaultAvatar, aboutMe, gender);
				//MeAdapter.Fill(db.Me, ID);
				MessageBox.Show("註冊成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};

            new MainMenuForm(db).Show();
            Close();
        }

		private void CommitPicBox_MouseEnter(object sender, EventArgs e) {
			CommitPicBox.Image = Properties.Resources.完成註冊Btn_2;
		}

		private void CommitPicBox_MouseLeave(object sender, EventArgs e) {
			CommitPicBox.Image = Properties.Resources.完成註冊Btn;
		}

		private void TextBoxHint_Enter(object sender, EventArgs e) {
			TextBox box = (TextBox)sender;
			switch (box.Name.Substring(0, box.Name.Length - 7)) {
			case "Major":
				if (box.Text == "Ex: 電機115") {
					box.Text = "";
					box.ForeColor = Color.Black;
				}
				break;
			case "Gender":
				if (box.Text == "Ex: 男 ( 選填 )") {
					box.Text = "";
					box.ForeColor = Color.Black;
				}
				break;
			case "Nickname":
				if (box.Text == "( 選填 )") {
					box.Text = "";
					box.ForeColor = Color.Black;
				}
				break;
			case "AboutMe":
				if (box.Text == "可以說說您的興趣與喜歡吃的食物等等，讓大家\r\n能夠更認識你！ ( 選填 )") {
					box.Text = "";
					box.ForeColor = Color.Black;
				}
				break;
			default:
				break;
			}
		}

		private void TextBoxHint_Leave(object sender, EventArgs e) {
			TextBox box = (TextBox)sender;
			switch (box.Name.Substring(0, box.Name.Length - 7)) {
			case "Major":
				if (box.Text == "") {
					box.Text = "Ex: 電機115";
					box.ForeColor = Color.DimGray;
				}
				break;
			case "Gender":
				if (box.Text == "") {
					box.Text = "Ex: 男 ( 選填 )";
					box.ForeColor = Color.DimGray;
				}
				break;
			case "Nickname":
				if (box.Text == "") {
					box.Text = "( 選填 )";
					box.ForeColor = Color.DimGray;
				}
				break;
			case "AboutMe":
				if (box.Text == "") {
					box.Text = "可以說說您的興趣與喜歡吃的食物等等，讓大家\r\n能夠更認識你！ ( 選填 )";
					box.ForeColor = Color.DimGray;
				}
				break;
			default:
				break;
			}
		}

		private void NewUserForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (Application.OpenForms.Count == 0) Application.Exit();
		}
	}
}
