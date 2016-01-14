using Liberty.Services.Messagings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Services.Interfaces
{
    public interface IUserService
    {
        bool UserValidation(LogOnRequest request);
        void LogOut();
        bool Registration(RegisterRequest request);
        void SetLastLogin(string username);
    }
}
