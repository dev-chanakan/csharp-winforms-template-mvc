using Liberty.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.InterfaceView
{
    public interface IUserRegisterView : BaseView
    {
        void SetController(AccountLogOnController accountLogOnController);
        string Username { get; set; }
        string Password { get; set; }
        string DisplayName { get; set; }
    }
}
