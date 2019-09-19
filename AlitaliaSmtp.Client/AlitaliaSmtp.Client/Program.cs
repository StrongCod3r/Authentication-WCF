using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlitaliaSmtp.Client.Service;
using System.Configuration;

namespace AlitaliaSmtp.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceSmtpClient clientEmail = new ServiceSmtpClient();

			// Authentication
			clientEmail.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["user"];
			clientEmail.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["pass"];

			try
			{
				// Test
				Console.WriteLine(clientEmail.GetData(5555));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("-----------------------------------------------");
			Console.ReadLine();
		}
	}
}
