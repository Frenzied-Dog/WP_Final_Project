namespace Final_Project
{
    partial class MyProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfileForm));
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.BudgetComboBox = new System.Windows.Forms.ComboBox();
            this.PreferTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SelfTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPicBox = new System.Windows.Forms.PictureBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.ProfilePhoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.db = new Final_Project.Final_ProjectDataSet();
            this.ReUploadPicBox = new System.Windows.Forms.PictureBox();
            this.ChangeNickPicBox = new System.Windows.Forms.PictureBox();
            this.MeAdapter = new Final_Project.Final_ProjectDataSetTableAdapters.MeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReUploadPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeNickPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.MajorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MajorTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MajorTextBox.Location = new System.Drawing.Point(633, 146);
            this.MajorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.ReadOnly = true;
            this.MajorTextBox.Size = new System.Drawing.Size(435, 33);
            this.MajorTextBox.TabIndex = 1;
            this.MajorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenderTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GenderTextBox.Location = new System.Drawing.Point(633, 214);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.ReadOnly = true;
            this.GenderTextBox.Size = new System.Drawing.Size(435, 33);
            this.GenderTextBox.TabIndex = 2;
            this.GenderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BudgetComboBox
            // 
            this.BudgetComboBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.BudgetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BudgetComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BudgetComboBox.FormattingEnabled = true;
            this.BudgetComboBox.Location = new System.Drawing.Point(633, 282);
            this.BudgetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BudgetComboBox.Name = "BudgetComboBox";
            this.BudgetComboBox.Size = new System.Drawing.Size(435, 32);
            this.BudgetComboBox.TabIndex = 3;
            // 
            // PreferTimeComboBox
            // 
            this.PreferTimeComboBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.PreferTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferTimeComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PreferTimeComboBox.FormattingEnabled = true;
            this.PreferTimeComboBox.Location = new System.Drawing.Point(633, 349);
            this.PreferTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreferTimeComboBox.Name = "PreferTimeComboBox";
            this.PreferTimeComboBox.Size = new System.Drawing.Size(435, 32);
            this.PreferTimeComboBox.TabIndex = 4;
            // 
            // SelfTextBox
            // 
            this.SelfTextBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.SelfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelfTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelfTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SelfTextBox.Location = new System.Drawing.Point(633, 419);
            this.SelfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelfTextBox.Multiline = true;
            this.SelfTextBox.Name = "SelfTextBox";
            this.SelfTextBox.ReadOnly = true;
            this.SelfTextBox.Size = new System.Drawing.Size(435, 82);
            this.SelfTextBox.TabIndex = 5;
            // 
            // ModifyPicBox
            // 
            this.ModifyPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ModifyPicBox.Image = global::Final_Project.Properties.Resources.編輯資料Btn;
            this.ModifyPicBox.Location = new System.Drawing.Point(894, 538);
            this.ModifyPicBox.Name = "ModifyPicBox";
            this.ModifyPicBox.Size = new System.Drawing.Size(174, 56);
            this.ModifyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ModifyPicBox.TabIndex = 6;
            this.ModifyPicBox.TabStop = false;
            this.ModifyPicBox.Click += new System.EventHandler(this.ModifyPicBox_Click);
            this.ModifyPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.ModifyPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(113, 470);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(166, 31);
            this.ID_Label.TabIndex = 8;
            this.ID_Label.Text = "AN4116039";
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NickNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameLabel.Location = new System.Drawing.Point(149, 504);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(98, 31);
            this.NickNameLabel.TabIndex = 9;
            this.NickNameLabel.Text = "張亨利";
            // 
            // ProfilePhoto
            // 
            this.ProfilePhoto.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePhoto.Image = global::Final_Project.Properties.Resources.編輯資料Btn;
            this.ProfilePhoto.Location = new System.Drawing.Point(83, 232);
            this.ProfilePhoto.Name = "ProfilePhoto";
            this.ProfilePhoto.Size = new System.Drawing.Size(220, 220);
            this.ProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePhoto.TabIndex = 15;
            this.ProfilePhoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dev Branch";
            // 
            // db
            // 
            this.db.DataSetName = "Final_ProjectDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReUploadPicBox
            // 
            this.ReUploadPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ReUploadPicBox.Image = global::Final_Project.Properties.Resources.ReUpload;
            this.ReUploadPicBox.Location = new System.Drawing.Point(119, 428);
            this.ReUploadPicBox.Name = "ReUploadPicBox";
            this.ReUploadPicBox.Size = new System.Drawing.Size(154, 39);
            this.ReUploadPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReUploadPicBox.TabIndex = 17;
            this.ReUploadPicBox.TabStop = false;
            this.ReUploadPicBox.Visible = false;
            // 
            // ChangeNickPicBox
            // 
            this.ChangeNickPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ChangeNickPicBox.Image = global::Final_Project.Properties.Resources.ChangeNickName;
            this.ChangeNickPicBox.Location = new System.Drawing.Point(148, 538);
            this.ChangeNickPicBox.Name = "ChangeNickPicBox";
            this.ChangeNickPicBox.Size = new System.Drawing.Size(99, 38);
            this.ChangeNickPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ChangeNickPicBox.TabIndex = 18;
            this.ChangeNickPicBox.TabStop = false;
            this.ChangeNickPicBox.Visible = false;
            // 
            // MeAdapter
            // 
            this.MeAdapter.ClearBeforeFill = true;
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.MyProfileBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.ChangeNickPicBox);
            this.Controls.Add(this.ReUploadPicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProfilePhoto);
            this.Controls.Add(this.NickNameLabel);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.ModifyPicBox);
            this.Controls.Add(this.SelfTextBox);
            this.Controls.Add(this.PreferTimeComboBox);
            this.Controls.Add(this.BudgetComboBox);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.MajorTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " My Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyProfileForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ModifyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReUploadPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeNickPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.ComboBox BudgetComboBox;
        private System.Windows.Forms.ComboBox PreferTimeComboBox;
        private System.Windows.Forms.TextBox SelfTextBox;
        private System.Windows.Forms.PictureBox ModifyPicBox;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.PictureBox ProfilePhoto;
        private System.Windows.Forms.Label label3;
        private Final_ProjectDataSet db;
        private System.Windows.Forms.PictureBox ReUploadPicBox;
        private System.Windows.Forms.PictureBox ChangeNickPicBox;
        private Final_ProjectDataSetTableAdapters.MeTableAdapter MeAdapter;
    }
}