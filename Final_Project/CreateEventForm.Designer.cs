namespace Final_Project {
    partial class CreateEventForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEventForm));
            this.CreatePicBox = new System.Windows.Forms.PictureBox();
            this.UseMapPicBox = new System.Windows.Forms.PictureBox();
            this.BudgetComboBox = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.IntroTextBox = new System.Windows.Forms.TextBox();
            this.ShopTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.db = new Final_Project.MainDataSet();
            this.ActivityAdapter = new Final_Project.MainDataSetTableAdapters.ActivitiesTableAdapter();
            this.User_ActivityAdapter = new Final_Project.MainDataSetTableAdapters.User_ActivityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseMapPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePicBox
            // 
            this.CreatePicBox.BackColor = System.Drawing.Color.Transparent;
            this.CreatePicBox.Image = global::Final_Project.Properties.Resources.發布活動btn;
            this.CreatePicBox.Location = new System.Drawing.Point(929, 575);
            this.CreatePicBox.Name = "CreatePicBox";
            this.CreatePicBox.Size = new System.Drawing.Size(204, 70);
            this.CreatePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CreatePicBox.TabIndex = 0;
            this.CreatePicBox.TabStop = false;
            this.CreatePicBox.Click += new System.EventHandler(this.CreatePicBox_Click);
            this.CreatePicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.CreatePicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // UseMapPicBox
            // 
            this.UseMapPicBox.BackColor = System.Drawing.Color.Transparent;
            this.UseMapPicBox.Image = global::Final_Project.Properties.Resources.使用地圖Btn;
            this.UseMapPicBox.Location = new System.Drawing.Point(678, 457);
            this.UseMapPicBox.Name = "UseMapPicBox";
            this.UseMapPicBox.Size = new System.Drawing.Size(455, 74);
            this.UseMapPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UseMapPicBox.TabIndex = 1;
            this.UseMapPicBox.TabStop = false;
            this.UseMapPicBox.Click += new System.EventHandler(this.UseMapPicBox_Click);
            this.UseMapPicBox.MouseEnter += new System.EventHandler(this.PicBox_MouseEnter);
            this.UseMapPicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            // 
            // BudgetComboBox
            // 
            this.BudgetComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BudgetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BudgetComboBox.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.BudgetComboBox.FormattingEnabled = true;
            this.BudgetComboBox.Location = new System.Drawing.Point(856, 267);
            this.BudgetComboBox.Name = "BudgetComboBox";
            this.BudgetComboBox.Size = new System.Drawing.Size(268, 30);
            this.BudgetComboBox.TabIndex = 2;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.DatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatePicker.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(312, 264);
            this.DatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShowUpDown = true;
            this.DatePicker.Size = new System.Drawing.Size(268, 30);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.Value = new System.DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // IntroTextBox
            // 
            this.IntroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IntroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntroTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroTextBox.Location = new System.Drawing.Point(312, 389);
            this.IntroTextBox.Multiline = true;
            this.IntroTextBox.Name = "IntroTextBox";
            this.IntroTextBox.Size = new System.Drawing.Size(268, 181);
            this.IntroTextBox.TabIndex = 5;
            // 
            // ShopTextBox
            // 
            this.ShopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ShopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShopTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.ShopTextBox.Location = new System.Drawing.Point(856, 327);
            this.ShopTextBox.Name = "ShopTextBox";
            this.ShopTextBox.Size = new System.Drawing.Size(268, 29);
            this.ShopTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.AddressTextBox.Location = new System.Drawing.Point(856, 389);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(268, 29);
            this.AddressTextBox.TabIndex = 7;
            // 
            // TimePicker
            // 
            this.TimePicker.CalendarFont = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.TimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimePicker.CustomFormat = "tt hh:mm";
            this.TimePicker.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(312, 326);
            this.TimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(268, 30);
            this.TimePicker.TabIndex = 8;
            this.TimePicker.Value = new System.DateTime(2023, 12, 21, 0, 0, 0, 0);
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
            // User_ActivityAdapter
            // 
            this.User_ActivityAdapter.ClearBeforeFill = true;
            // 
            // CreateEventForm
            // 
            this.BackgroundImage = global::Final_Project.Properties.Resources.CreateEventBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ShopTextBox);
            this.Controls.Add(this.IntroTextBox);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.BudgetComboBox);
            this.Controls.Add(this.UseMapPicBox);
            this.Controls.Add(this.CreatePicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Event";
            ((System.ComponentModel.ISupportInitialize)(this.CreatePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseMapPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet db;
        private System.Windows.Forms.PictureBox CreatePicBox;
        private System.Windows.Forms.PictureBox UseMapPicBox;
        private System.Windows.Forms.ComboBox BudgetComboBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox IntroTextBox;
        private System.Windows.Forms.TextBox ShopTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private MainDataSetTableAdapters.ActivitiesTableAdapter ActivityAdapter;
        private MainDataSetTableAdapters.User_ActivityTableAdapter User_ActivityAdapter;
        private System.Windows.Forms.DateTimePicker TimePicker;
    }
}
