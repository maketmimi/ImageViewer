using ImageViewer.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IconParser.Core;

namespace ImageViewer
{
    public partial class FrmMain : Form
    {
        private bool _IsInvalidImage = false;
        private string _InitialImagePath = null;
        private string[] _CurrentDirectoryFilesPaths = null;
        private int _CurrentImageIndex;
        private readonly string[] AllSupportedImageTypes =
        {
            ".bmp",
            ".dib" ,
            ".jpg" ,
            ".jpeg" ,
            ".jpe" ,
            ".jfif" ,
            ".png" ,
            ".gif" ,
            ".tif" ,
            ".tiff" ,
            ".ico"
        };
        private readonly ToolStripMenuItem[] _SlideShowSpeedRadioButtons;

        private IcoParser _IcoImage = null;
        private bool _IsICOLoaded
        {
            get
            {
                return _IcoImage != null;
            }
        }

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

            _SlideShowSpeedRadioButtons = new ToolStripMenuItem[]
            {
                slideShowSpeedSlowToolStripMenuItem,
                slideShowSpeedMediumToolStripMenuItem,
                slideShowSpeedFastToolStripMenuItem
            };

            _InitialImagePath = InitialImagePath;
        }

        private void InitializeRotateAndFlipMenuItemsTags()
        {
            Rotate90degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate90FlipNone;
            Rotate180degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate180FlipNone;
            Rotate270degreesClockWiseToolStripMenuItem.Tag = RotateFlipType.Rotate270FlipNone;

            flipHorizentolToolStripMenuItem.Tag = RotateFlipType.RotateNoneFlipX;
            flipVerticalToolStripMenuItem.Tag = RotateFlipType.RotateNoneFlipY;
            
            CTsm90DegreesRotation.Tag = RotateFlipType.Rotate90FlipNone;
            CTsm180DegreesRotation.Tag = RotateFlipType.Rotate180FlipNone;
            CTsm270DegreesRotation.Tag = RotateFlipType.Rotate270FlipNone;

            CTsmFlipHorizontal.Tag = RotateFlipType.RotateNoneFlipX;
            CTsmFlipVertical.Tag = RotateFlipType.RotateNoneFlipY;
        }

        private void SetNavigationButtonsEnableState(bool Enabled)
        {
            BtnNextImage.Enabled = Enabled;
            BtnPreviousImage.Enabled = Enabled;
        }

        private bool OpenNewImage(string ImagePath)
        {
            if (TryDisplayImage(ImagePath))
            {
                _CurrentDirectoryFilesPaths = Directory.GetFiles(Path.GetDirectoryName(ImagePath));

                _CurrentImageIndex =
                    Array.IndexOf(_CurrentDirectoryFilesPaths, ImagePath);
                
                SetNavigationButtonsEnableState(true);
                return true;
            }
            else
            {
                SetNavigationButtonsEnableState(false);
                return false;
            }
        }

        private bool CheckIfValidImageType(string ImagePath)
        {
            return AllSupportedImageTypes.Contains(Path.GetExtension(ImagePath).ToLower());
        }

        private void ShowICOControlsIfNotVisible()
        {
            if (!PnlICOControls.Visible)
            {
                TblMain.RowCount++;
                PnlICOControls.Show();
            }
        }
        
        private void HideICOControlsIfVisible()
        {
            if (PnlICOControls.Visible)
            {
                PnlICOControls.Hide();
                TblMain.RowCount--;
            }
        } 

        private bool TryLoadICOImage(string ImagePath, out Image LoadedImage)
        {
            if (IcoParser.CheckIcoFileHeader(ImagePath))
            {
                try
                {
                    _IcoImage = new IcoParser(ImagePath);

                    UpdateLbIconImageCount();

                    if (_SlideShowState == SlideShowState.Stopped)
                        ShowICOControlsIfNotVisible();

                    LoadedImage = _IcoImage.GetNextImage();
                    return true;
                }
                catch
                {
                    LoadedImage = null;
                    return false;
                }
            }

            LoadedImage = null;
            return false;
        }

