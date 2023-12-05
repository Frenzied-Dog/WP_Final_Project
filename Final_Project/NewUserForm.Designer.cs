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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MajorTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MajorTextBox.Location = new System.Drawing.Point(460, 237);
            this.MajorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(435, 33);
            this.MajorTextBox.TabIndex = 0;
            this.MajorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GenderTextBox.Location = new System.Drawing.Point(460, 285);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(435, 33);
            this.GenderTextBox.TabIndex = 0;
            this.GenderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NicknameTextBox.Location = new System.Drawing.Point(460, 339);
            this.NicknameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(435, 33);
            this.NicknameTextBox.TabIndex = 0;
            this.NicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BudgetComboBox
            // 
            this.BudgetComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BudgetComboBox.FormattingEnabled = true;
            this.BudgetComboBox.Location = new System.Drawing.Point(460, 396);
            this.BudgetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BudgetComboBox.Name = "BudgetComboBox";
            this.BudgetComboBox.Size = new System.Drawing.Size(435, 32);
            this.BudgetComboBox.TabIndex = 1;
            // 
            // PreferTimeComboBox
            // 
            this.PreferTimeComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PreferTimeComboBox.FormattingEnabled = true;
            this.PreferTimeComboBox.Location = new System.Drawing.Point(460, 455);
            this.PreferTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreferTimeComboBox.Name = "PreferTimeComboBox";
            this.PreferTimeComboBox.Size = new System.Drawing.Size(435, 32);
            this.PreferTimeComboBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(460, 526);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 82);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.報名Btn;
            this.pictureBox1.Location = new System.Drawing.Point(975, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.初次登入填寫資料;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PreferTimeComboBox);
            this.Controls.Add(this.BudgetComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.MajorTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewUserForm";
            this.Text = "Personal Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.ComboBox BudgetComboBox;
        private System.Windows.Forms.ComboBox PreferTimeComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}