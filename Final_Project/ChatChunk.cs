using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class ChatChunk : UserControl {
        MainDataSet.ChatRow act;

        public ChatChunk() {
            InitializeComponent();
        }

        public ChatChunk(MainDataSet db, MainDataSet.ChatRow act) {
            InitializeComponent();
            this.db = db;
            this.act = act;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(Avatar.ClientRectangle);
            Avatar.Region = new Region(gp);
            Avatar.Image = Image.FromStream(new MemoryStream(db.Users.FindByID(act.SenderID).Pic));

            NameLabel.Text = db.Users.FindByID(act.SenderID).NickName;
            TextsLabel.Text = act.Content;
            TimeLabel.Text = act.Time.ToString("f");
        }
    }
}
