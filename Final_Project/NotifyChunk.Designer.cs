namespace Final_Project {
    partial class NotifyChunk {
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.TitlePicBox = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ConfirmPicBox = new System.Windows.Forms.PictureBox();
            this.UsersAdapter = new Final_Project.MainDataSetTableAdapters.UsersTableAdapter();
            this.UA_Adapter = new Final_Project.MainDataSetTableAdapters.User_ActivityTableAdapter();
            this.db = new Final_Project.MainDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePicBox
            // 
            this.TitlePicBox.BackColor = System.Drawing.Color.Transparent;
            this.TitlePicBox.Image = global::Final_Project.Properties.Resources.活動提醒;
            this.TitlePicBox.Location = new System.Drawing.Point(21, 17);
            this.TitlePicBox.Name = "TitlePicBox";
            this.TitlePicBox.Size = new System.Drawing.Size(145, 43);
            this.TitlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TitlePicBox.TabIndex = 0;
            this.TitlePicBox.TabStop = false;
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(41, 74);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(925, 93);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "張亨利您好，郭台銘在2023年11月30號12:00舉辦了活動，地點在成功燒臘。我們認為你會有興趣，點擊去看看吧！";
            // 
            // ConfirmPicBox
            // 
            this.ConfirmPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPicBox.Image = global::Final_Project.Properties.Resources.我知道了Btn;
            this.ConfirmPicBox.Location = new System.Drawing.Point(800, 134);
            this.ConfirmPicBox.Name = "ConfirmPicBox";
            this.ConfirmPicBox.Size = new System.Drawing.Size(150, 48);
            this.ConfirmPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ConfirmPicBox.TabIndex = 2;
            this.ConfirmPicBox.TabStop = false;
            this.ConfirmPicBox.Click += new System.EventHandler(this.ConfirmPicBox_Click);
            this.ConfirmPicBox.MouseEnter += new System.EventHandler(this.ConfirmPicBox_MouseEnter);
            this.ConfirmPicBox.MouseLeave += new System.EventHandler(this.ConfirmPicBox_MouseLeave);
            // 
            // UsersAdapter
            // 
            this.UsersAdapter.ClearBeforeFill = true;
            // 
            // UA_Adapter
            // 
            this.UA_Adapter.ClearBeforeFill = true;
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NotifyChunk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Final_Project.Properties.Resources.NotifyBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ConfirmPicBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.TitlePicBox);
            this.DoubleBuffered = true;
            this.Name = "NotifyChunk";
            this.Size = new System.Drawing.Size(990, 200);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TitlePicBox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.PictureBox ConfirmPicBox;
        private MainDataSetTableAdapters.UsersTableAdapter UsersAdapter;
        private MainDataSetTableAdapters.User_ActivityTableAdapter UA_Adapter;
        private MainDataSet db;
    }
}
