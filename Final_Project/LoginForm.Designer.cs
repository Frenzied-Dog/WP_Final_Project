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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ID.Location = new System.Drawing.Point(499, 300);
            this.TextBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(267, 33);
            this.TextBox_ID.TabIndex = 0;
            this.TextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPicBox
            // 
            this.LoginPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicBox.Image = global::Final_Project.Properties.Resources.Btn1_2;
            this.LoginPicBox.Location = new System.Drawing.Point(561, 359);
            this.LoginPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPicBox.Name = "LoginPicBox";
            this.LoginPicBox.Size = new System.Drawing.Size(143, 58);
            this.LoginPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoginPicBox.TabIndex = 1;
            this.LoginPicBox.TabStop = false;
            this.LoginPicBox.Click += new System.EventHandler(this.LoginPicBox_Click);
            this.LoginPicBox.MouseEnter += new System.EventHandler(this.LoginPicBox_MouseEnter);
            this.LoginPicBox.MouseLeave += new System.EventHandler(this.LoginPicBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dev Branch";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Final_Project.Properties.Resources.BackGround_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.PictureBox LoginPicBox;
        private System.Windows.Forms.Label label1;
    }
}

