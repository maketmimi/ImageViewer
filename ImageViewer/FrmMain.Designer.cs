namespace ImageViewer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TblMain = new System.Windows.Forms.TableLayoutPanel();
            this.PbMainDisplay = new System.Windows.Forms.PictureBox();
            this.CmImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTsmBrowseImage = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsmSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CTsmRotateImage = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsm90DegreesRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsm180DegreesRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsm270DegreesRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsmFlipImage = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsmFlipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.CTsmFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmStartSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBottomBar = new System.Windows.Forms.Panel();
            this.BtnSlideShow = new System.Windows.Forms.Button();
            this.ImgBig = new System.Windows.Forms.ImageList(this.components);
            this.BtnPreviousImage = new System.Windows.Forms.Button();
            this.ImgSmall = new System.Windows.Forms.ImageList(this.components);
            this.BtnNextImage = new System.Windows.Forms.Button();
            this.OpfdBrowseImage = new System.Windows.Forms.OpenFileDialog();
            this.FbdPicturesFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.MnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90degreesClockWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180degreesClockWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270degreesClockWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizentolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePicturesFolderPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.CmSlideShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTPlaySlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CTPauseSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.slideShowSpeedSlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowSpeedMediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowSpeedFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainDisplay)).BeginInit();
            this.CmImage.SuspendLayout();
            this.PnlBottomBar.SuspendLayout();
            this.MnsMainMenu.SuspendLayout();
            this.CmSlideShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblMain
            // 
            this.TblMain.BackColor = System.Drawing.Color.Transparent;
            this.TblMain.ColumnCount = 1;
            this.TblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblMain.Controls.Add(this.PbMainDisplay, 0, 0);
            this.TblMain.Controls.Add(this.PnlBottomBar, 0, 1);
            this.TblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMain.Location = new System.Drawing.Point(0, 24);
            this.TblMain.Name = "TblMain";
            this.TblMain.RowCount = 2;
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TblMain.Size = new System.Drawing.Size(742, 420);
            this.TblMain.TabIndex = 0;
            // 
            // PbMainDisplay
            // 
            this.PbMainDisplay.BackColor = System.Drawing.Color.White;
            this.PbMainDisplay.ContextMenuStrip = this.CmImage;
            this.PbMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbMainDisplay.Location = new System.Drawing.Point(3, 3);
            this.PbMainDisplay.Name = "PbMainDisplay";
            this.PbMainDisplay.Size = new System.Drawing.Size(736, 365);
            this.PbMainDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMainDisplay.TabIndex = 1;
            this.PbMainDisplay.TabStop = false;
            this.PbMainDisplay.SizeChanged += new System.EventHandler(this.PbMainDisplay_SizeChanged);
            // 
            // CmImage
            // 
            this.CmImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTsmBrowseImage,
            this.CTsmSeperator1,
            this.CTsmRotateImage,
            this.CTsmFlipImage,
            this.toolStripSeparator1,
            this.CmStartSlideShowToolStripMenuItem});
            this.CmImage.Name = "CmImage";
            this.CmImage.Size = new System.Drawing.Size(192, 104);
            this.CmImage.Opening += new System.ComponentModel.CancelEventHandler(this.CmImage_Opening);
            // 
            // CTsmBrowseImage
            // 
            this.CTsmBrowseImage.Image = ((System.Drawing.Image)(resources.GetObject("CTsmBrowseImage.Image")));
            this.CTsmBrowseImage.Name = "CTsmBrowseImage";
            this.CTsmBrowseImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.CTsmBrowseImage.Size = new System.Drawing.Size(191, 22);
            this.CTsmBrowseImage.Text = "&Browse Image";
            this.CTsmBrowseImage.Click += new System.EventHandler(this.OpenPictureToolStripMenuItem_Click);
            // 
            // CTsmSeperator1
            // 
            this.CTsmSeperator1.Name = "CTsmSeperator1";
            this.CTsmSeperator1.Size = new System.Drawing.Size(188, 6);
            // 
            // CTsmRotateImage
            // 
            this.CTsmRotateImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTsm90DegreesRotation,
            this.CTsm180DegreesRotation,
            this.CTsm270DegreesRotation});
            this.CTsmRotateImage.Image = ((System.Drawing.Image)(resources.GetObject("CTsmRotateImage.Image")));
            this.CTsmRotateImage.Name = "CTsmRotateImage";
            this.CTsmRotateImage.Size = new System.Drawing.Size(191, 22);
            this.CTsmRotateImage.Text = "&Rotate Image";
            // 
            // CTsm90DegreesRotation
            // 
            this.CTsm90DegreesRotation.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.CTsm90DegreesRotation.Name = "CTsm90DegreesRotation";
            this.CTsm90DegreesRotation.Size = new System.Drawing.Size(195, 22);
            this.CTsm90DegreesRotation.Text = "&90 Degrees ClockWise";
            this.CTsm90DegreesRotation.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // CTsm180DegreesRotation
            // 
            this.CTsm180DegreesRotation.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.CTsm180DegreesRotation.Name = "CTsm180DegreesRotation";
            this.CTsm180DegreesRotation.Size = new System.Drawing.Size(195, 22);
            this.CTsm180DegreesRotation.Text = "1&80 Degrees ClockWise";
            this.CTsm180DegreesRotation.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // CTsm270DegreesRotation
            // 
            this.CTsm270DegreesRotation.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.CTsm270DegreesRotation.Name = "CTsm270DegreesRotation";
            this.CTsm270DegreesRotation.Size = new System.Drawing.Size(195, 22);
            this.CTsm270DegreesRotation.Text = "2&70 Degrees ClockWise";
            this.CTsm270DegreesRotation.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // CTsmFlipImage
            // 
            this.CTsmFlipImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTsmFlipVertical,
            this.CTsmFlipHorizontal});
            this.CTsmFlipImage.Image = ((System.Drawing.Image)(resources.GetObject("CTsmFlipImage.Image")));
            this.CTsmFlipImage.Name = "CTsmFlipImage";
            this.CTsmFlipImage.Size = new System.Drawing.Size(191, 22);
            this.CTsmFlipImage.Text = "&Flip Image";
            // 
            // CTsmFlipVertical
            // 
            this.CTsmFlipVertical.Image = ((System.Drawing.Image)(resources.GetObject("CTsmFlipVertical.Image")));
            this.CTsmFlipVertical.Name = "CTsmFlipVertical";
            this.CTsmFlipVertical.Size = new System.Drawing.Size(151, 22);
            this.CTsmFlipVertical.Text = "Flip &Vertical";
            this.CTsmFlipVertical.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // CTsmFlipHorizontal
            // 
            this.CTsmFlipHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("CTsmFlipHorizontal.Image")));
            this.CTsmFlipHorizontal.Name = "CTsmFlipHorizontal";
            this.CTsmFlipHorizontal.Size = new System.Drawing.Size(151, 22);
            this.CTsmFlipHorizontal.Text = "Flip &Horizontal";
            this.CTsmFlipHorizontal.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // CmStartSlideShowToolStripMenuItem
            // 
            this.CmStartSlideShowToolStripMenuItem.Name = "CmStartSlideShowToolStripMenuItem";
            this.CmStartSlideShowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.CmStartSlideShowToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CmStartSlideShowToolStripMenuItem.Text = "Start Slide Show";
            this.CmStartSlideShowToolStripMenuItem.Click += new System.EventHandler(this.StartSlideShow_Click);
            // 
            // PnlBottomBar
            // 
            this.PnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PnlBottomBar.Controls.Add(this.BtnSlideShow);
            this.PnlBottomBar.Controls.Add(this.BtnPreviousImage);
            this.PnlBottomBar.Controls.Add(this.BtnNextImage);
            this.PnlBottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottomBar.Location = new System.Drawing.Point(3, 374);
            this.PnlBottomBar.Name = "PnlBottomBar";
            this.PnlBottomBar.Size = new System.Drawing.Size(736, 43);
            this.PnlBottomBar.TabIndex = 0;
            // 
            // BtnSlideShow
            // 
            this.BtnSlideShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSlideShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSlideShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnSlideShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnSlideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlideShow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSlideShow.ImageIndex = 1;
            this.BtnSlideShow.ImageList = this.ImgBig;
            this.BtnSlideShow.Location = new System.Drawing.Point(352, 6);
            this.BtnSlideShow.Name = "BtnSlideShow";
            this.BtnSlideShow.Size = new System.Drawing.Size(33, 30);
            this.BtnSlideShow.TabIndex = 6;
            this.BtnSlideShow.UseVisualStyleBackColor = true;
            this.BtnSlideShow.Click += new System.EventHandler(this.StartSlideShow_Click);
            // 
            // ImgBig
            // 
            this.ImgBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgBig.ImageStream")));
            this.ImgBig.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgBig.Images.SetKeyName(0, "ChangeFolderIcon24X24.png");
            this.ImgBig.Images.SetKeyName(1, "image.png");
            // 
            // BtnPreviousImage
            // 
            this.BtnPreviousImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPreviousImage.Enabled = false;
            this.BtnPreviousImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPreviousImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnPreviousImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnPreviousImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreviousImage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPreviousImage.ImageKey = "PreviosImage.png";
            this.BtnPreviousImage.ImageList = this.ImgSmall;
            this.BtnPreviousImage.Location = new System.Drawing.Point(311, 6);
            this.BtnPreviousImage.Name = "BtnPreviousImage";
            this.BtnPreviousImage.Size = new System.Drawing.Size(33, 30);
            this.BtnPreviousImage.TabIndex = 5;
            this.BtnPreviousImage.UseVisualStyleBackColor = true;
            this.BtnPreviousImage.Click += new System.EventHandler(this.PreviousImage_Click);
            // 
            // ImgSmall
            // 
            this.ImgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmall.ImageStream")));
            this.ImgSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmall.Images.SetKeyName(0, "rotate-left.png");
            this.ImgSmall.Images.SetKeyName(1, "rotate-right.png");
            this.ImgSmall.Images.SetKeyName(2, "NextImage.png");
            this.ImgSmall.Images.SetKeyName(3, "PreviosImage.png");
            this.ImgSmall.Images.SetKeyName(4, "image.png");
            // 
            // BtnNextImage
            // 
            this.BtnNextImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNextImage.Enabled = false;
            this.BtnNextImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNextImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnNextImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextImage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnNextImage.ImageKey = "NextImage.png";
            this.BtnNextImage.ImageList = this.ImgSmall;
            this.BtnNextImage.Location = new System.Drawing.Point(393, 6);
            this.BtnNextImage.Name = "BtnNextImage";
            this.BtnNextImage.Size = new System.Drawing.Size(33, 30);
            this.BtnNextImage.TabIndex = 4;
            this.BtnNextImage.UseVisualStyleBackColor = true;
            this.BtnNextImage.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // OpfdBrowseImage
            // 
            this.OpfdBrowseImage.Title = "View Image";
            // 
            // FbdPicturesFolder
            // 
            this.FbdPicturesFolder.Description = "Choose your default initial Pictures folder";
            this.FbdPicturesFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MnsMainMenu
            // 
            this.MnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMainMenu.Name = "MnsMainMenu";
            this.MnsMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MnsMainMenu.Size = new System.Drawing.Size(742, 24);
            this.MnsMainMenu.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPictureToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openPictureToolStripMenuItem.Image")));
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openPictureToolStripMenuItem.Text = "&Browse Image";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.OpenPictureToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSlideShowToolStripMenuItem,
            this.endSlideShowToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // StartSlideShowToolStripMenuItem
            // 
            this.StartSlideShowToolStripMenuItem.Name = "StartSlideShowToolStripMenuItem";
            this.StartSlideShowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.StartSlideShowToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.StartSlideShowToolStripMenuItem.Text = "&Start Slide Show";
            this.StartSlideShowToolStripMenuItem.Click += new System.EventHandler(this.StartSlideShow_Click);
            // 
            // endSlideShowToolStripMenuItem
            // 
            this.endSlideShowToolStripMenuItem.Enabled = false;
            this.endSlideShowToolStripMenuItem.Name = "endSlideShowToolStripMenuItem";
            this.endSlideShowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.endSlideShowToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.endSlideShowToolStripMenuItem.Text = "End Slide Show";
            this.endSlideShowToolStripMenuItem.Click += new System.EventHandler(this.EndSlideShow_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateImageToolStripMenuItem,
            this.flipImageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // rotateImageToolStripMenuItem
            // 
            this.rotateImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90degreesClockWiseToolStripMenuItem,
            this.Rotate180degreesClockWiseToolStripMenuItem,
            this.Rotate270degreesClockWiseToolStripMenuItem});
            this.rotateImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rotateImageToolStripMenuItem.Image")));
            this.rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            this.rotateImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotateImageToolStripMenuItem.Text = "&Rotate Image";
            // 
            // Rotate90degreesClockWiseToolStripMenuItem
            // 
            this.Rotate90degreesClockWiseToolStripMenuItem.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.Rotate90degreesClockWiseToolStripMenuItem.Name = "Rotate90degreesClockWiseToolStripMenuItem";
            this.Rotate90degreesClockWiseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Rotate90degreesClockWiseToolStripMenuItem.Text = "&90 Degrees ClockWise";
            this.Rotate90degreesClockWiseToolStripMenuItem.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // Rotate180degreesClockWiseToolStripMenuItem
            // 
            this.Rotate180degreesClockWiseToolStripMenuItem.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.Rotate180degreesClockWiseToolStripMenuItem.Name = "Rotate180degreesClockWiseToolStripMenuItem";
            this.Rotate180degreesClockWiseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Rotate180degreesClockWiseToolStripMenuItem.Text = "1&80 Degrees ClockWise";
            this.Rotate180degreesClockWiseToolStripMenuItem.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // Rotate270degreesClockWiseToolStripMenuItem
            // 
            this.Rotate270degreesClockWiseToolStripMenuItem.Image = global::ImageViewer.Properties.Resources.rotate_right;
            this.Rotate270degreesClockWiseToolStripMenuItem.Name = "Rotate270degreesClockWiseToolStripMenuItem";
            this.Rotate270degreesClockWiseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Rotate270degreesClockWiseToolStripMenuItem.Text = "2&70 Degrees ClockWise";
            this.Rotate270degreesClockWiseToolStripMenuItem.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // flipImageToolStripMenuItem
            // 
            this.flipImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipVerticalToolStripMenuItem,
            this.flipHorizentolToolStripMenuItem});
            this.flipImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipImageToolStripMenuItem.Image")));
            this.flipImageToolStripMenuItem.Name = "flipImageToolStripMenuItem";
            this.flipImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.flipImageToolStripMenuItem.Text = "&Flip Image";
            // 
            // flipVerticalToolStripMenuItem
            // 
            this.flipVerticalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalToolStripMenuItem.Image")));
            this.flipVerticalToolStripMenuItem.Name = "flipVerticalToolStripMenuItem";
            this.flipVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.flipVerticalToolStripMenuItem.Text = "Flip &Vertical";
            this.flipVerticalToolStripMenuItem.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // flipHorizentolToolStripMenuItem
            // 
            this.flipHorizentolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizentolToolStripMenuItem.Image")));
            this.flipHorizentolToolStripMenuItem.Name = "flipHorizentolToolStripMenuItem";
            this.flipHorizentolToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.flipHorizentolToolStripMenuItem.Text = "Flip &Horizontal";
            this.flipHorizentolToolStripMenuItem.Click += new System.EventHandler(this.RotateFlipImageToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePicturesFolderPathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // changePicturesFolderPathToolStripMenuItem
            // 
            this.changePicturesFolderPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePicturesFolderPathToolStripMenuItem.Image")));
            this.changePicturesFolderPathToolStripMenuItem.Name = "changePicturesFolderPathToolStripMenuItem";
            this.changePicturesFolderPathToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.changePicturesFolderPathToolStripMenuItem.Text = "&Change pictures folder path";
            this.changePicturesFolderPathToolStripMenuItem.Click += new System.EventHandler(this.ChangePicturesFolderPathToolStripMenuItem_Click);
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Interval = 3000;
            this.SlideShowTimer.Tick += new System.EventHandler(this.SlideShowTimer_Tick);
            // 
            // CmSlideShow
            // 
            this.CmSlideShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTPlaySlideShowToolStripMenuItem,
            this.CTPauseSlideShowToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.backToolStripMenuItem,
            this.toolStripSeparator3,
            this.slideShowSpeedSlowToolStripMenuItem,
            this.slideShowSpeedMediumToolStripMenuItem,
            this.slideShowSpeedFastToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.CmSlideShow.Name = "CmSlideShow";
            this.CmSlideShow.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CmSlideShow.Size = new System.Drawing.Size(223, 214);
            this.CmSlideShow.Opening += new System.ComponentModel.CancelEventHandler(this.CmSlideShow_Opening);
            // 
            // CTPlaySlideShowToolStripMenuItem
            // 
            this.CTPlaySlideShowToolStripMenuItem.Enabled = false;
            this.CTPlaySlideShowToolStripMenuItem.Name = "CTPlaySlideShowToolStripMenuItem";
            this.CTPlaySlideShowToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CTPlaySlideShowToolStripMenuItem.Text = "&Play";
            this.CTPlaySlideShowToolStripMenuItem.Click += new System.EventHandler(this.CTPlaySlideShowToolStripMenuItem_Click);
            // 
            // CTPauseSlideShowToolStripMenuItem
            // 
            this.CTPauseSlideShowToolStripMenuItem.Name = "CTPauseSlideShowToolStripMenuItem";
            this.CTPauseSlideShowToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CTPauseSlideShowToolStripMenuItem.Text = "P&ause";
            this.CTPauseSlideShowToolStripMenuItem.Click += new System.EventHandler(this.pauseSlideShowToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.nextToolStripMenuItem.Text = "&Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.PreviousImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // slideShowSpeedSlowToolStripMenuItem
            // 
            this.slideShowSpeedSlowToolStripMenuItem.Name = "slideShowSpeedSlowToolStripMenuItem";
            this.slideShowSpeedSlowToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.slideShowSpeedSlowToolStripMenuItem.Tag = "6000";
            this.slideShowSpeedSlowToolStripMenuItem.Text = "Slide Show Speed - &Slow";
            this.slideShowSpeedSlowToolStripMenuItem.Click += new System.EventHandler(this.SlideShowSpeed_Click);
            // 
            // slideShowSpeedMediumToolStripMenuItem
            // 
            this.slideShowSpeedMediumToolStripMenuItem.Checked = true;
            this.slideShowSpeedMediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slideShowSpeedMediumToolStripMenuItem.Name = "slideShowSpeedMediumToolStripMenuItem";
            this.slideShowSpeedMediumToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.slideShowSpeedMediumToolStripMenuItem.Tag = "3000";
            this.slideShowSpeedMediumToolStripMenuItem.Text = "Slide Show Speed - &Medium";
            this.slideShowSpeedMediumToolStripMenuItem.Click += new System.EventHandler(this.SlideShowSpeed_Click);
            // 
            // slideShowSpeedFastToolStripMenuItem
            // 
            this.slideShowSpeedFastToolStripMenuItem.Name = "slideShowSpeedFastToolStripMenuItem";
            this.slideShowSpeedFastToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.slideShowSpeedFastToolStripMenuItem.Tag = "1000";
            this.slideShowSpeedFastToolStripMenuItem.Text = "Slide Show Speed - &Fast";
            this.slideShowSpeedFastToolStripMenuItem.Click += new System.EventHandler(this.SlideShowSpeed_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.EndSlideShow_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 444);
            this.Controls.Add(this.TblMain);
            this.Controls.Add(this.MnsMainMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MnsMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(758, 483);
            this.Name = "FrmMain";
            this.Text = "Image Viewer";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.TblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMainDisplay)).EndInit();
            this.CmImage.ResumeLayout(false);
            this.PnlBottomBar.ResumeLayout(false);
            this.MnsMainMenu.ResumeLayout(false);
            this.MnsMainMenu.PerformLayout();
            this.CmSlideShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblMain;
        private System.Windows.Forms.Panel PnlBottomBar;
        private System.Windows.Forms.PictureBox PbMainDisplay;
        private System.Windows.Forms.OpenFileDialog OpfdBrowseImage;
        private System.Windows.Forms.ImageList ImgSmall;
        private System.Windows.Forms.ImageList ImgBig;
        private System.Windows.Forms.FolderBrowserDialog FbdPicturesFolder;
        private System.Windows.Forms.MenuStrip MnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePicturesFolderPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate90degreesClockWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate180degreesClockWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate270degreesClockWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizentolToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CmImage;
        private System.Windows.Forms.ToolStripMenuItem CTsmBrowseImage;
        private System.Windows.Forms.ToolStripSeparator CTsmSeperator1;
        private System.Windows.Forms.ToolStripMenuItem CTsmRotateImage;
        private System.Windows.Forms.ToolStripMenuItem CTsm90DegreesRotation;
        private System.Windows.Forms.ToolStripMenuItem CTsm180DegreesRotation;
        private System.Windows.Forms.ToolStripMenuItem CTsm270DegreesRotation;
        private System.Windows.Forms.ToolStripMenuItem CTsmFlipImage;
        private System.Windows.Forms.ToolStripMenuItem CTsmFlipVertical;
        private System.Windows.Forms.ToolStripMenuItem CTsmFlipHorizontal;
        private System.Windows.Forms.Button BtnPreviousImage;
        private System.Windows.Forms.Button BtnNextImage;
        private System.Windows.Forms.Button BtnSlideShow;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartSlideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CmStartSlideShowToolStripMenuItem;
        private System.Windows.Forms.Timer SlideShowTimer;
        private System.Windows.Forms.ToolStripMenuItem endSlideShowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CmSlideShow;
        private System.Windows.Forms.ToolStripMenuItem CTPlaySlideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CTPauseSlideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem slideShowSpeedSlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowSpeedMediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowSpeedFastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

