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
        public NewUserForm() {
            InitializeComponent();
        }

        private void CommitPicBox_Click(object sender, EventArgs e) {

        }

        private void CommitPicBox_MouseEnter(object sender, EventArgs e) {
            CommitPicBox.Image = Properties.Resources.報名Btn_2;
        }

        private void CommitPicBox_MouseLeave(object sender, EventArgs e) {
            CommitPicBox.Image = Properties.Resources.報名Btn;
        }
    }
}
