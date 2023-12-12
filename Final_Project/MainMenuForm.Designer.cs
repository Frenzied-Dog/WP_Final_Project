﻿namespace Final_Project {
    partial class MainMenuForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.db = new Final_Project.Final_ProjectDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.NotifyPicBox = new System.Windows.Forms.PictureBox();
            this.CreateEventPicBox = new System.Windows.Forms.PictureBox();
            this.MyEventPicBox = new System.Windows.Forms.PictureBox();
            this.MyProfilePicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightPicBox = new System.Windows.Forms.PictureBox();
            this.LeftPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.HomePicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotifyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEventPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyEventPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyProfilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.pictureBox3);
            this.MainPanel.Controls.Add(this.comboBox2);
            this.MainPanel.Controls.Add(this.comboBox1);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.RightPicBox);
            this.MainPanel.Controls.Add(this.LeftPicBox);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.PicBox1);
            this.MainPanel.Controls.Add(this.HomePicBox);
            this.MainPanel.Controls.Add(this.pictureBox5);
            this.MainPanel.Location = new System.Drawing.Point(0, 88);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1265, 585);
            this.MainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(780, 1219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "--PlaceHolder--";
            // 
            // db
            // 
            this.db.DataSetName = "Final_ProjectDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Snow;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(429, 740);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 26);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Budget";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Snow;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(546, 740);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 26);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.Text = "Time";
            // 
            // NotifyPicBox
            // 
            this.NotifyPicBox.Image = global::Final_Project.Properties.Resources.NotiticationBtn;
            this.NotifyPicBox.Location = new System.Drawing.Point(1060, 16);
            this.NotifyPicBox.Name = "NotifyPicBox";
            this.NotifyPicBox.Size = new System.Drawing.Size(188, 66);
            this.NotifyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NotifyPicBox.TabIndex = 5;
            this.NotifyPicBox.TabStop = false;
            this.NotifyPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.NotifyPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.NotifyPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // CreateEventPicBox
            // 
            this.CreateEventPicBox.Image = global::Final_Project.Properties.Resources.CreatEventBtn;
            this.CreateEventPicBox.Location = new System.Drawing.Point(855, 16);
            this.CreateEventPicBox.Name = "CreateEventPicBox";
            this.CreateEventPicBox.Size = new System.Drawing.Size(188, 66);
            this.CreateEventPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CreateEventPicBox.TabIndex = 5;
            this.CreateEventPicBox.TabStop = false;
            this.CreateEventPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.CreateEventPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.CreateEventPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // MyEventPicBox
            // 
            this.MyEventPicBox.Image = global::Final_Project.Properties.Resources.MyEventBtn;
            this.MyEventPicBox.Location = new System.Drawing.Point(650, 16);
            this.MyEventPicBox.Name = "MyEventPicBox";
            this.MyEventPicBox.Size = new System.Drawing.Size(188, 66);
            this.MyEventPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MyEventPicBox.TabIndex = 5;
            this.MyEventPicBox.TabStop = false;
            this.MyEventPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.MyEventPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.MyEventPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // MyProfilePicBox
            // 
            this.MyProfilePicBox.Image = global::Final_Project.Properties.Resources.MyProfileBtn;
            this.MyProfilePicBox.Location = new System.Drawing.Point(445, 16);
            this.MyProfilePicBox.Name = "MyProfilePicBox";
            this.MyProfilePicBox.Size = new System.Drawing.Size(188, 66);
            this.MyProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MyProfilePicBox.TabIndex = 5;
            this.MyProfilePicBox.TabStop = false;
            this.MyProfilePicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.MyProfilePicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.MyProfilePicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.報名Btn__1_;
            this.pictureBox3.Location = new System.Drawing.Point(773, 1084);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 52);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.CustomizeLabel;
            this.pictureBox1.Location = new System.Drawing.Point(277, 740);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 23);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // RightPicBox
            // 
            this.RightPicBox.Image = global::Final_Project.Properties.Resources.RightArrow1;
            this.RightPicBox.Location = new System.Drawing.Point(1098, 941);
            this.RightPicBox.Name = "RightPicBox";
            this.RightPicBox.Size = new System.Drawing.Size(40, 40);
            this.RightPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RightPicBox.TabIndex = 28;
            this.RightPicBox.TabStop = false;
            // 
            // LeftPicBox
            // 
            this.LeftPicBox.Image = global::Final_Project.Properties.Resources.LeftArrow;
            this.LeftPicBox.Location = new System.Drawing.Point(180, 941);
            this.LeftPicBox.Name = "LeftPicBox";
            this.LeftPicBox.Size = new System.Drawing.Size(40, 40);
            this.LeftPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LeftPicBox.TabIndex = 27;
            this.LeftPicBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.EventInfoBackground;
            this.pictureBox2.Location = new System.Drawing.Point(277, 769);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(764, 385);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // PicBox1
            // 
            this.PicBox1.Image = global::Final_Project.Properties.Resources.JoinEventLabel;
            this.PicBox1.Location = new System.Drawing.Point(101, 654);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(493, 50);
            this.PicBox1.TabIndex = 25;
            this.PicBox1.TabStop = false;
            // 
            // HomePicBox
            // 
            this.HomePicBox.Image = global::Final_Project.Properties.Resources.HomePhotoFinal;
            this.HomePicBox.Location = new System.Drawing.Point(0, 0);
            this.HomePicBox.Name = "HomePicBox";
            this.HomePicBox.Size = new System.Drawing.Size(1248, 598);
            this.HomePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicBox.TabIndex = 0;
            this.HomePicBox.TabStop = false;
            this.HomePicBox.Click += new System.EventHandler(this.HomePicBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Final_Project.Properties.Resources.ellipsis_1;
            this.pictureBox5.Location = new System.Drawing.Point(618, 1140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // MarkPicBox
            // 
            this.MarkPicBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkPicBox.Image = global::Final_Project.Properties.Resources.mark;
            this.MarkPicBox.Location = new System.Drawing.Point(485, 674);
            this.MarkPicBox.Name = "MarkPicBox";
            this.MarkPicBox.Size = new System.Drawing.Size(330, 45);
            this.MarkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarkPicBox.TabIndex = 2;
            this.MarkPicBox.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Final_Project.Properties.Resources.mainLabel;
            this.LogoPicBox.Location = new System.Drawing.Point(0, -6);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(345, 100);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 3;
            this.LogoPicBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.NotifyPicBox);
            this.Controls.Add(this.CreateEventPicBox);
            this.Controls.Add(this.MyEventPicBox);
            this.Controls.Add(this.MyProfilePicBox);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MarkPicBox);
            this.Controls.Add(this.LogoPicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotifyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEventPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyEventPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyProfilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MarkPicBox;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.PictureBox MyProfilePicBox;
        private System.Windows.Forms.PictureBox MyEventPicBox;
        private System.Windows.Forms.PictureBox CreateEventPicBox;
        private System.Windows.Forms.PictureBox NotifyPicBox;
        private System.Windows.Forms.PictureBox HomePicBox;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox RightPicBox;
        private System.Windows.Forms.PictureBox LeftPicBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private Final_ProjectDataSet db;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}