        private Image LoadImage(string ImagePath)
        {
            PbMainDisplay.Image?.Dispose();
            _IcoImage?.Dispose();
            _IcoImage = null;

            Image imageToReturn;

            if (TryLoadICOImage(ImagePath, out imageToReturn))
            {
                return imageToReturn;
            }
            
            try
            {
                return Image.FromFile(ImagePath);
            }
            catch
            {
                return null;
            }
        }

        private bool TryDisplayImage(string ImagePath)
        {
            Image LoadedImage = LoadImage(ImagePath);
            
            if (LoadedImage != null) // means the image loaded successfully
            {
                PbMainDisplay.Image = LoadedImage;
                this.Text = "Image Viewer - " + Path.GetFileName(ImagePath);
                _IsInvalidImage = false;
            }
            else
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

        private bool IsValidImageShown()
        {
            return PbMainDisplay.Image != null && !_IsInvalidImage;
        }

        private void RotateImage(RotateFlipType RotateType)
        {
            if (IsValidImageShown())
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
                if (!OpenNewImage(_InitialImagePath))
                    Application.Exit();
                _InitialImagePath = null;
            }
        }

        private void OpenPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpfdBrowseImage.InitialDirectory = GetPicturesFolderPath();

            if (OpfdBrowseImage.ShowDialog() == DialogResult.OK)
            {
                OpenNewImage(OpfdBrowseImage.FileName);
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

        private void CmImage_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CTsmRotateImage.Visible = IsValidImageShown();
            CTsmFlipImage.Visible = IsValidImageShown();
            CTRotateFlipSeperator.Visible = IsValidImageShown();
            CTCopyImageToolStripMenuItem.Enabled = IsValidImageShown();
        }

        private void DisplayNextImage()
        {
            do
            {
                if (_CurrentImageIndex == _CurrentDirectoryFilesPaths.Count() - 1)
                    _CurrentImageIndex = 0;
                else
                    _CurrentImageIndex++;
            }
            while (!CheckIfValidImageType(_CurrentDirectoryFilesPaths[_CurrentImageIndex]));

            TryDisplayImage(_CurrentDirectoryFilesPaths[_CurrentImageIndex]);
        }

        private void DisplayPreviousImage()
        {
            do
            {
                if (_CurrentImageIndex == 0)
                    _CurrentImageIndex = _CurrentDirectoryFilesPaths.Count() - 1;
                else
                    _CurrentImageIndex--;
            }
            while (!CheckIfValidImageType(_CurrentDirectoryFilesPaths[_CurrentImageIndex]));

            TryDisplayImage(_CurrentDirectoryFilesPaths[_CurrentImageIndex]);
        }

        private void NextImage_Click(object sender, EventArgs e)
        {
            DisplayNextImage();
        }

        private void PreviousImage_Click(object sender, EventArgs e)
        {
            DisplayPreviousImage();
        }

        private enum SlideShowState
        {
            Stopped,
            Running,
            Paused
        }

        private FormWindowState _WindowStateBeforeSlideShow;
        private SlideShowState _SlideShowState = SlideShowState.Stopped;

