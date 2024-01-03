namespace Final_Project {
    partial class ChatChunk {
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
            this.TextsLabel = new System.Windows.Forms.Label();
            this.db = new Final_Project.MainDataSet();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TimeTitleLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TextsLabel
            // 
            this.TextsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextsLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextsLabel.Location = new System.Drawing.Point(24, 114);
            this.TextsLabel.Name = "TextsLabel";
            this.TextsLabel.Size = new System.Drawing.Size(799, 126);
            this.TextsLabel.TabIndex = 2;
            this.TextsLabel.Text = "PlaceHolder";
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.Avatar.Location = new System.Drawing.Point(27, 12);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(60, 60);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(95, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(125, 45);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "張亨利";
            // 
            // TimeTitleLabel
            // 
            this.TimeTitleLabel.AutoSize = true;
            this.TimeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeTitleLabel.Location = new System.Drawing.Point(294, 26);
            this.TimeTitleLabel.Name = "TimeTitleLabel";
            this.TimeTitleLabel.Size = new System.Drawing.Size(140, 37);
            this.TimeTitleLabel.TabIndex = 3;
            this.TimeTitleLabel.Text = "發佈時間:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeLabel.Location = new System.Drawing.Point(438, 26);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(387, 37);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "2023年12月29日 下午 09:15";
            // 
            // ChatChunk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Final_Project.Properties.Resources.ChunkBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTitleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TextsLabel);
            this.Controls.Add(this.Avatar);
            this.DoubleBuffered = true;
            this.Name = "ChatChunk";
            this.Size = new System.Drawing.Size(842, 258);
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label TextsLabel;
        private MainDataSet db;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TimeTitleLabel;
        private System.Windows.Forms.Label TimeLabel;
    }
}
