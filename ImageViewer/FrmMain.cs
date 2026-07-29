using ImageViewer.Properties;
using System;
using System.Drawing;
using System.IO;
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

            InitializeRotateAndFlipMenuItemsTags();

            _InitialImagePath = InitialImagePath;
        }

        private void InitializeRotateAndFlipMenuItemsTags()
        {
            Rotate90degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate90FlipNone;
            Rotate180degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate180FlipNone;
            Rotate270degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate270FlipNone;

            flipHorizentolToolStripMenuItem.Tag = RotateFlipType.RotateNoneFlipX;
            flipVerticalToolStripMenuItem.Tag = RotateFlipType.RotateNoneFlipY;
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

        private string GetPicturesFolderPath()
        {
            return String.IsNullOrWhiteSpace(Settings.Default.PicturesFolderPath) || !Directory.Exists(Settings.Default.PicturesFolderPath) ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) : Settings.Default.PicturesFolderPath;
        }

        private void RotateImage(RotateFlipType RotateType)
        {
            if (PbMainDisplay.Image != null && !_IsInvalidImage)
            {
                PbMainDisplay.Image.RotateFlip(RotateType);
                RecalculateImageSizeAndSizeMode();
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

        private void OpenPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpfdBrowseImage.InitialDirectory = GetPicturesFolderPath();

            if (OpfdBrowseImage.ShowDialog() == DialogResult.OK)
            {
                TryDisplayImage(OpfdBrowseImage.FileName);
            }
        }

        private void RotateFlipImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateImage((RotateFlipType)(((ToolStripMenuItem)sender).Tag));
        }

        private void ChangePicturesFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FbdPicturesFolder.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.PicturesFolderPath = FbdPicturesFolder.SelectedPath;
                Settings.Default.Save();
            }
        }
    }
}
