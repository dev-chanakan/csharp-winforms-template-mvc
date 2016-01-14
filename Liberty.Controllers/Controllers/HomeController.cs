using Liberty.Controllers.InterfaceView;
using Liberty.Infrastructure.Helpers;
using Liberty.Infrastructure.UnitOfWork;
using Liberty.Models.Users;
using Liberty.Services.Interfaces;
using Liberty.Services.Messagings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.Controllers
{
    public class HomeController
    {
        //IAccountLogOnView _accountLogOnView;
        //private readonly IUserService _userService;

        //public HomeController(
        //    IAccountLogOnView accountLogOnView,
        //    IUserService userService)
        //{
        //    _accountLogOnView = accountLogOnView;
        //    _userService = userService;
        //    accountLogOnView.SetController(this);
        //}

        //public void AccountLogOn()
        //{
        //    UserRequest request = new UserRequest();
        //    request.UserName = _accountLogOnView.UserName;
        //    request.Password = CryptoHelper.Encrypt(_accountLogOnView.Password);

        //    bool validate = _userService.UserValidation(request);
        //    if (validate)
        //    {
        //        //Login Success.

        //    }
        //    else
        //    {
        //        //Login Fail.
        //        _accountLogOnView.ShowMessageAlert("Systems", "Login Fail !");
        //    }
        //}
    }
}
