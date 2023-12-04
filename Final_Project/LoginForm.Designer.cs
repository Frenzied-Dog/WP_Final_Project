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
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ID.Location = new System.Drawing.Point(498, 315);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(266, 33);
            this.TextBox_ID.TabIndex = 0;
            this.TextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPicBox
            // 
            this.LoginPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicBox.Image = global::Final_Project.Properties.Resources.Btn1_2;
            this.LoginPicBox.Location = new System.Drawing.Point(579, 382);
            this.LoginPicBox.Name = "LoginPicBox";
            this.LoginPicBox.Size = new System.Drawing.Size(107, 46);
            this.LoginPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoginPicBox.TabIndex = 1;
            this.LoginPicBox.TabStop = false;
            this.LoginPicBox.Click += new System.EventHandler(this.LoginPicBox_Click);
            this.LoginPicBox.MouseEnter += new System.EventHandler(this.LoginPicBox_MouseEnter);
            this.LoginPicBox.MouseLeave += new System.EventHandler(this.LoginPicBox_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.BackGround_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.LoginPicBox);
            this.Controls.Add(this.TextBox_ID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Connect";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.PictureBox LoginPicBox;
    }
}

