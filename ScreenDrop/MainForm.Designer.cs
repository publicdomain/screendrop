
namespace ScreenDrop
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.samplesInLIstToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.screenshotsCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hotkeyCombinationLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.controlCheckBox = new System.Windows.Forms.CheckBox();
            this.altCheckBox = new System.Windows.Forms.CheckBox();
            this.shiftCheckBox = new System.Windows.Forms.CheckBox();
            this.keyComboBox = new System.Windows.Forms.ComboBox();
            this.screenDragPictrueBoxLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.samplesInLIstToolStripStatusLabel,
                                    this.screenshotsCountToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 240);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 52;
            // 
            // samplesInLIstToolStripStatusLabel
            // 
            this.samplesInLIstToolStripStatusLabel.Name = "samplesInLIstToolStripStatusLabel";
            this.samplesInLIstToolStripStatusLabel.Size = new System.Drawing.Size(73, 17);
            this.samplesInLIstToolStripStatusLabel.Text = "Screenshots:";
            // 
            // screenshotsCountToolStripStatusLabel
            // 
            this.screenshotsCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.screenshotsCountToolStripStatusLabel.Name = "screenshotsCountToolStripStatusLabel";
            this.screenshotsCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.screenshotsCountToolStripStatusLabel.Text = "0";
            // 
            // hotkeyCombinationLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.hotkeyCombinationLabel, 2);
            this.hotkeyCombinationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotkeyCombinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyCombinationLabel.Location = new System.Drawing.Point(3, 0);
            this.hotkeyCombinationLabel.Name = "hotkeyCombinationLabel";
            this.hotkeyCombinationLabel.Size = new System.Drawing.Size(278, 20);
            this.hotkeyCombinationLabel.TabIndex = 0;
            this.hotkeyCombinationLabel.Text = "&Hotkey combination:";
            this.hotkeyCombinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.imagePictureBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.hotkeyCombinationLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.screenDragPictrueBoxLabel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 238);
            this.mainTableLayoutPanel.TabIndex = 54;
            // 
            // imagePictureBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.imagePictureBox, 2);
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(3, 68);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(278, 167);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.DoubleClick += new System.EventHandler(this.OnImagePictureBoxDoubleClick);
            this.imagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnImagePictureBoxMouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.mainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.controlCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.altCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.shiftCheckBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyComboBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 25);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // controlCheckBox
            // 
            this.controlCheckBox.Location = new System.Drawing.Point(3, 3);
            this.controlCheckBox.Name = "controlCheckBox";
            this.controlCheckBox.Size = new System.Drawing.Size(65, 19);
            this.controlCheckBox.TabIndex = 1;
            this.controlCheckBox.Text = "&CTRL";
            this.controlCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.controlCheckBox.UseVisualStyleBackColor = true;
            this.controlCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // altCheckBox
            // 
            this.altCheckBox.Location = new System.Drawing.Point(74, 3);
            this.altCheckBox.Name = "altCheckBox";
            this.altCheckBox.Size = new System.Drawing.Size(65, 19);
            this.altCheckBox.TabIndex = 2;
            this.altCheckBox.Text = "&ALT";
            this.altCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.altCheckBox.UseVisualStyleBackColor = true;
            this.altCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // shiftCheckBox
            // 
            this.shiftCheckBox.Location = new System.Drawing.Point(145, 3);
            this.shiftCheckBox.Name = "shiftCheckBox";
            this.shiftCheckBox.Size = new System.Drawing.Size(65, 19);
            this.shiftCheckBox.TabIndex = 3;
            this.shiftCheckBox.Text = "&SHIFT";
            this.shiftCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shiftCheckBox.UseVisualStyleBackColor = true;
            this.shiftCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // keyComboBox
            // 
            this.keyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyComboBox.FormattingEnabled = true;
            this.keyComboBox.Location = new System.Drawing.Point(216, 3);
            this.keyComboBox.Name = "keyComboBox";
            this.keyComboBox.Size = new System.Drawing.Size(65, 21);
            this.keyComboBox.TabIndex = 4;
            this.keyComboBox.SelectedIndexChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // screenDragPictrueBoxLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.screenDragPictrueBoxLabel, 2);
            this.screenDragPictrueBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenDragPictrueBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenDragPictrueBoxLabel.Location = new System.Drawing.Point(3, 45);
            this.screenDragPictrueBoxLabel.Name = "screenDragPictrueBoxLabel";
            this.screenDragPictrueBoxLabel.Size = new System.Drawing.Size(278, 20);
            this.screenDragPictrueBoxLabel.TabIndex = 5;
            this.screenDragPictrueBoxLabel.Text = "&Screen drag picturebox";
            this.screenDragPictrueBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 53;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.keepImagesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = true;
            this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // keepImagesToolStripMenuItem
            // 
            this.keepImagesToolStripMenuItem.Name = "keepImagesToolStripMenuItem";
            this.keepImagesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.keepImagesToolStripMenuItem.Text = "&Keep images";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadRedditcomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // originalThreadRedditcomToolStripMenuItem
            // 
            this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
            this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
            this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
            this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenDrop";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem keepImagesToolStripMenuItem;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label screenDragPictrueBoxLabel;
        private System.Windows.Forms.ComboBox keyComboBox;
        private System.Windows.Forms.CheckBox shiftCheckBox;
        private System.Windows.Forms.CheckBox altCheckBox;
        private System.Windows.Forms.CheckBox controlCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label hotkeyCombinationLabel;
        private System.Windows.Forms.ToolStripStatusLabel screenshotsCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel samplesInLIstToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
