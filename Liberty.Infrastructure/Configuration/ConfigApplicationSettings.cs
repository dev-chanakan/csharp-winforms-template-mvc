using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Liberty.Infrastructure.Configuration 
{
	public class ConfigApplicationSettings : IApplicationSettings 
	{
		private const string _connectionStringKey = "ApplicationServices";


		public string ConnectionString
		{
			get { return ConfigurationManager.ConnectionStrings[_connectionStringKey].ConnectionString; }
		}

	}
}
