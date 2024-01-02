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
    public partial class NotificationForm : Form {
        List<NotifyChunk> lists = new List<NotifyChunk>();

        public NotificationForm(MainDataSet db) {
            InitializeComponent();
            this.db = db;
        }

        public void AddNotify(NotifyType type, MainDataSet.ActivitiesRow act) {
            var tmp = new NotifyChunk(type, act);
            tmp.Location = new Point(145, 100 + 220 * lists.Count);
            MainPanel.Controls.Add(tmp);
            lists.Add(tmp);
        }

        private void NotificationForm_Load(object sender, EventArgs e) {

        }
    }
}
