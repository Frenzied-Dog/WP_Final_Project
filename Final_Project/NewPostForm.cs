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
        public NewPostForm() {
            InitializeComponent();
        }

        private void PostPicBox_Click(object sender, EventArgs e) {

        }

        private void PostPicBox_MouseEnter(object sender, EventArgs e) {
            PostPicBox.Image = Properties.Resources.發佈貼文Btn_2;
        }

        private void PostPicBox_MouseLeave(object sender, EventArgs e) {
            PostPicBox.Image = Properties.Resources.發佈貼文Btn;
        }
    }
}
