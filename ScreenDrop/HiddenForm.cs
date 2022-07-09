// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ScreenDrop
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Hidden form.
    /// </summary>
    internal class HiddenForm : Form
    {
        /// <summary>
        /// Registers the hot key.
        /// </summary>
        /// <returns><c>true</c>, if hot key was registered, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="id">Identifier.</param>
        /// <param name="fsModifiers">Fs modifiers.</param>
        /// <param name="vk">Vk.</param>
        [DllImport("User32")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        /// <summary>
        /// Unregisters the hot key.
        /// </summary>
        /// <returns><c>true</c>, if hot key was unregistered, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="id">Identifier.</param>
        [DllImport("User32")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// The mod shift.
        /// </summary>
        private const int MOD_SHIFT = 0x4;

        /// <summary>
        /// The mod control.
        /// </summary>
        private const int MOD_CONTROL = 0x2;

        /// <summary>
        /// The mod alternate.
        /// </summary>
        private const int MOD_ALT = 0x1;

        /// <summary>
        /// The wm hotkey.
        /// </summary>
        private static int WM_HOTKEY = 0x0312;

        /// <summary>
        /// The main form.
        /// </summary>
        internal MainForm mainForm = null;

        /// <summary>
        /// The notify icon.
        /// </summary>
        private System.Windows.Forms.NotifyIcon notifyIcon;

        /// <summary>
        /// The exit tool strip menu item.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        /// <summary>
        /// The show tool strip menu item.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;

        /// <summary>
        /// The notify icon context menu strip.
        /// </summary>
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;

        /// <summary>
        /// The application context.
        /// </summary>
        private ApplicationContext applicationContext = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ClipHoard.HiddenForm"/> class.
        /// </summary>
        public HiddenForm(ApplicationContext applicationContext)
        {
            // Set the application context
            this.applicationContext = applicationContext;

            /* Main form */

            // Set main form
            this.mainForm = new MainForm();

            // Show with owner
            this.mainForm.Show(this);

            // Register hotkeys
            this.mainForm.OnHotkeyUpdated(this, new EventArgs());

            /* notifyIcon */

            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.showToolStripMenuItem,
                                    this.exitToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "&Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.OnShowToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);

            // Set the notify icon
            this.notifyIcon = new System.Windows.Forms.NotifyIcon
            {
                Text = "Click to show",
                Icon = this.mainForm.Icon,
                ContextMenuStrip = this.notifyIconContextMenuStrip,
                Visible = true
            };

            // NOtify icon event handlers
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnNotifyIconMouseClick);
        }

        /// <summary>
        /// Handles the show tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnShowToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Restore window 
            this.mainForm.RestoreFromSystemTray();
        }

        /// <summary>
        /// Handles the exit tool strip menu item1 click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close main form
            this.mainForm.Close();
        }

        /// <summary>
        /// Exits the thread.
        /// </summary>
        internal void ExitThread()
        {
            // Close application
            this.applicationContext.ExitThread();
        }

        /// <summary>
        /// Handles the notify icon mouse click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNotifyIconMouseClick(object sender, MouseEventArgs e)
        {
            // Check for left click
            if (e.Button == MouseButtons.Left)
            {
                // Restore window 
                this.mainForm.RestoreFromSystemTray();
            }
        }

        /// <summary>
        /// Windows the proc.
        /// </summary>
        /// <param name="m">M.</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                // Hide it
                this.mainForm.SendToSystemTray();

                // Ensure it's not visible
                while (this.mainForm.Visible || this.mainForm.ShowInTaskbar)
                {
                    // Loop
                    continue;
                }

                // Perform screenshot
                this.mainForm.TakeScreenshot();

                // Restore window 
                this.mainForm.RestoreFromSystemTray();
            }
        }

        /// <summary>
        /// Updates the hotkey.
        /// </summary>
        internal void UpdateHotkey(bool control, bool alt, bool shift, string key)
        {
            // Try to unregister the key
            try
            {
                // Unregister the hotkey
                UnregisterHotKey(this.Handle, 0);
            }
            catch
            {
                // Let it fall through
            }

            // Try to register the key
            try
            {
                // Register the hotkey
                RegisterHotKey(this.Handle, 0, (control ? MOD_CONTROL : 0) + (alt ? MOD_ALT : 0) + (shift ? MOD_SHIFT : 0), Convert.ToInt16((Keys)Enum.Parse(typeof(Keys), key, true)));
            }
            catch
            {
                // Let it fall through
            }
        }

        /// <summary>
        /// Disposes the notify icon.
        /// </summary>
        internal void NotifyIconDispose()
        {
            this.notifyIcon.Visible = false;
            this.notifyIcon.Icon.Dispose();
            this.notifyIcon.Dispose();
        }
    }
}
