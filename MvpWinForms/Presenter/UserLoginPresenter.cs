using MvpWinForms.Model;
using MvpWinForms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWinForms.Presenter
{
    public class UserLoginPresenter
    {
        private IUserLoginView _UserLoginView;

        public UserLoginPresenter(IUserLoginView UserLoginView)
        {
            _UserLoginView = UserLoginView;
        }
        public bool Login()
        {
            // invoke the model command and configure the view
            UserLogin userLogin = new UserLogin(_UserLoginView.UserName, _UserLoginView.Password);
            bool result = userLogin.Login();
            _UserLoginView.Error = userLogin.Error;
            return result;

        }
    }
}
