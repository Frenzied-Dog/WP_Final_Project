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

namespace Final_Project
{
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            //將profile photo 變成圓形框  https://www.jb51.net/article/220686.htm
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(profile_photo.ClientRectangle);
            Region region = new Region(gp);
            profile_photo.Region = region;
            gp.Dispose();
            region.Dispose();
        }
    }
}
