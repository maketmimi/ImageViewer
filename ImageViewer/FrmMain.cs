using ImageViewer.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FrmMain : Form
    {
        private bool _IsInvalidImage = false;
        private string _InitialImagePath = null;

        public FrmMain(string InitialImagePath = null)
        {
            InitializeComponent();
            // supported image format for Image.FromFile() method
            OpfdBrowseImage.Filter =
                "All Supported Images|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.png;*.gif;*.tif;*.tiff;*.ico|" +
                "Bitmap (*.bmp;*.dib)|*.bmp;*.dib|" +
                "JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|" +
                "PNG (*.png)|*.png|" +
                "GIF (*.gif)|*.gif|" +
                "TIFF (*.tif;*.tiff)|*.tif;*.tiff|" +
                "Icon (*.ico)|*.ico";

            _InitialImagePath = InitialImagePath;
        }

        private bool TryDisplayImage(string ImagePath)
        {
            try
            {
                PbMainDisplay.Image = Image.FromFile(ImagePath);
                this.Text = "Image Viewer - " + Path.GetFileName(ImagePath);
                _IsInvalidImage = false;
            }
            catch
            {
                _IsInvalidImage = true;
                PbMainDisplay.Image = Resources.ImageInavlidErrorSmall;
                this.Text = "Image Viewer - Invalid Image!";
            }

            RecalculateImageSizeAndSizeMode();

            if (_IsInvalidImage)
                MessageBox.Show("Hmm... this seems like an invalid image!", "Image Viewer - Cannot display image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return !_IsInvalidImage;
        }

        private void BtnBrowseImage_Click(object sender, System.EventArgs e)
        {
            OpfdBrowseImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (OpfdBrowseImage.ShowDialog() == DialogResult.OK)
            {
                TryDisplayImage(OpfdBrowseImage.FileName);
            }
        }

        private void RotateImage(RotateFlipType RotateType)
        {
            if (PbMainDisplay.Image != null && !_IsInvalidImage)
            {
                PbMainDisplay.Image.RotateFlip(RotateType);
                PbMainDisplay.Invalidate();
            }
        }

        private void BtnRotateRight_Click(object sender, EventArgs e)
        {
            RotateImage(RotateFlipType.Rotate90FlipNone);
        }

        private void BtnRotateLeft_Click(object sender, EventArgs e)
        {
            RotateImage(RotateFlipType.Rotate270FlipNone);
        }

        private void RecalculateImageSizeAndSizeMode()
        {
            if (PbMainDisplay.Image == null) return;

            if (PbMainDisplay.Size.Height > PbMainDisplay.Image.Size.Height && PbMainDisplay.Size.Width > PbMainDisplay.Image.Size.Width)
                PbMainDisplay.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                PbMainDisplay.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PbMainDisplay_SizeChanged(object sender, EventArgs e)
        {
            RecalculateImageSizeAndSizeMode();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (_InitialImagePath != null)
            {
                if (!TryDisplayImage(_InitialImagePath))
                    Application.Exit();
                _InitialImagePath = null;
            }
        }
    }
}
