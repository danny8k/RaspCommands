using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspCommands.Controllers
{
	public static class SettingsController
	{
		public static void SaveSettings(string hostname, string username, string password)
		{
			Properties.Settings.Default["hostname"] = hostname;
			Properties.Settings.Default["username"] = username;
			Properties.Settings.Default["password"] = password;
			Properties.Settings.Default.Save();
		}

		public static string hostname => Properties.Settings.Default["hostname"].ToString();
		public static string username => Properties.Settings.Default["username"].ToString();
		public static string password => Properties.Settings.Default["password"].ToString();
	}
}
