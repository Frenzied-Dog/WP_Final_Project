namespace Final_Project {
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
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HomePicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyProfilePicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            this.MyEventPicBox = new System.Windows.Forms.PictureBox();
            this.CreateEventPicBox = new System.Windows.Forms.PictureBox();
            this.NotifyPicBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyProfilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyEventPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEventPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotifyPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.listBox4);
            this.MainPanel.Controls.Add(this.listBox3);
            this.MainPanel.Controls.Add(this.listBox2);
            this.MainPanel.Controls.Add(this.listBox1);
            this.MainPanel.Controls.Add(this.HomePicBox);
            this.MainPanel.Location = new System.Drawing.Point(0, 115);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1265, 565);
            this.MainPanel.TabIndex = 1;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(584, 798);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 94);
            this.listBox4.TabIndex = 25;
            this.listBox4.TabStop = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(584, 1121);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 94);
            this.listBox3.TabIndex = 24;
            this.listBox3.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(584, 1489);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 23;
            this.listBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(584, 1776);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 22;
            this.listBox1.TabStop = false;
            // 
            // HomePicBox
            // 
            this.HomePicBox.Image = global::Final_Project.Properties.Resources.HomePhoto;
            this.HomePicBox.Location = new System.Drawing.Point(0, 0);
            this.HomePicBox.Name = "HomePicBox";
            this.HomePicBox.Size = new System.Drawing.Size(1248, 730);
            this.HomePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicBox.TabIndex = 0;
            this.HomePicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(1178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dev Branch";
            // 
            // MyProfilePicBox
            // 
            this.MyProfilePicBox.Image = global::Final_Project.Properties.Resources.MyProfileBtn;
            this.MyProfilePicBox.Location = new System.Drawing.Point(422, 28);
            this.MyProfilePicBox.Name = "MyProfilePicBox";
            this.MyProfilePicBox.Size = new System.Drawing.Size(188, 66);
            this.MyProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MyProfilePicBox.TabIndex = 5;
            this.MyProfilePicBox.TabStop = false;
            this.MyProfilePicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.MyProfilePicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.MyProfilePicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Final_Project.Properties.Resources.mainLabel;
            this.LogoPicBox.Location = new System.Drawing.Point(0, 9);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(345, 100);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 3;
            this.LogoPicBox.TabStop = false;
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
            // MyEventPicBox
            // 
            this.MyEventPicBox.Image = global::Final_Project.Properties.Resources.MyEventBtn;
            this.MyEventPicBox.Location = new System.Drawing.Point(627, 28);
            this.MyEventPicBox.Name = "MyEventPicBox";
            this.MyEventPicBox.Size = new System.Drawing.Size(188, 66);
            this.MyEventPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MyEventPicBox.TabIndex = 5;
            this.MyEventPicBox.TabStop = false;
            this.MyEventPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.MyEventPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.MyEventPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // CreateEventPicBox
            // 
            this.CreateEventPicBox.Image = global::Final_Project.Properties.Resources.CreatEventBtn;
            this.CreateEventPicBox.Location = new System.Drawing.Point(832, 28);
            this.CreateEventPicBox.Name = "CreateEventPicBox";
            this.CreateEventPicBox.Size = new System.Drawing.Size(188, 66);
            this.CreateEventPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CreateEventPicBox.TabIndex = 5;
            this.CreateEventPicBox.TabStop = false;
            this.CreateEventPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.CreateEventPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.CreateEventPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
            // 
            // NotifyPicBox
            // 
            this.NotifyPicBox.Image = global::Final_Project.Properties.Resources.NotiticationBtn;
            this.NotifyPicBox.Location = new System.Drawing.Point(1037, 28);
            this.NotifyPicBox.Name = "NotifyPicBox";
            this.NotifyPicBox.Size = new System.Drawing.Size(188, 66);
            this.NotifyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NotifyPicBox.TabIndex = 5;
            this.NotifyPicBox.TabStop = false;
            this.NotifyPicBox.Click += new System.EventHandler(this.MenuPicBox_Click);
            this.NotifyPicBox.MouseEnter += new System.EventHandler(this.MenuPicBox_MouseEnter);
            this.NotifyPicBox.MouseLeave += new System.EventHandler(this.MenuPicBox_MouseLeave);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MarkPicBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyProfilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyEventPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEventPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotifyPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePicBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox MarkPicBox;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MyProfilePicBox;
        private System.Windows.Forms.PictureBox MyEventPicBox;
        private System.Windows.Forms.PictureBox CreateEventPicBox;
        private System.Windows.Forms.PictureBox NotifyPicBox;
    }
}