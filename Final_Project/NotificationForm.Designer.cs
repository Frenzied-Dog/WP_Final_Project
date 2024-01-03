namespace Final_Project {
    partial class NotificationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.db = new Final_Project.MainDataSet();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TitlePicBox = new System.Windows.Forms.PictureBox();
            this.DogPic = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.TitlePicBox);
            this.MainPanel.Location = new System.Drawing.Point(0, 118);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1265, 559);
            this.MainPanel.TabIndex = 9;
            // 
            // TitlePicBox
            // 
            this.TitlePicBox.BackColor = System.Drawing.Color.Transparent;
            this.TitlePicBox.Image = global::Final_Project.Properties.Resources.NotifyTitle;
            this.TitlePicBox.Location = new System.Drawing.Point(79, 12);
            this.TitlePicBox.Name = "TitlePicBox";
            this.TitlePicBox.Size = new System.Drawing.Size(303, 55);
            this.TitlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlePicBox.TabIndex = 1;
            this.TitlePicBox.TabStop = false;
            // 
            // DogPic
            // 
            this.DogPic.BackColor = System.Drawing.Color.Transparent;
            this.DogPic.Image = global::Final_Project.Properties.Resources.CuteDog_3;
            this.DogPic.Location = new System.Drawing.Point(1111, 67);
            this.DogPic.Name = "DogPic";
            this.DogPic.Size = new System.Drawing.Size(138, 138);
            this.DogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DogPic.TabIndex = 12;
            this.DogPic.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Final_Project.Properties.Resources.mainLabel;
            this.LogoPicBox.Location = new System.Drawing.Point(0, -7);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(345, 100);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 11;
            this.LogoPicBox.TabStop = false;
            // 
            // MarkPicBox
            // 
            this.MarkPicBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkPicBox.Image = global::Final_Project.Properties.Resources.mark;
            this.MarkPicBox.Location = new System.Drawing.Point(485, 672);
            this.MarkPicBox.Name = "MarkPicBox";
            this.MarkPicBox.Size = new System.Drawing.Size(330, 45);
            this.MarkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarkPicBox.TabIndex = 10;
            this.MarkPicBox.TabStop = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.DogPic);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.MarkPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notifications";
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet db;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.PictureBox MarkPicBox;
        private System.Windows.Forms.PictureBox DogPic;
        private System.Windows.Forms.PictureBox TitlePicBox;
    }
}