using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperRoller
{
	public partial class Service : ServiceBase
	{
		public Service()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}

		/// <summary>
		/// Install or uninstall this service
		/// </summary>
		internal static void Install(bool isInstall)
		{
			if (!Environment.UserInteractive)
				return;

			var parameters = new List<string>
			{
				"/LogFile=",
				"/LogToConsole=true"
			};

			//uninstall
			if (!isInstall)
				parameters.Add("/u");

			parameters.Add(Assembly.GetExecutingAssembly().Location);
			ManagedInstallerClass.InstallHelper(parameters.ToArray());
		}

		internal static bool IsServiceInstalled()
		{
			var services = ServiceController.GetServices();
			foreach (var service in services)
				if (service.ServiceName == "Wallpaper Roller")
					return true;
			return false;
		}
	}
}
