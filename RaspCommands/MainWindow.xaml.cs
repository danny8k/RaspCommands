using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RaspCommands.Controllers;

namespace RaspCommands
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			LoadSettings();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var sshController = new SSHController();
			string results = sshController.testConnection(SettingsController.hostname, SettingsController.username, SettingsController.password);

			MessageBox.Show(results);
		}

		// Save settings
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			SettingsController.SaveSettings(hostname.Text, username.Text, password.Text);
		}

		private void LoadSettings()
		{
			hostname.Text = SettingsController.hostname;
			username.Text = SettingsController.username;
			password.Text = SettingsController.password;
		}
	}
}
