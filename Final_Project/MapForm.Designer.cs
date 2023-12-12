namespace Final_Project {
    partial class MapForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.Map = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ResetPicBox = new System.Windows.Forms.PictureBox();
            this.ConfirmPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.AllowExternalDrop = true;
            this.Map.CreationProperties = null;
            this.Map.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Map.Location = new System.Drawing.Point(12, 12);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1060, 567);
            this.Map.Source = new System.Uri("https://www.google.com.tw/maps", System.UriKind.Absolute);
            this.Map.TabIndex = 0;
            this.Map.ZoomFactor = 1D;
            this.Map.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.Map_NavigationCompleted);
            // 
            // ResetPicBox
            // 
            this.ResetPicBox.Image = global::Final_Project.Properties.Resources.重設地圖Btn;
            this.ResetPicBox.Location = new System.Drawing.Point(12, 585);
            this.ResetPicBox.Name = "ResetPicBox";
            this.ResetPicBox.Size = new System.Drawing.Size(155, 70);
            this.ResetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ResetPicBox.TabIndex = 2;
            this.ResetPicBox.TabStop = false;
            this.ResetPicBox.Click += new System.EventHandler(this.ResetPicBox_Click);
            this.ResetPicBox.MouseEnter += new System.EventHandler(this.PicBox_Enter);
            this.ResetPicBox.MouseLeave += new System.EventHandler(this.PicBox_Leave);
            // 
            // ConfirmPicBox
            // 
            this.ConfirmPicBox.Image = global::Final_Project.Properties.Resources.地點確認Btn;
            this.ConfirmPicBox.Location = new System.Drawing.Point(917, 585);
            this.ConfirmPicBox.Name = "ConfirmPicBox";
            this.ConfirmPicBox.Size = new System.Drawing.Size(155, 70);
            this.ConfirmPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ConfirmPicBox.TabIndex = 1;
            this.ConfirmPicBox.TabStop = false;
            this.ConfirmPicBox.Click += new System.EventHandler(this.ConfirmPicBox_Click);
            this.ConfirmPicBox.MouseEnter += new System.EventHandler(this.PicBox_Enter);
            this.ConfirmPicBox.MouseLeave += new System.EventHandler(this.PicBox_Leave);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.ResetPicBox);
            this.Controls.Add(this.ConfirmPicBox);
            this.Controls.Add(this.Map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MapForm";
            this.Text = "Maps";
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Map;
        private System.Windows.Forms.PictureBox ConfirmPicBox;
        private System.Windows.Forms.PictureBox ResetPicBox;
    }
}