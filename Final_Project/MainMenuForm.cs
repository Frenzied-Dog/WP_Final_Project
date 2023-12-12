using Newtonsoft.Json.Linq;
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
    public partial class MainMenuForm : Form {
        //Final_ProjectDataSet db;
        MyProfileForm profileForm;
        MyEventForm eventForm;
        CreateEventForm createEventForm;
        NotificationForm notifyForm;

        public MainMenuForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
            profileForm = new MyProfileForm(db);
            eventForm = new MyEventForm(db);
            createEventForm = new CreateEventForm(db);
            notifyForm = new NotificationForm(db);
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e) {
            MainPanel.AutoScrollPosition = new Point(0, 0);
        }


        private void MenuPicBox_Click(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                profileForm.ShowDialog();
                break;
            case "MyEvent":
                eventForm.ShowDialog();
                break;
            case "CreateEvent":
                createEventForm.ShowDialog();
                break;
            case "Notify":
                notifyForm.ShowDialog();
                break;
            default:
                break;
            }
        }

        private void MenuPicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0,picBox.Name.Length-6)) {
            case "MyProfile":
                picBox.Image = Properties.Resources.MyProfileBtn_2;
                break;
            case "MyEvent":
                picBox.Image = Properties.Resources.MyEventBtn_2;
                break;
            case "CreateEvent":
                picBox.Image = Properties.Resources.CreatEventBtn_2;
                break;
            case "Notify":
                picBox.Image = Properties.Resources.NotiticationBtn_2;
                break;
            default:
                break;
        }
    }

        private void MenuPicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "MyProfile":
                picBox.Image = Properties.Resources.MyProfileBtn;
                break;
            case "MyEvent":
                picBox.Image = Properties.Resources.MyEventBtn;
                break;
            case "CreateEvent":
                picBox.Image = Properties.Resources.CreatEventBtn;
                break;
            case "Notify":
                picBox.Image = Properties.Resources.NotiticationBtn;
                break;
            default:
                break;
            }
        }

        private void HomePicBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
