namespace Final_Project {
    partial class DiscussionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscussionForm));
            this.db = new Final_Project.MainDataSet();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.ChatAdapter = new Final_Project.MainDataSetTableAdapters.ChatTableAdapter();
            this.EmptyLabel = new System.Windows.Forms.Label();
            this.DogPic = new System.Windows.Forms.PictureBox();
            this.TitlePicBox = new System.Windows.Forms.PictureBox();
            this.PostPicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.ChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChatPanel
            // 
            this.ChatPanel.AutoScroll = true;
            this.ChatPanel.Controls.Add(this.EmptyLabel);
            this.ChatPanel.Controls.Add(this.TitlePicBox);
            this.ChatPanel.Controls.Add(this.PostPicBox);
            this.ChatPanel.Location = new System.Drawing.Point(0, 97);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1265, 581);
            this.ChatPanel.TabIndex = 6;
            // 
            // ChatAdapter
            // 
            this.ChatAdapter.ClearBeforeFill = true;
            // 
            // EmptyLabel
            // 
            this.EmptyLabel.AutoSize = true;
            this.EmptyLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmptyLabel.Location = new System.Drawing.Point(118, 164);
            this.EmptyLabel.Name = "EmptyLabel";
            this.EmptyLabel.Size = new System.Drawing.Size(369, 80);
            this.EmptyLabel.TabIndex = 3;
            this.EmptyLabel.Text = "目前尚無人發佈貼文！\r\n趕快來和大家說說話吧！\r\n";
            // 
            // DogPic
            // 
            this.DogPic.Image = global::Final_Project.Properties.Resources.CuteDog;
            this.DogPic.Location = new System.Drawing.Point(760, 250);
            this.DogPic.Name = "DogPic";
            this.DogPic.Size = new System.Drawing.Size(195, 203);
            this.DogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DogPic.TabIndex = 5;
            this.DogPic.TabStop = false;
            // 
            // TitlePicBox
            // 
            this.TitlePicBox.Image = global::Final_Project.Properties.Resources.DiscussTitle;
            this.TitlePicBox.Location = new System.Drawing.Point(125, 22);
            this.TitlePicBox.Name = "TitlePicBox";
            this.TitlePicBox.Size = new System.Drawing.Size(470, 60);
            this.TitlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitlePicBox.TabIndex = 2;
            this.TitlePicBox.TabStop = false;
            // 
            // PostPicBox
            // 
            this.PostPicBox.BackColor = System.Drawing.Color.Transparent;
            this.PostPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PostPicBox.Image = global::Final_Project.Properties.Resources.發佈貼文Btn;
            this.PostPicBox.Location = new System.Drawing.Point(125, 302);
            this.PostPicBox.Name = "PostPicBox";
            this.PostPicBox.Size = new System.Drawing.Size(196, 64);
            this.PostPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PostPicBox.TabIndex = 1;
            this.PostPicBox.TabStop = false;
            this.PostPicBox.Click += new System.EventHandler(this.PostPicBox_Click);
            this.PostPicBox.MouseEnter += new System.EventHandler(this.PostPicBox_MouseEnter);
            this.PostPicBox.MouseLeave += new System.EventHandler(this.PostPicBox_MouseLeave);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Final_Project.Properties.Resources.mainLabel;
            this.LogoPicBox.Location = new System.Drawing.Point(0, -6);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(345, 100);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 8;
            this.LogoPicBox.TabStop = false;
            // 
            // MarkPicBox
            // 
            this.MarkPicBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkPicBox.Image = global::Final_Project.Properties.Resources.mark;
            this.MarkPicBox.Location = new System.Drawing.Point(485, 673);
            this.MarkPicBox.Name = "MarkPicBox";
            this.MarkPicBox.Size = new System.Drawing.Size(330, 45);
            this.MarkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarkPicBox.TabIndex = 7;
            this.MarkPicBox.TabStop = false;
            // 
            // DiscussionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.DogPic);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.MarkPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiscussionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discussion";
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet db;
        private System.Windows.Forms.PictureBox MarkPicBox;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.PictureBox PostPicBox;
        private System.Windows.Forms.PictureBox TitlePicBox;
        private MainDataSetTableAdapters.ChatTableAdapter ChatAdapter;
        private System.Windows.Forms.PictureBox DogPic;
        private System.Windows.Forms.Label EmptyLabel;
    }
}