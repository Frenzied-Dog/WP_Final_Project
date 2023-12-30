using Microsoft.IdentityModel.Tokens;
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
        string[] budgets = { "", "50~100", "100~200", "200~300", "300~400", "400以上" };
        string[] times = { "", "早上", "中午", "下午", "晚上", "半夜", "凌晨" };
        bool modifying = false;
        MainDataSet.UsersRow me;
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

        public MyProfileForm(MainDataSet db, string UID) {
            InitializeComponent();
            this.db = db;
            //將 Profile Photo 變成圓形框  https://www.jb51.net/article/220686.htm
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ProfilePhoto.ClientRectangle);
            ProfilePhoto.Region = new Region(gp);

            BudgetComboBox.DataSource = budgets;
            PreferTimeComboBox.DataSource = times;
            EditPicBoxs = new PictureBox[] { EditPicBox1, EditPicBox2, EditPicBox3, EditPicBox4, EditPicBox5 };

            me = UsersAdapter.GetDataByID(UID)[0];

            ID_Label.DataBindings.Add("Text", me, "ID", false, DataSourceUpdateMode.OnPropertyChanged);
            NickNameLabel.DataBindings.Add("Text", me, "NickName", false, DataSourceUpdateMode.OnPropertyChanged);
            NickTextBox.DataBindings.Add("Text", me, "NickName", false, DataSourceUpdateMode.OnPropertyChanged);
            MajorTextBox.DataBindings.Add("Text", me, "Major", false, DataSourceUpdateMode.OnPropertyChanged);
            GenderTextBox.DataBindings.Add("Text", me, "Gender", false, DataSourceUpdateMode.OnPropertyChanged);
            SelfTextBox.DataBindings.Add("Text", me, "AboutMe", false, DataSourceUpdateMode.OnPropertyChanged);
            BudgetComboBox.DataBindings.Add("SelectedIndex", me, "Budget", false, DataSourceUpdateMode.OnPropertyChanged);
            PreferTimeComboBox.DataBindings.Add("SelectedIndex", me, "PreferTime", false, DataSourceUpdateMode.OnPropertyChanged);
            //ProfilePhoto.DataBindings.Add("Image", me, "Pic", true, DataSourceUpdateMode.OnPropertyChanged);

            //ID_Label.Text = me.ID;
            //NickTextBox.Text = me.NickName;
            //MajorTextBox.Text = me["Major"] != DBNull.Value ? me.Major : "";
            //GenderTextBox.Text = me["Gender"] != DBNull.Value ? me.Gender : "";
            //SelfTextBox.Text = me.AboutMe;
            //BudgetComboBox.SelectedIndex = me.Budget;
            //PreferTimeComboBox.SelectedIndex = me.PreferTime;
            ProfilePhoto.Image = Image.FromStream(new MemoryStream(me.Pic));
            //ProfilePhoto.Image = (Image)new ImageConverter().ConvertFrom(db.Me[0].Pic);
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void ModifyPicBox_Click(object sender, EventArgs e) {
            if (!modifying) {
                MajorTextBox.ReadOnly = false;
                GenderTextBox.ReadOnly = false;
                SelfTextBox.ReadOnly = false;
                BudgetComboBox.Enabled = true;
                BudgetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                PreferTimeComboBox.Enabled = true;
                PreferTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                ModifyPicBox.Image = Properties.Resources.儲存更動Btn_2;
                ReUploadPicBox.Visible = true;
                //NickTextBox.Text = NickNameLabel.Text;
                NickTextBox.Visible = true;
                foreach (PictureBox picBox in EditPicBoxs) picBox.Visible = true;
                modifying = true;
            } else {
                if (string.IsNullOrWhiteSpace(MajorTextBox.Text)) {
                    MessageBox.Show("請輸入系級!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrWhiteSpace(NickTextBox.Text))
                    NickTextBox.Text = me.Name;
                if (string.IsNullOrWhiteSpace(SelfTextBox.Text))
                    SelfTextBox.Text = "這傢伙人狠話不多...啥都沒留:(";

                MajorTextBox.ReadOnly = true;
                GenderTextBox.ReadOnly = true;
                SelfTextBox.ReadOnly = true;
                BudgetComboBox.Enabled = false;
                BudgetComboBox.DropDownStyle = ComboBoxStyle.Simple;
                PreferTimeComboBox.Enabled = false;
                PreferTimeComboBox.DropDownStyle = ComboBoxStyle.Simple;
                ReUploadPicBox.Visible = false;
                //NickNameLabel.Text = NickTextBox.Text;
                NickTextBox.Visible = false;
                foreach (PictureBox picBox in EditPicBoxs) picBox.Visible = false;
                ModifyPicBox.Image = Properties.Resources.編輯資料Btn_2;

                //me.NickName = NickNameLabel.Text;
                //me.Major = MajorTextBox.Text;
                //me.Gender = GenderTextBox.Text;
                //me.Budget = BudgetComboBox.SelectedIndex;
                //me.PreferTime = PreferTimeComboBox.SelectedIndex;
                //me.AboutMe = SelfTextBox.Text;
                using (MemoryStream mStream = new MemoryStream()) {
                    ProfilePhoto.Image.Save(mStream, ImageFormat.Bmp);
                    me.Pic = mStream.ToArray();
                };
                UsersAdapter.Update(me);
                modifying = false;
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
