using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Liberty.Infrastructure.Configuration
{
	public class AppConfigApplicationSettings : IApplicationSettings
	{
		public const string _connectionStringKey = "ConnectionString";
		
		public string ConnectionString
		{
			get {
				return ConfigurationManager.AppSettings[_connectionStringKey];
			}
		}
	}
}
