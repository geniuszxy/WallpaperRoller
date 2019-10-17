using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperRoller
{
	public partial class HelperForm : Form
	{
		bool _installMode;

		public HelperForm()
		{
			InitializeComponent();
		}

		private void HelperForm_Load(object sender, EventArgs e)
		{
			if(Service.IsServiceInstalled())
			{
				btnInstall.Text = "Uninstall";
				gbSaveFolder.Enabled = true;
				_installMode = false;
			}
			else
			{
				btnInstall.Text = "Install";
				gbSaveFolder.Enabled = false;
				_installMode = true;
			}
		}

		
	}
}
