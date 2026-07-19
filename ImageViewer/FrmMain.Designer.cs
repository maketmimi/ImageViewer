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
            this.PnlBottomBar = new System.Windows.Forms.Panel();
            this.BtnRotateRight = new System.Windows.Forms.Button();
            this.ImgMain = new System.Windows.Forms.ImageList(this.components);
            this.BtnRotateLeft = new System.Windows.Forms.Button();
            this.BtnBrowseImage = new System.Windows.Forms.Button();
            this.OpfdBrowseImage = new System.Windows.Forms.OpenFileDialog();
            this.TblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainDisplay)).BeginInit();
            this.PnlBottomBar.SuspendLayout();
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
            this.TblMain.Location = new System.Drawing.Point(0, 0);
            this.TblMain.Name = "TblMain";
            this.TblMain.RowCount = 2;
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TblMain.Size = new System.Drawing.Size(742, 444);
            this.TblMain.TabIndex = 0;
            // 
            // PbMainDisplay
            // 
            this.PbMainDisplay.BackColor = System.Drawing.Color.White;
            this.PbMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbMainDisplay.Location = new System.Drawing.Point(3, 3);
            this.PbMainDisplay.Name = "PbMainDisplay";
            this.PbMainDisplay.Size = new System.Drawing.Size(736, 389);
            this.PbMainDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMainDisplay.TabIndex = 1;
            this.PbMainDisplay.TabStop = false;
            this.PbMainDisplay.SizeChanged += new System.EventHandler(this.PbMainDisplay_SizeChanged);
            // 
            // PnlBottomBar
            // 
            this.PnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PnlBottomBar.Controls.Add(this.BtnRotateRight);
            this.PnlBottomBar.Controls.Add(this.BtnRotateLeft);
            this.PnlBottomBar.Controls.Add(this.BtnBrowseImage);
            this.PnlBottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottomBar.Location = new System.Drawing.Point(3, 398);
            this.PnlBottomBar.Name = "PnlBottomBar";
            this.PnlBottomBar.Size = new System.Drawing.Size(736, 43);
            this.PnlBottomBar.TabIndex = 0;
            // 
            // BtnRotateRight
            // 
            this.BtnRotateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRotateRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRotateRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnRotateRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateRight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRotateRight.ImageKey = "rotate-right.png";
            this.BtnRotateRight.ImageList = this.ImgMain;
            this.BtnRotateRight.Location = new System.Drawing.Point(48, 6);
            this.BtnRotateRight.Name = "BtnRotateRight";
            this.BtnRotateRight.Size = new System.Drawing.Size(33, 30);
            this.BtnRotateRight.TabIndex = 3;
            this.BtnRotateRight.UseVisualStyleBackColor = true;
            this.BtnRotateRight.Click += new System.EventHandler(this.BtnRotateRight_Click);
            // 
            // ImgMain
            // 
            this.ImgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgMain.ImageStream")));
            this.ImgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgMain.Images.SetKeyName(0, "rotate-left.png");
            this.ImgMain.Images.SetKeyName(1, "rotate-right.png");
            // 
            // BtnRotateLeft
            // 
            this.BtnRotateLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRotateLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRotateLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnRotateLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateLeft.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRotateLeft.ImageKey = "rotate-left.png";
            this.BtnRotateLeft.ImageList = this.ImgMain;
            this.BtnRotateLeft.Location = new System.Drawing.Point(9, 6);
            this.BtnRotateLeft.Name = "BtnRotateLeft";
            this.BtnRotateLeft.Size = new System.Drawing.Size(33, 30);
            this.BtnRotateLeft.TabIndex = 2;
            this.BtnRotateLeft.UseVisualStyleBackColor = true;
            this.BtnRotateLeft.Click += new System.EventHandler(this.BtnRotateLeft_Click);
            // 
            // BtnBrowseImage
            // 
            this.BtnBrowseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBrowseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.BtnBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.BtnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseImage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBrowseImage.Location = new System.Drawing.Point(322, 4);
            this.BtnBrowseImage.Name = "BtnBrowseImage";
            this.BtnBrowseImage.Size = new System.Drawing.Size(92, 35);
            this.BtnBrowseImage.TabIndex = 1;
            this.BtnBrowseImage.Text = "Browse";
            this.BtnBrowseImage.UseVisualStyleBackColor = true;
            this.BtnBrowseImage.Click += new System.EventHandler(this.BtnBrowseImage_Click);
            // 
            // OpfdBrowseImage
            // 
            this.OpfdBrowseImage.Title = "View Image";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 444);
            this.Controls.Add(this.TblMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(758, 483);
            this.Name = "FrmMain";
            this.Text = "Image Viewer";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.TblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMainDisplay)).EndInit();
            this.PnlBottomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblMain;
        private System.Windows.Forms.Panel PnlBottomBar;
        private System.Windows.Forms.Button BtnBrowseImage;
        private System.Windows.Forms.PictureBox PbMainDisplay;
        private System.Windows.Forms.OpenFileDialog OpfdBrowseImage;
        private System.Windows.Forms.Button BtnRotateLeft;
        private System.Windows.Forms.ImageList ImgMain;
        private System.Windows.Forms.Button BtnRotateRight;
    }
}

