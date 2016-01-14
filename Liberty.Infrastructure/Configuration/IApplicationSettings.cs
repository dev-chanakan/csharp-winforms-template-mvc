using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liberty.Infrastructure.Configuration 
{
	public interface IApplicationSettings 
	{	
		string ConnectionString { get; }
	}
}
