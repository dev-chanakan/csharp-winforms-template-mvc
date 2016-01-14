using Liberty.Controllers.Controllers;
using Liberty.Controllers.InterfaceView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberty.UI.Views
{
    public partial class HomeView : Form, IHomeView
    {
        private AccountLogOnController _accountLogOnController;
        private EmployeeController _employeeController;

        public HomeView()
        {
            InitializeComponent();
        }

        #region IHomeView Implement
        public void SetController(
            AccountLogOnController accountLogOnController,
            EmployeeController employeeController)
        {
            _accountLogOnController = accountLogOnController;
            _employeeController = employeeController;
        }

        public void HiddenForm()
        {
            this.Hide();
        }

        public void DisplayForm()
        {
            this.ShowDialog();
        }
        #endregion

        private void HomeView_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _accountLogOnController.AccountLogOff();
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _employeeController.Index();
        }
    }
}
