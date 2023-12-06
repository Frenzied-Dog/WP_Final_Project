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
    public partial class NewUserForm : Form {
        Final_ProjectDataSet db;

        public NewUserForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
        }

        private void CommitPicBox_Click(object sender, EventArgs e) {

        }

        private void CommitPicBox_MouseEnter(object sender, EventArgs e) {
            CommitPicBox.Image = Properties.Resources.報名Btn_2;
        }

        private void CommitPicBox_MouseLeave(object sender, EventArgs e) {
            CommitPicBox.Image = Properties.Resources.報名Btn;
        }

        private void TextBoxHint_Enter(object sender, EventArgs e) {
            TextBox box = (TextBox)sender;
            switch (box.Name.Substring(0,box.Name.Length-7)) {
            case "Major":
                if (box.Text == "Ex: 電機115") {
                    box.Text = "";
                    box.ForeColor = Color.Black;
                }
                break;
            case "Gender":
                if (box.Text == "Ex: 男") {
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
                    box.Text = "Ex: 男";
                    box.ForeColor = Color.DimGray;
                }
                break;
            case "Nickname":
                if (box.Text == "") {
                    box.Text = "( 選填 )";
                    box.ForeColor = Color.DimGray;
                }
                break;
            default:
                break;
            }
        }
    }
}
