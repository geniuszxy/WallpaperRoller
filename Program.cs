using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace WallpaperRoller
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[MTAThread]
		static void Main(string[] args)
		{
			if (args != null && args.Length > 0)
			{
				switch (args[0])
				{
					// Service mode
					case "service":
						ServiceBase.Run(new Service());
						return;

					// Install as service
					case "install":
					case "--install":
					case "-i":
					case "/install":
					case "/i":
						Service.Install(true);
						return;
					
					// Uninstall the service
					case "uninstall":
					case "--uninstall":
					case "-u":
					case "/uninstall":
					case "/u":
						Service.Install(false);
						return;

					default:
						if (Environment.UserInteractive)
							Console.WriteLine("Unknown argument at 0");
						return;
				}
			}

			// Winform mode
			var uiThread = new Thread(FormMain);
			uiThread.SetApartmentState(ApartmentState.STA);
			uiThread.Start();
			uiThread.Join();
		}

		/// <summary>
		/// The UI thread
		/// </summary>
		static void FormMain()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HelperForm());
		}
	}
}
