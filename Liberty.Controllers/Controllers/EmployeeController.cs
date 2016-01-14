using Liberty.Controllers.InterfaceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Controllers.Controllers
{
    public class EmployeeController
    {
        IEmployeeView _employeeView;

        public EmployeeController(
            IEmployeeView employeeView)
        {
            _employeeView = employeeView;
            employeeView.SetController(this);
        }

        public void Index()
        {
            _employeeView.ClearList();
            _employeeView.DisplayForm();
        }
    }
}
