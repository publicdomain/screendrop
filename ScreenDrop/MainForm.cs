// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace ScreenDrop
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        public SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The count.
        /// </summary>
        private int count = 0;

        /// <summary>
        /// The app directory.
        /// </summary>
        private string appDirectory = string.Empty;

        /// <summary>
        /// The screenshot path.
        /// </summary>
        private string screenshotPath = string.Empty;

        /// <summary>
        /// The default screenshot path.
        /// </summary>
        private string defaultScreenshotPath = string.Empty;

        /// <summary>
        /// The save directory.
        /// </summary>
        private string saveDirectory = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ScreenDrop.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set directories
            this.appDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            this.saveDirectory = Path.Combine(this.appDirectory, "Saved");
            this.defaultScreenshotPath = Path.Combine(this.appDirectory, "screenshot.png");

            // Add keys
            foreach (var key in Enum.GetValues(typeof(Keys)))
            {
                // Add to list box
                this.keyComboBox.Items.Add(key.ToString());
            }

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            /* Process settings */

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);
        }

        /// <summary>
        /// Handles the image picture box double click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnImagePictureBoxDoubleClick(object sender, EventArgs e)
        {
            // Check for image file
            if (this.screenshotPath.Length > 0 && File.Exists(this.screenshotPath))
            {
                // Open image
                Process.Start(this.screenshotPath);
            }
        }   

        /// <summary>
        /// Handles the image picture box mouse move.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnImagePictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            // TODO Drag [Can be improved: File.Exist check]
            if (e.Button == MouseButtons.Left && this.screenshotPath.Length > 0)
            {
                var files = new string[] { this.screenshotPath };

                this.imagePictureBox.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Remove if default
            if(this.screenshotPath == this.defaultScreenshotPath && File.Exists(this.defaultScreenshotPath))
            {
                // Remove from disk
                File.Delete(this.defaultScreenshotPath);
            }

            // Reset path
            this.screenshotPath = string.Empty;

            // Clear picturebox
            this.imagePictureBox.Image = null;
            this.imagePictureBox.Refresh();

            // Reset count
            this.count = 0;

            // Update status
            this.screenshotsCountToolStripStatusLabel.Text = this.count.ToString();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;

            /* Settings data */

            // ALways on top
            this.settingsData.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Load settings data to GUI
            this.SettingsDataToGui();

            // Hack Topmost on start [DEBUG]
            this.TopMost = this.settingsData.TopMost;
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose the notify icon
            ((HiddenForm)this.Owner).NotifyIconDispose();

            // Set settings from GUI
            this.GuiToSettingsData();

            // Save to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);

            try
            {
                // Remove default screenshot
                File.Delete(this.defaultScreenshotPath);
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"Could not remove default screenshot file!{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "Screenshot file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// GUIs to settings data.
        /// </summary>
        private void GuiToSettingsData()
        {
            // Options
            this.settingsData.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
            this.settingsData.KeepImages = this.keepImagesToolStripMenuItem.Checked;

            // Modifier checkboxes
            this.settingsData.Control = this.controlCheckBox.Checked;
            this.settingsData.Alt = this.altCheckBox.Checked;
            this.settingsData.Shift = this.shiftCheckBox.Checked;

            // Hotkey
            this.settingsData.Hotkey = this.keyComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Settingses the data to GUI.
        /// </summary>
        private void SettingsDataToGui()
        {
            // Options
            this.alwaysOnTopToolStripMenuItem.Checked = this.settingsData.TopMost;
            this.keepImagesToolStripMenuItem.Checked = this.settingsData.KeepImages;

            // Modifier checkboxes
            this.controlCheckBox.Checked = this.settingsData.Control;
            this.altCheckBox.Checked = this.settingsData.Alt;
            this.shiftCheckBox.Checked = this.settingsData.Shift;

            // Hotkey
            if (this.settingsData.Hotkey.Length > 0)
            {
                this.keyComboBox.SelectedItem = this.settingsData.Hotkey;
            }
        }

        /// <summary>
        /// Handles the minimize tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMinimizeToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            // Minimize to tray
            this.SendToSystemTray();
        }

        /// <summary>
        /// Sends the program to the system tray.
        /// </summary>
        internal void SendToSystemTray()
        {
            // Hide main form
            this.Hide();

            // Remove from task bar
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// Restores the window back from system tray to the foreground.
        /// </summary>
        internal void RestoreFromSystemTray()
        {
            // Make form visible again
            this.Show();

            // Return window back to normal
            this.WindowState = FormWindowState.Normal;

            // Restore in task bar
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// Takes the screenshot.
        /// </summary>
        internal void TakeScreenshot()
        {
            try
            {
                // Screen to bitmap
                Bitmap screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics g = Graphics.FromImage(screenBitmap);
                g.CopyFromScreen(0, 0, 0, 0, screenBitmap.Size);

                // Check if must save to disk
                if (this.keepImagesToolStripMenuItem.Checked)
                {
                    // TODO Create directory [Can be improved]
                    Directory.CreateDirectory(this.saveDirectory);

                    // Set screenshot path by save directory and current DateTime 
                    this.screenshotPath = Path.Combine(this.saveDirectory, string.Format("{0:yyyy-MM-dd_HH-mm-ss}.png", DateTime.Now));
                }
                else
                {
                    // Set to default screenshot path
                    this.screenshotPath = this.defaultScreenshotPath;
                }

                // Save to disk
                screenBitmap.Save(this.screenshotPath, ImageFormat.Png);

                // Set picturebox
                this.imagePictureBox.Image = screenBitmap;

                // Raise counter
                this.count++;

                // Update status
                this.screenshotsCountToolStripStatusLabel.Text = this.count.ToString();
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"Could not take screenshot!{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the hotkey updated event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        internal void OnHotkeyUpdated(object sender, EventArgs e)
        {
            // Only update if there's -at least- a valid key
            if ((this.keyComboBox.SelectedIndex > -1 && this.keyComboBox.SelectedItem.ToString().ToLowerInvariant() != "none"))
            {
                // Update the hotkey combination
                ((HiddenForm)this.Owner).UpdateHotkey(this.controlCheckBox.Checked, this.altCheckBox.Checked, this.shiftCheckBox.Checked, this.keyComboBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Handles the main form form closed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit the application
            ((HiddenForm)this.Owner).ExitThread();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
