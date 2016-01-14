using Liberty.Controllers.InterfaceView;
using Liberty.Infrastructure.Helpers;
using Liberty.Services.Interfaces;
using Liberty.Services.Messagings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.Controllers
{
    public class AccountLogOnController
    {
        IAccountLogOnView _accountLogOnView;
        IHomeView _homeView;
        IUserRegisterView _userRegisterView;

        private readonly IUserService _userService;

        public AccountLogOnController(
            IAccountLogOnView accountLogOnView,
            IHomeView homeView,
            IEmployeeView employeeView,
            IUserRegisterView userRegisterView,
            IUserService userService)
        {
            _accountLogOnView = accountLogOnView;
            _userService = userService;
            _homeView = homeView;
            _userRegisterView = userRegisterView;

            accountLogOnView.SetController(this);

            EmployeeController employeeController = new EmployeeController(employeeView);
            homeView.SetController(this, employeeController);
            userRegisterView.SetController(this);
        }

        public void AccountLogOn()
        {
#if DEBUG
            _accountLogOnView.UserName = "admin";
            _accountLogOnView.Password = "admin";
#else
#endif
            LogOnRequest request = new LogOnRequest();
            request.UserName = _accountLogOnView.UserName;
            request.Password = CryptoHelper.Encrypt(_accountLogOnView.Password);

            bool validate = _userService.UserValidation(request);
            if (validate)
            {
                _userService.SetLastLogin(request.UserName);

                //Login Success.
                _accountLogOnView.HiddenForm();
                _homeView.DisplayForm();
            }
            else
            {
                //Login Fail.
                _accountLogOnView.ShowMessageAlert("Systems", "Login Fail !");
            }
        }

        public void AccountLogOff()
        {
            _homeView.HiddenForm();

            _accountLogOnView.ClearText();
            _accountLogOnView.DisplayForm();
        }

        public void GetSignUp()
        {
            _userRegisterView.DisplayForm();
        }

        public void PostSignUp()
        {
            RegisterRequest request = new RegisterRequest();
            request.DisplayName = _userRegisterView.DisplayName;
            request.UserName = _userRegisterView.Username;
            request.Password = CryptoHelper.Encrypt(_userRegisterView.Password);

            //Sing-Up success.
            if (_userService.Registration(request))
            {
                _userRegisterView.HiddenForm();
            }
        }
    }
}
