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
using Liberty.Infrastructure.Helpers;

namespace Liberty.UI.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        private EmployeeController _employeeController;

        public EmployeeView()
        {
            InitializeComponent();
        }

        #region IEmployeeView Implement
        public void SetController(EmployeeController employeeController)
        {
            _employeeController = employeeController;
        }

        public void HiddenForm()
        {
            this.Hide();
        }

        public void DisplayForm()
        {
            this.Show();
        }

        public void ClearList()
        {
            // Define columns in grid
            this.listEmployee.Columns.Clear();

            this.listEmployee.Columns.Add("Id", 150, HorizontalAlignment.Left);
            this.listEmployee.Columns.Add("First Name", 150, HorizontalAlignment.Left);
            this.listEmployee.Columns.Add("Last Name", 150, HorizontalAlignment.Left);
            this.listEmployee.Columns.Add("Department", 150, HorizontalAlignment.Left);
            this.listEmployee.Columns.Add("Sex", 50, HorizontalAlignment.Left);

            // Add rows to grid
            this.listEmployee.Items.Clear();
        }
        #endregion

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            this.RemoveControlBar();
        }  
    }
}
