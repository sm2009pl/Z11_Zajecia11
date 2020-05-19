using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Z11_ZajeciaNOGit
{
    public class LoginEventArgs : EventArgs
    {
        public LoginEventArgs(string login, SecureString password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public SecureString Password { get; set; }
    }
}
