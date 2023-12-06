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
        Final_ProjectDataSet db;

        public MainMenuForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e) {
            MainPanel.AutoScrollPosition = new Point(0, 0);
        }
    }
}
