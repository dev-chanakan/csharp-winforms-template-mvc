using Liberty.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.InterfaceView
{
    public interface IAccountLogOnView : BaseView
    {
        void SetController(AccountLogOnController accountLogOnController);
        void ShowMessageAlert(string title, string message);
        void ClearText();
        string UserName { get; set; }
        string Password { get; set; }     
    }
}
