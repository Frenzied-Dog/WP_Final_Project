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
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            this.HomePicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
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
            this.MainPanel.Size = new System.Drawing.Size(1265, 530);
            this.MainPanel.TabIndex = 1;
            // 
            // MarkPicBox
            // 
            this.MarkPicBox.Image = global::Final_Project.Properties.Resources.mark;
            this.MarkPicBox.Location = new System.Drawing.Point(485, 654);
            this.MarkPicBox.Name = "MarkPicBox";
            this.MarkPicBox.Size = new System.Drawing.Size(330, 45);
            this.MarkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarkPicBox.TabIndex = 2;
            this.MarkPicBox.TabStop = false;
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.MarkPicBox);
            this.Controls.Add(this.MainPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);

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
    }
}