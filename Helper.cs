using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace WallpaperRoller
{
	/// <summary>
	/// This is an helper class to change wallpaper and it's style
	/// </summary>
	class Helper
	{
		/// <summary>
		/// Note  When the SPI_SETDESKWALLPAPER flag is used, SystemParametersInfo returns TRUE unless there is an error (like when the specified file doesn't exist).
		/// </summary>
		const int SPI_SETDESKWALLPAPER = 0x0014;

		/// <summary>
		/// Writes the new system-wide parameter setting to the user profile. 
		/// </summary>
		const int SPIF_UPDATEINIFILE = 0x01;
		/// <summary>
		/// Broadcasts the WM_SETTINGCHANGE message after updating the user profile. 
		/// </summary>
		const int SPIF_SENDCHANGE = 0x02;

		// https://docs.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-systemparametersinfoa#parameters
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		/// <summary>
		/// Wallpaper Style
		/// </summary>
		public enum Style
		{
			None,
			Fill,
			Fit,
			Stretch,
			Tile,
			Center,
			Span,
		}

		public static void ChangeImage(string path)
		{
			// Change and update the wallpaper
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
		}

		public static void ChangeStyle(Style style)
		{
			int wallPaperStyle = 0, tileWallpaper = 0;
			switch (style)
			{
				case Style.Fill: wallPaperStyle = 10; break;
				case Style.Fit: wallPaperStyle = 6; break;
				case Style.Stretch: wallPaperStyle = 2; break;
				case Style.Tile: tileWallpaper = 1; break;
				case Style.Center: break;
				case Style.Span: wallPaperStyle = 22; break;
				default: return;
			}

			var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
			key.SetValue("WallpaperStyle", wallPaperStyle.ToString());
			key.SetValue("TileWallpaper", tileWallpaper.ToString());
		}
	}
}
