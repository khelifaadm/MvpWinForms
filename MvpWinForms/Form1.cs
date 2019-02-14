using MvpWinForms.Presenter;
using MvpWinForms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvpWinForms
{
    public partial class Form1 : Form, IUserLoginView
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region View
        public string UserName { get => txtUser.Text; set => txtUser.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string Error { get => labMessage.Text; set => labMessage.Text = value; }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginPresenter presenter = new UserLoginPresenter(this);
            presenter.Login();
        }
    }
}
