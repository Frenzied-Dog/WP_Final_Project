namespace Final_Project {
    partial class LoginForm {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.LoginPicBox = new System.Windows.Forms.PictureBox();
            this.DevLoginBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.db = new Final_Project.MainDataSet();
            this.ResetAvatarBtn = new System.Windows.Forms.Button();
            this.UsersAdapter = new Final_Project.MainDataSetTableAdapters.UsersTableAdapter();
            this.DevNewUserBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DevLoginAsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ID.Location = new System.Drawing.Point(499, 313);
            this.TextBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(267, 33);
            this.TextBox_ID.TabIndex = 0;
            this.TextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ID_KeyPress);
            // 
            // LoginPicBox
            // 
            this.LoginPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicBox.Image = global::Final_Project.Properties.Resources.Btn1_2;
            this.LoginPicBox.Location = new System.Drawing.Point(576, 379);
            this.LoginPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPicBox.Name = "LoginPicBox";
            this.LoginPicBox.Size = new System.Drawing.Size(111, 49);
            this.LoginPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoginPicBox.TabIndex = 1;
            this.LoginPicBox.TabStop = false;
            this.LoginPicBox.Click += new System.EventHandler(this.LoginPicBox_Click);
            this.LoginPicBox.MouseEnter += new System.EventHandler(this.LoginPicBox_MouseEnter);
            this.LoginPicBox.MouseLeave += new System.EventHandler(this.LoginPicBox_MouseLeave);
            // 
            // DevLoginBtn
            // 
            this.DevLoginBtn.Location = new System.Drawing.Point(790, 283);
            this.DevLoginBtn.Name = "DevLoginBtn";
            this.DevLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.DevLoginBtn.TabIndex = 3;
            this.DevLoginBtn.Text = "MainMenu";
            this.DevLoginBtn.UseVisualStyleBackColor = true;
            this.DevLoginBtn.Visible = false;
            this.DevLoginBtn.Click += new System.EventHandler(this.DevLoginBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(580, 283);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserBtn.TabIndex = 5;
            this.DeleteUserBtn.Text = "DeleteUser";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Visible = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResetAvatarBtn
            // 
            this.ResetAvatarBtn.Location = new System.Drawing.Point(790, 322);
            this.ResetAvatarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetAvatarBtn.Name = "ResetAvatarBtn";
            this.ResetAvatarBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetAvatarBtn.TabIndex = 9;
            this.ResetAvatarBtn.Text = "Reset Avatar";
            this.ResetAvatarBtn.UseVisualStyleBackColor = true;
            this.ResetAvatarBtn.Visible = false;
            this.ResetAvatarBtn.Click += new System.EventHandler(this.ResetAvatarBtn_Click);
            // 
            // UsersAdapter
            // 
            this.UsersAdapter.ClearBeforeFill = true;
            // 
            // DevNewUserBtn
            // 
            this.DevNewUserBtn.Location = new System.Drawing.Point(790, 363);
            this.DevNewUserBtn.Name = "DevNewUserBtn";
            this.DevNewUserBtn.Size = new System.Drawing.Size(75, 23);
            this.DevNewUserBtn.TabIndex = 3;
            this.DevNewUserBtn.Text = "NewUser";
            this.DevNewUserBtn.UseVisualStyleBackColor = true;
            this.DevNewUserBtn.Visible = false;
            this.DevNewUserBtn.Click += new System.EventHandler(this.DevNewUserBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(790, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.Visible = false;
            // 
            // DevLoginAsBtn
            // 
            this.DevLoginAsBtn.Location = new System.Drawing.Point(499, 283);
            this.DevLoginAsBtn.Name = "DevLoginAsBtn";
            this.DevLoginAsBtn.Size = new System.Drawing.Size(75, 23);
            this.DevLoginAsBtn.TabIndex = 10;
            this.DevLoginAsBtn.Text = "Login As";
            this.DevLoginAsBtn.UseVisualStyleBackColor = true;
            this.DevLoginAsBtn.Visible = false;
            this.DevLoginAsBtn.Click += new System.EventHandler(this.DevLoginAsBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.BackGround_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.DevLoginAsBtn);
            this.Controls.Add(this.ResetAvatarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DevNewUserBtn);
            this.Controls.Add(this.DevLoginBtn);
            this.Controls.Add(this.LoginPicBox);
            this.Controls.Add(this.TextBox_ID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Connect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.PictureBox LoginPicBox;
        private System.Windows.Forms.Button DevLoginBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private MainDataSet db;
        private System.Windows.Forms.Button ResetAvatarBtn;
        private MainDataSetTableAdapters.UsersTableAdapter UsersAdapter;
        private System.Windows.Forms.Button DevNewUserBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DevLoginAsBtn;
    }
}

