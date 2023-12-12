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
	public partial class NewPostForm : Form {
		int activityID = 0;

		public NewPostForm(Final_ProjectDataSet db, int ID) {
			InitializeComponent();
			activityID = ID;
			this.db = db;
		}

		private void PostPicBox_Click(object sender, EventArgs e) {
			if (PostTextBox.Text == "") {
				MessageBox.Show("請輸入貼文內容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show("確定要發佈貼文嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
				db.Chat.AddChatRow(activityID, (string)db.Me.Rows[0]["ID"], DateTime.Now, PostTextBox.Text);
				ChatAdapter.Update(db.Chat);
				Close();
			}
		}

		private void PostPicBox_MouseEnter(object sender, EventArgs e) {
			PostPicBox.Image = Properties.Resources.發佈貼文Btn_2;
		}

		private void PostPicBox_MouseLeave(object sender, EventArgs e) {
			PostPicBox.Image = Properties.Resources.發佈貼文Btn;
		}
	}
}
