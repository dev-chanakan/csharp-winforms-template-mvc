using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Services.Messagings
{
    public class RegisterRequest
    {
        /// <summary>
        /// Username 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        public string DisplayName { get; set; }
    }
}
