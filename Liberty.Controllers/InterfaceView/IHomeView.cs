using Liberty.Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.InterfaceView
{
    public interface IHomeView : BaseView
    {
        void SetController(AccountLogOnController accountLogOnController, EmployeeController employeeController);
    }
}
