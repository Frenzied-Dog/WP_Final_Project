using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project {
    public partial class CreateEventForm : Form {
        public CreateEventForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;
        }
    }
}
