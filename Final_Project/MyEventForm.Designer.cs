namespace Final_Project {
    partial class MyEventForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEventForm));
            this.db = new Final_Project.MainDataSet();
            this.ActivityAdapter = new Final_Project.MainDataSetTableAdapters.ActivitiesTableAdapter();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ShopLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.DiscussPicBox = new System.Windows.Forms.PictureBox();
            this.CancelPicBox = new System.Windows.Forms.PictureBox();
            this.TitlePicBox = new System.Windows.Forms.PictureBox();
            this.RightPicBox = new System.Windows.Forms.PictureBox();
            this.LeftPicBox = new System.Windows.Forms.PictureBox();
            this.EventPicBox = new System.Windows.Forms.PictureBox();
            this.DotsPicBox = new System.Windows.Forms.PictureBox();
            this.MarkPicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.UsersAdapter = new Final_Project.MainDataSetTableAdapters.UsersTableAdapter();
            this.UA_Adapter = new Final_Project.MainDataSetTableAdapters.User_ActivityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscussPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // db
            // 
            this.db.DataSetName = "MainDataSet";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityAdapter
            // 
            this.ActivityAdapter.ClearBeforeFill = true;
            // 
            // IndexLabel
            // 
            this.IndexLabel.BackColor = System.Drawing.Color.Transparent;
            this.IndexLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IndexLabel.Location = new System.Drawing.Point(774, 590);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(100, 32);
            this.IndexLabel.TabIndex = 56;
            this.IndexLabel.Text = "0/0";
            this.IndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CountLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountLabel.Location = new System.Drawing.Point(333, 451);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(133, 39);
            this.CountLabel.TabIndex = 49;
            this.CountLabel.Text = "PlaceHolder";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressLabel
            // 
            this.AddressLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddressLabel.Location = new System.Drawing.Point(257, 382);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(209, 67);
            this.AddressLabel.TabIndex = 50;
            this.AddressLabel.Text = "PlaceHolder";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShopLabel
            // 
            this.ShopLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShopLabel.Location = new System.Drawing.Point(257, 338);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(209, 47);
            this.ShopLabel.TabIndex = 51;
            this.ShopLabel.Text = "PlaceHolder";
            this.ShopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeLabel.Location = new System.Drawing.Point(256, 280);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(209, 42);
            this.TimeLabel.TabIndex = 52;
            this.TimeLabel.Text = "PlaceHolder";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DateLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateLabel.Location = new System.Drawing.Point(257, 223);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(209, 40);
            this.DateLabel.TabIndex = 53;
            this.DateLabel.Text = "PlaceHolder";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntroLabel
            // 
            this.IntroLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntroLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.IntroLabel.Location = new System.Drawing.Point(546, 258);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(293, 253);
            this.IntroLabel.TabIndex = 54;
            this.IntroLabel.Text = "PlaceHolder";
            // 
            // DiscussPicBox
            // 
            this.DiscussPicBox.BackColor = System.Drawing.Color.Transparent;
            this.DiscussPicBox.Image = global::Final_Project.Properties.Resources.討論版Btn;
            this.DiscussPicBox.Location = new System.Drawing.Point(930, 295);
            this.DiscussPicBox.Name = "DiscussPicBox";
            this.DiscussPicBox.Size = new System.Drawing.Size(240, 63);
            this.DiscussPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiscussPicBox.TabIndex = 58;
            this.DiscussPicBox.TabStop = false;
            this.DiscussPicBox.Click += new System.EventHandler(this.PicBox_Click);
            this.DiscussPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.DiscussPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // CancelPicBox
            // 
            this.CancelPicBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelPicBox.Image = global::Final_Project.Properties.Resources.取消報名Btn;
            this.CancelPicBox.Location = new System.Drawing.Point(930, 417);
            this.CancelPicBox.Name = "CancelPicBox";
            this.CancelPicBox.Size = new System.Drawing.Size(240, 63);
            this.CancelPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CancelPicBox.TabIndex = 57;
            this.CancelPicBox.TabStop = false;
            this.CancelPicBox.Click += new System.EventHandler(this.PicBox_Click);
            this.CancelPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.CancelPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // TitlePicBox
            // 
            this.TitlePicBox.BackColor = System.Drawing.Color.Transparent;
            this.TitlePicBox.Image = global::Final_Project.Properties.Resources.標題label;
            this.TitlePicBox.Location = new System.Drawing.Point(110, 113);
            this.TitlePicBox.Name = "TitlePicBox";
            this.TitlePicBox.Size = new System.Drawing.Size(273, 68);
            this.TitlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitlePicBox.TabIndex = 55;
            this.TitlePicBox.TabStop = false;
            // 
            // RightPicBox
            // 
            this.RightPicBox.Image = global::Final_Project.Properties.Resources.RightBtn;
            this.RightPicBox.Location = new System.Drawing.Point(565, 590);
            this.RightPicBox.Name = "RightPicBox";
            this.RightPicBox.Size = new System.Drawing.Size(37, 53);
            this.RightPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RightPicBox.TabIndex = 47;
            this.RightPicBox.TabStop = false;
            this.RightPicBox.Click += new System.EventHandler(this.ArrowPicBox_Click);
            this.RightPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.RightPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // LeftPicBox
            // 
            this.LeftPicBox.Image = global::Final_Project.Properties.Resources.LeftBtn;
            this.LeftPicBox.Location = new System.Drawing.Point(380, 590);
            this.LeftPicBox.Name = "LeftPicBox";
            this.LeftPicBox.Size = new System.Drawing.Size(37, 53);
            this.LeftPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LeftPicBox.TabIndex = 46;
            this.LeftPicBox.TabStop = false;
            this.LeftPicBox.Click += new System.EventHandler(this.ArrowPicBox_Click);
            this.LeftPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.LeftPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // EventPicBox
            // 
            this.EventPicBox.Image = global::Final_Project.Properties.Resources.EventInfoBackground;
            this.EventPicBox.Location = new System.Drawing.Point(110, 199);
            this.EventPicBox.Name = "EventPicBox";
            this.EventPicBox.Size = new System.Drawing.Size(764, 385);
            this.EventPicBox.TabIndex = 45;
            this.EventPicBox.TabStop = false;
            // 
            // DotsPicBox
            // 
            this.DotsPicBox.BackColor = System.Drawing.Color.Transparent;
            this.DotsPicBox.Image = global::Final_Project.Properties.Resources.ellipsis_1;
            this.DotsPicBox.Location = new System.Drawing.Point(451, 574);
            this.DotsPicBox.Name = "DotsPicBox";
            this.DotsPicBox.Size = new System.Drawing.Size(80, 80);
            this.DotsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DotsPicBox.TabIndex = 48;
            this.DotsPicBox.TabStop = false;
            // 
            // MarkPicBox
            // 
            this.MarkPicBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkPicBox.Image = global::Final_Project.Properties.Resources.mark;
            this.MarkPicBox.Location = new System.Drawing.Point(485, 674);
            this.MarkPicBox.Name = "MarkPicBox";
            this.MarkPicBox.Size = new System.Drawing.Size(330, 45);
            this.MarkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarkPicBox.TabIndex = 42;
            this.MarkPicBox.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Final_Project.Properties.Resources.mainLabel;
            this.LogoPicBox.Location = new System.Drawing.Point(0, -6);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(345, 100);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 4;
            this.LogoPicBox.TabStop = false;
            // 
            // UsersAdapter
            // 
            this.UsersAdapter.ClearBeforeFill = true;
            // 
            // UA_Adapter
            // 
            this.UA_Adapter.ClearBeforeFill = true;
            // 
            // MyEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.DiscussPicBox);
            this.Controls.Add(this.CancelPicBox);
            this.Controls.Add(this.TitlePicBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ShopLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.RightPicBox);
            this.Controls.Add(this.LeftPicBox);
            this.Controls.Add(this.EventPicBox);
            this.Controls.Add(this.DotsPicBox);
            this.Controls.Add(this.MarkPicBox);
            this.Controls.Add(this.LogoPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Events";
            this.Load += new System.EventHandler(this.MyEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscussPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDataSet db;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.PictureBox MarkPicBox;
        private MainDataSetTableAdapters.ActivitiesTableAdapter ActivityAdapter;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.PictureBox DiscussPicBox;
        private System.Windows.Forms.PictureBox CancelPicBox;
        private System.Windows.Forms.PictureBox TitlePicBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ShopLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.PictureBox RightPicBox;
        private System.Windows.Forms.PictureBox LeftPicBox;
        private System.Windows.Forms.PictureBox EventPicBox;
        private System.Windows.Forms.PictureBox DotsPicBox;
        private MainDataSetTableAdapters.UsersTableAdapter UsersAdapter;
        private MainDataSetTableAdapters.User_ActivityTableAdapter UA_Adapter;
    }
}