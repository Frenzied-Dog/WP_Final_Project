﻿namespace Final_Project {
    partial class NewPostForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPostForm));
            this.PostPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPicBox
            // 
            this.PostPicBox.BackColor = System.Drawing.Color.Transparent;
            this.PostPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PostPicBox.Image = global::Final_Project.Properties.Resources.發佈貼文Btn;
            this.PostPicBox.Location = new System.Drawing.Point(272, 500);
            this.PostPicBox.Name = "PostPicBox";
            this.PostPicBox.Size = new System.Drawing.Size(196, 64);
            this.PostPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PostPicBox.TabIndex = 0;
            this.PostPicBox.TabStop = false;
            this.PostPicBox.Click += new System.EventHandler(this.PostPicBox_Click);
            this.PostPicBox.MouseEnter += new System.EventHandler(this.PostPicBox_MouseEnter);
            this.PostPicBox.MouseLeave += new System.EventHandler(this.PostPicBox_MouseLeave);
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.發佈貼文;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 571);
            this.Controls.Add(this.PostPicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPostForm";
            this.Text = "New Post";
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PostPicBox;
    }
}