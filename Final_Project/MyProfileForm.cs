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
    public partial class MyProfileForm : Form { 

        public MyProfileForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
            //將profile photo 變成圓形框  https://www.jb51.net/article/220686.htm
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ProfilePhoto.ClientRectangle);
            ProfilePhoto.Region = new Region(gp);
        }

        private void MyProfileForm_Load(object sender, EventArgs e) {
            MajorTextBox.Text = "Test";
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = DialogResult.OK;
        }
    }
}
