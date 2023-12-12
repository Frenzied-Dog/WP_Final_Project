namespace Final_Project {
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
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.db = new Final_Project.Final_ProjectDataSet();
            this.ChatAdapter = new Final_Project.Final_ProjectDataSetTableAdapters.ChatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
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
            // PostTextBox
            // 
            this.PostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostTextBox.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTextBox.Location = new System.Drawing.Point(38, 75);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(651, 419);
            this.PostTextBox.TabIndex = 1;
            // 
            // db
            // 
            this.db.DataSetName = "Final_ProjectDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChatAdapter
            // 
            this.ChatAdapter.ClearBeforeFill = true;
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.發佈貼文;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 571);
            this.Controls.Add(this.PostTextBox);
            this.Controls.Add(this.PostPicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPostForm";
            this.Text = "New Post";
            ((System.ComponentModel.ISupportInitialize)(this.PostPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PostPicBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private Final_ProjectDataSet db;
        private Final_ProjectDataSetTableAdapters.ChatTableAdapter ChatAdapter;
    }
}