        private void ChangeFormBorderStyleForSlideShow()
        {
            _WindowStateBeforeSlideShow = this.WindowState;

            if (_WindowStateBeforeSlideShow == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal; // this fixes bug in the frame work that glitches full screen mode

            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowBottomBarIfNotVisible()
        {
            if (!PnlBottomBar.Visible)
            {
                TblMain.RowCount++;
                PnlBottomBar.Show();
            }
        }

        private void HideBottomBarIfVisible()
        {
            if (PnlBottomBar.Visible)
            {
                PnlBottomBar.Hide();
                TblMain.RowCount--;
            }
        }

        private void StartSlideShow()
        {
            if (!IsValidImageShown() || _SlideShowState != SlideShowState.Stopped) return;

            _SlideShowState = SlideShowState.Running;

            MnsMainMenu.Hide();
            HideBottomBarIfVisible();

            HideICOControlsIfVisible();

            this.FormBorderStyle = FormBorderStyle.None;
            ChangeFormBorderStyleForSlideShow();
            this.BackColor = Color.Black;
            PbMainDisplay.BackColor = Color.Black;

            CmStartSlideShowToolStripMenuItem.Enabled = false;
            StartSlideShowToolStripMenuItem.Enabled = false;
            endSlideShowToolStripMenuItem.Enabled = true;

            PbMainDisplay.ContextMenuStrip = CmSlideShow;

            SlideShowTimer.Start();
        }

        private void StopSlideShow()
        {
            if (_SlideShowState == SlideShowState.Stopped) return;

            _SlideShowState = SlideShowState.Stopped;

            SlideShowTimer.Stop();

            MnsMainMenu.Show();

            ShowBottomBarIfNotVisible();

            if (_IsICOLoaded)
                ShowICOControlsIfNotVisible();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = _WindowStateBeforeSlideShow;
            this.BackColor = Color.White;
            PbMainDisplay.BackColor = Color.White;

            CmStartSlideShowToolStripMenuItem.Enabled = true;
            StartSlideShowToolStripMenuItem.Enabled = true;
            endSlideShowToolStripMenuItem.Enabled = false;

            PbMainDisplay.ContextMenuStrip = CmImage;
        }

        private void StartSlideShow_Click(object sender, EventArgs e)
        {
            StartSlideShow();
        }

        private void EndSlideShow_Click(object sender, EventArgs e)
        {
            StopSlideShow();
        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            DisplayNextImage();
        }

        private void ToggleSlideShowSpeedRadioButton(ToolStripMenuItem SlideShowSpeedButton)
        {
            foreach (var button in _SlideShowSpeedRadioButtons)
            {
                if (button == SlideShowSpeedButton)
                { 
                    button.Checked = true;
                    SlideShowTimer.Interval = int.Parse(button.Tag.ToString());
                }
                else
                    button.Checked = false;
            }
        }

        private void SlideShowSpeed_Click(object sender, EventArgs e)
        {
            ToggleSlideShowSpeedRadioButton((ToolStripMenuItem)sender);
        }

        private void PauseSlideShow()
        {
            SlideShowTimer.Stop();
            _SlideShowState = SlideShowState.Paused;
        }

        private void ResumeSlideShow()
        {
            SlideShowTimer.Start();
            _SlideShowState = SlideShowState.Running;
        }

        private void CTPlaySlideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumeSlideShow();
        }

        private void pauseSlideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseSlideShow();
        }

        private void CmSlideShow_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CTPlaySlideShowToolStripMenuItem.Enabled = _SlideShowState == SlideShowState.Paused;
            CTPauseSlideShowToolStripMenuItem.Enabled = _SlideShowState == SlideShowState.Running;
        }

        private void CopyCurrentImageToClipBoard()
        {
            if (!IsValidImageShown()) return;

            Clipboard.SetImage(PbMainDisplay.Image);
        }

        private void CTCopyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyCurrentImageToClipBoard();
        }

        private void UpdateLbIconImageCount()
        {
            if (_IsICOLoaded)
                LbIconImageCount.Text = $"Image {_IcoImage.CurrentImageNumber} of {_IcoImage.NumberOfImagesInCurrentIcoFile}";
        }

        private void DisplayNextICOImage()
        {
            if (!_IsICOLoaded) return;

            Image imageToDisplay = _IcoImage.GetNextImage();

            if (imageToDisplay == null) return;

            PbMainDisplay.Image = imageToDisplay;
            UpdateLbIconImageCount();
        }

        private void BtnNextICOImage_Click(object sender, EventArgs e)
        {
            DisplayNextICOImage();
        }

        private void DisplayPreviousICOImage()
        {
            if (!_IsICOLoaded) return;

            Image imageToDisplay = _IcoImage.GetPreviousImage();

            if (imageToDisplay == null) return;

            PbMainDisplay.Image = imageToDisplay;
            UpdateLbIconImageCount();
        }

        private void BtnPreviousICOImage_Click(object sender, EventArgs e)
        {
            DisplayPreviousICOImage();
        }
    }
}
