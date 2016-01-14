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
    public partial class UserRegisterView : Form, IUserRegisterView
    {
        private AccountLogOnController _accountLogOnController;

        public UserRegisterView()
        {
            InitializeComponent();
        }

        #region IUserRegisterView Implement
        public void SetController(AccountLogOnController accountLogOnController)
        {
            _accountLogOnController = accountLogOnController;
        }

        public void HiddenForm()
        {
            this.Hide();
        }

        public void DisplayForm()
        {
            this.Show();
        }

        /// <summary>
        /// Get Username from view
        /// </summary>
        public string Username
        {
            get { return this.txtUsername.Text; }
            set { this.txtUsername.Text = value; }
        }

        /// <summary>
        /// Get Password from view
        /// </summary>
        public string Password
        {
            get { return this.txtPassword.Text; }
            set { this.txtPassword.Text = value; }
        }

        public string DisplayName
        {
            get { return this.txtDisplayName.Text; }
            set { this.txtDisplayName.Text = value; }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _accountLogOnController.PostSignUp();
        }

        private void UserRegisterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
