using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Renci.SshNet;

namespace RaspCommands.Controllers
{
	public class SSHController 
	{
		public string testConnection(string hostname, string username, string password)
		{
			SshClient sshClient = new SshClient(hostname, username, password);

			try
			{
				sshClient.Connect();

				var testCommand = sshClient.CreateCommand("ls");

				var commandResults = testCommand.Execute();

				sshClient.Disconnect();

				return commandResults;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return "Error connecting to SSH server";
			}
		}
	}
}
