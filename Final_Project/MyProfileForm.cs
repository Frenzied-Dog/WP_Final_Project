using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class MyProfileForm : Form {
        string[] budgets = { "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        bool modifying = false;
        PictureBox[] EditPicBoxs;

        // https://stackoverflow.com/a/24199315
        public static Bitmap Resize_img(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes()) { 
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                };
            }
            return destImage;
        }

        public MyProfileForm(Final_ProjectDataSet db) {
            InitializeComponent();
            this.db = db;

            //將 Profile Photo 變成圓形框  https://www.jb51.net/article/220686.htm
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ProfilePhoto.ClientRectangle);
            BudgetComboBox.DataSource = budgets;
            PreferTimeComboBox.DataSource = times;

            ProfilePhoto.Region = new Region(gp);
            EditPicBoxs = new PictureBox[] { EditPicBox1, EditPicBox2, EditPicBox3, EditPicBox4, EditPicBox5 };

            ID_Label.Text = db.Me[0].Id;
            NickNameLabel.Text = db.Me[0].NickName;
            MajorTextBox.Text = db.Me[0]["Major"] != DBNull.Value ? db.Me[0].Major : "";
            GenderTextBox.Text = db.Me[0]["Gender"] != DBNull.Value ? db.Me[0].Gender : "";
            SelfTextBox.Text = db.Me[0]["AboutMe"] != DBNull.Value ? db.Me[0].AboutMe : "";
            BudgetComboBox.SelectedIndex = db.Me[0].Budget;
            PreferTimeComboBox.SelectedIndex = db.Me[0].PreferTime;
            ProfilePhoto.Image = Image.FromStream(new MemoryStream(db.Me[0].Pic));
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void ModifyPicBox_Click(object sender, EventArgs e) {
            modifying = !modifying;
            if (modifying) {
                MajorTextBox.ReadOnly = false;
                GenderTextBox.ReadOnly = false;
                SelfTextBox.ReadOnly = false;
                BudgetComboBox.Enabled = true;
                PreferTimeComboBox.Enabled = true;
                ModifyPicBox.Image = Properties.Resources.儲存更動Btn_2;
                ReUploadPicBox.Visible = true;
                NickTextBox.Text = NickNameLabel.Text;
                NickTextBox.Visible = true;
                foreach (PictureBox picBox in EditPicBoxs) picBox.Visible = true;
            } else {
                MajorTextBox.ReadOnly = true;
                GenderTextBox.ReadOnly = true;
                SelfTextBox.ReadOnly = true;
                BudgetComboBox.Enabled = false;
                PreferTimeComboBox.Enabled = false;
                ModifyPicBox.Image = Properties.Resources.編輯資料Btn_2;
                ReUploadPicBox.Visible = false;
                NickNameLabel.Text = NickTextBox.Text;
                NickTextBox.Visible = false;
                foreach (PictureBox picBox in EditPicBoxs) picBox.Visible = false;
                
                db.Me[0].NickName = NickNameLabel.Text;
                db.Me[0].Major = MajorTextBox.Text;
                db.Me[0].Gender = GenderTextBox.Text;
                db.Me[0].Budget = BudgetComboBox.SelectedIndex;
                db.Me[0].PreferTime = PreferTimeComboBox.SelectedIndex;
                db.Me[0].AboutMe = SelfTextBox.Text;
                using (MemoryStream mStream = new MemoryStream()) {
                    ProfilePhoto.Image.Save(mStream, ImageFormat.Bmp);
                    db.Me[0].Pic = mStream.ToArray();
                };
                MeAdapter.Update(db.Me);
            }
        }

        private void PicBox_MouseEnter(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Modify":
                if (modifying) picBox.Image = Properties.Resources.儲存更動Btn_2;
                else picBox.Image = Properties.Resources.編輯資料Btn_2;
                break;
            case "ReUpload":
                picBox.Image = Properties.Resources.ReUpload_2;
                break;
            default:
                break;
            }
        }

        private void PicBox_MouseLeave(object sender, EventArgs e) {
            PictureBox picBox = (PictureBox)sender;
            switch (picBox.Name.Substring(0, picBox.Name.Length - 6)) {
            case "Modify":
                if (modifying)  picBox.Image = Properties.Resources.儲存更動Btn;
                else picBox.Image = Properties.Resources.編輯資料Btn;
                break;
            case "ReUpload":
                picBox.Image = Properties.Resources.ReUpload;
                break;
            default:
                break;
            }
        }

        private void ReUploadPicBox_Click(object sender, EventArgs e) {
            using (OpenFileDialog OFD = new OpenFileDialog()) {
                OFD.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有檔案 (*.*)|*.*";
                OFD.Title = "選擇圖片";
                OFD.Multiselect = false;
                OFD.InitialDirectory = ".";

                if (OFD.ShowDialog() == DialogResult.OK) {
                    string path = OFD.FileName;
                    ProfilePhoto.Image = Resize_img(Image.FromFile(path), 220, 220);
                }            
            };
        }
    }
}
