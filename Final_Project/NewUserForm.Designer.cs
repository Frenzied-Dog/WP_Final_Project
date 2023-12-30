namespace Final_Project {
    partial class NewUserForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.BudgetComboBox = new System.Windows.Forms.ComboBox();
            this.PreferTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AboutMeTextBox = new System.Windows.Forms.TextBox();
            this.CommitPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db = new Final_Project.MainDataSet();
            this.UsersAdapter = new Final_Project.MainDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CommitPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MajorTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MajorTextBox.Location = new System.Drawing.Point(460, 237);
            this.MajorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(435, 33);
            this.MajorTextBox.TabIndex = 0;
            this.MajorTextBox.Text = "Ex: 電機115";
            this.MajorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MajorTextBox.Enter += new System.EventHandler(this.TextBoxHint_Enter);
            this.MajorTextBox.Leave += new System.EventHandler(this.TextBoxHint_Leave);
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenderTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.GenderTextBox.Location = new System.Drawing.Point(460, 285);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(435, 33);
            this.GenderTextBox.TabIndex = 1;
            this.GenderTextBox.Text = "Ex: 男 ( 選填 )";
            this.GenderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GenderTextBox.Enter += new System.EventHandler(this.TextBoxHint_Enter);
            this.GenderTextBox.Leave += new System.EventHandler(this.TextBoxHint_Leave);
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NicknameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.NicknameTextBox.Location = new System.Drawing.Point(460, 339);
            this.NicknameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(435, 33);
            this.NicknameTextBox.TabIndex = 2;
            this.NicknameTextBox.Text = "( 選填 )";
            this.NicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NicknameTextBox.Enter += new System.EventHandler(this.TextBoxHint_Enter);
            this.NicknameTextBox.Leave += new System.EventHandler(this.TextBoxHint_Leave);
            // 
            // BudgetComboBox
            // 
            this.BudgetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BudgetComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BudgetComboBox.FormattingEnabled = true;
            this.BudgetComboBox.Location = new System.Drawing.Point(460, 396);
            this.BudgetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BudgetComboBox.Name = "BudgetComboBox";
            this.BudgetComboBox.Size = new System.Drawing.Size(435, 32);
            this.BudgetComboBox.TabIndex = 3;
            // 
            // PreferTimeComboBox
            // 
            this.PreferTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferTimeComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PreferTimeComboBox.FormattingEnabled = true;
            this.PreferTimeComboBox.Location = new System.Drawing.Point(460, 455);
            this.PreferTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreferTimeComboBox.Name = "PreferTimeComboBox";
            this.PreferTimeComboBox.Size = new System.Drawing.Size(435, 32);
            this.PreferTimeComboBox.TabIndex = 4;
            // 
            // AboutMeTextBox
            // 
            this.AboutMeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboutMeTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMeTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.AboutMeTextBox.Location = new System.Drawing.Point(460, 526);
            this.AboutMeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AboutMeTextBox.Multiline = true;
            this.AboutMeTextBox.Name = "AboutMeTextBox";
            this.AboutMeTextBox.Size = new System.Drawing.Size(435, 82);
            this.AboutMeTextBox.TabIndex = 5;
            this.AboutMeTextBox.Text = "可以說說您的興趣與喜歡吃的食物等等，讓大家\r\n能夠更認識你！ ( 選填 )";
            this.AboutMeTextBox.Enter += new System.EventHandler(this.TextBoxHint_Enter);
            this.AboutMeTextBox.Leave += new System.EventHandler(this.TextBoxHint_Leave);
            // 
            // CommitPicBox
            // 
            this.CommitPicBox.BackColor = System.Drawing.Color.Transparent;
            this.CommitPicBox.Image = global::Final_Project.Properties.Resources.完成註冊Btn;
            this.CommitPicBox.Location = new System.Drawing.Point(970, 582);
            this.CommitPicBox.Name = "CommitPicBox";
            this.CommitPicBox.Size = new System.Drawing.Size(143, 46);
            this.CommitPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CommitPicBox.TabIndex = 2;
            this.CommitPicBox.TabStop = false;
            this.CommitPicBox.Click += new System.EventHandler(this.CommitPicBox_Click);
            this.CommitPicBox.MouseEnter += new System.EventHandler(this.CommitPicBox_MouseEnter);
            this.CommitPicBox.MouseLeave += new System.EventHandler(this.CommitPicBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dev Branch";
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsersAdapter
            // 
            this.UsersAdapter.ClearBeforeFill = true;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.初次登入填寫資料;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommitPicBox);
            this.Controls.Add(this.PreferTimeComboBox);
            this.Controls.Add(this.BudgetComboBox);
            this.Controls.Add(this.AboutMeTextBox);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.MajorTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewUserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CommitPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.ComboBox BudgetComboBox;
        private System.Windows.Forms.ComboBox PreferTimeComboBox;
        private System.Windows.Forms.TextBox AboutMeTextBox;
        private System.Windows.Forms.PictureBox CommitPicBox;
        private System.Windows.Forms.Label label1;
        private MainDataSet db;
        private MainDataSetTableAdapters.UsersTableAdapter UsersAdapter;
    }
}