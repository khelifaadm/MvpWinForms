using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWinForms.View
{
    public interface IUserLoginView
    {
         string UserName { get; set; }

         string Password { get; set; }

         string Error { get; set; }

    }
}
