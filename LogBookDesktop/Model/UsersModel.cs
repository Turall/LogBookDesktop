using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookDesktop.Model
{
    class UsersModel
    {
        private string _userName;
        private string _userPassword;

       

        public string Name
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Surname
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }
    }
}
