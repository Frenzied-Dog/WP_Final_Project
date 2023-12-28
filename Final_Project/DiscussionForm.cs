using Final_Project.MainDataSetTableAdapters;
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
    public partial class DiscussionForm : Form {
        int ActID;
        ChatChunk[] chunks = new ChatChunk[20];
        int chunkCount = 0;

        public DiscussionForm(MainDataSet db, int ActID) {
            InitializeComponent();
            this.db = db;
            this.ActID = ActID;
            ChatAdapter.Fill(db.Chat, ActID);
            ReloadChat();
        }

        void ReloadChat() {
            foreach (var chunk in chunks) {
                if (chunk != null) {
                    ChatPanel.Controls.Remove(chunk);
                    chunk.Dispose();
                }
            }
            chunkCount = 0;

            if (db.Chat.Count == 0) {
                PostPicBox.Location = new Point(125, 302);
                DogPic.Location = new Point(760, 250);
                DogPic.Image = Properties.Resources.CuteDog;
                EmptyLabel.Visible = true;
            } else {
                PostPicBox.Location = new Point(770, 22);
                DogPic.Location = new Point(1050, 145);
                DogPic.Image = Properties.Resources.CuteDog_2;
                EmptyLabel.Visible = false;
            }

            if (db.Chat.Count <= 20) {
                foreach (var chat in db.Chat) AddChunk(chunkCount);
            } else {
                for (int i = 0; i < 20; i++) AddChunk(db.Chat.Count - 20 + i);
            }
        }

        void AddChunk(int chatIndex) {
            chunks[chunkCount] = new ChatChunk(db, db.Chat[chatIndex]);
            ChatPanel.Controls.Add(chunks[chunkCount]);
            chunks[chunkCount].Location = new Point(130, 110 + chunkCount * 276);
            chunkCount++;
        }

        private void PostPicBox_Click(object sender, EventArgs e) {
            if (new NewPostForm(db, ActID).ShowDialog() == DialogResult.OK) {
                if (db.Chat.Count > 20 || db.Chat.Count == 1) ReloadChat();
                else AddChunk(db.Chat.Count - 1);
            }
        }

        private void PostPicBox_MouseEnter(object sender, EventArgs e) {
            PostPicBox.Image = Properties.Resources.發佈貼文Btn_2;
        }

        private void PostPicBox_MouseLeave(object sender, EventArgs e) {
            PostPicBox.Image = Properties.Resources.發佈貼文Btn;
        }
    }
}
