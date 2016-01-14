using Liberty.Controllers.Controllers;
using Liberty.Controllers.InterfaceView;
using Liberty.Infrastructure.UnitOfWork;
using Liberty.Models.Users;
using Liberty.Repository.NHibernate;
using Liberty.Repository.NHibernate.Repositories;
using Liberty.Services.Implementations;
using Liberty.Services.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberty.UI.Views
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Register Views
            AccountLogOnView startView = new AccountLogOnView();
            startView.Visible = false;

            HomeView homeView = new HomeView();
            homeView.Visible = false;

            EmployeeView employeeView = new EmployeeView();
            employeeView.MdiParent = homeView;
            homeView.Visible = false;

            UserRegisterView userRegisterView = new UserRegisterView();
            userRegisterView.Visible = false;
            #endregion

            #region Register Repository & Service
            // Nhibernate
            IUnitOfWork uow = new NHUnitOfWork();
            IUserRepository userRepository = new UserRepository(uow);

            IUserService userService = new UserService(
                userRepository, 
                uow);
            #endregion

            // manual injection view to main-controller
            AccountLogOnController AccountLogOnController = new AccountLogOnController(
                startView, 
                homeView,
                employeeView,
                userRegisterView,
                userService);

            startView.ShowDialog();
        }
    }
}
