using Liberty.Controllers.Controllers;
using Liberty.Controllers.InterfaceView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberty.UI.Views
{
    public partial class AccountLogOnView : Form, IAccountLogOnView
    {
        AccountLogOnController _accountLogOnController;

        public AccountLogOnView()
        {
            InitializeComponent();
        }

        #region IAccountLogOnView Implement
        /// <summary>
        /// Register Controller
        /// </summary>
        /// <param name="accountLogOnController"></param>
        public void SetController(AccountLogOnController accountLogOnController)
        {
            _accountLogOnController = accountLogOnController;
        }

        /// <summary>
        /// Get Username from view
        /// </summary>
        public string UserName
        {
            get { return this.txtUserName.Text; }
            set { this.txtUserName.Text = value; }
        }

        /// <summary>
        /// Get Password from view
        /// </summary>
        public string Password
        {
            get { return this.txtPassword.Text; }
            set { this.txtPassword.Text = value; }
        }

        public void HiddenForm()
        {
            this.Hide();
        }

        public void DisplayForm()
        {
            this.Show();
        }

        public void ShowMessageAlert(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        public void ClearText()
        {
            txtUserName.Text = "Username";
            txtPassword.Text = "Password";
            txtPassword.PasswordChar = '\0';
            SetTextForeColor(Color.LightGray);
        }
        #endregion

        #region Event Text Focus
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Username" || tb.Text == "Password")
            {
                if (tb.Text == "Password")
                    tb.PasswordChar = '*';

                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.PasswordChar = '\0';
                tb.Text = tb.Name == "txtUserName" ? "Username" : "Password";
                tb.ForeColor = Color.LightGray;
            }
        }
        #endregion

        private void AccountLogOnView_Load(object sender, EventArgs e)
        {
            txtUserName.GotFocus += new EventHandler(this.TextGotFocus);
            txtUserName.LostFocus += new EventHandler(this.TextLostFocus);
            txtPassword.GotFocus += new EventHandler(this.TextGotFocus);
            txtPassword.LostFocus += new EventHandler(this.TextLostFocus);

            this.MinimumSize = new System.Drawing.Size(400, 500);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _accountLogOnController.AccountLogOn();
        }
 
        private void SetTextForeColor(Color color)
        {
            txtUserName.ForeColor = color;
            txtPassword.ForeColor = color;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _accountLogOnController.AccountLogOn();
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _accountLogOnController.GetSignUp();
        }       
    }
}
