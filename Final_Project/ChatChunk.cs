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
        //MainDataSet.ChatRow chat;

        public ChatChunk() {
            InitializeComponent();
        }

        //public ChatChunk(MainDataSet db, int actID) {
        //    InitializeComponent();
        //    this.db = db;
        //    chat = db.Chat[actID];
        //    GraphicsPath gp = new GraphicsPath();
        //    gp.AddEllipse(Avatar.ClientRectangle);
        //    Avatar.Region = new Region(gp);
        //    Avatar.Image = Image.FromStream(new MemoryStream(db.Users.FindByID(chat.SenderID).Pic));

        //    NameLabel.Text = db.Users.FindByID(chat.SenderID).NickName;
        //    TextsLabel.Text = chat.Content;
        //    TimeLabel.Text = chat.Time.ToString("f");
        //}

        public ChatChunk(MainDataSet.ChatRow chat) {
            InitializeComponent();

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(Avatar.ClientRectangle);
            Avatar.Region = new Region(gp);
            Avatar.Image = Image.FromStream(new MemoryStream(chat.GetParentRow("FK_Chat_ToUser").Field<byte[]>("Pic")));
            NameLabel.Text = chat.GetParentRow("FK_Chat_ToUser").Field<string>("NickName");
            TextsLabel.Text = chat.Content;
            TimeLabel.Text = chat.Time.ToString("f");
        }
    }
}
