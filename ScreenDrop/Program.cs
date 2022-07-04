
using System;
using System.Windows.Forms;

namespace ScreenDrop
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			/*Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());*/
			
			var ctx = new ApplicationContext();
            var frmHidden = new HiddenForm(ctx);
            //pass the application context, not the form
            Application.Run(ctx);
		}
		
	}
}
