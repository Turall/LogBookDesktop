using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LogBookDesktop.Model
{
   public class StudentModel
    {
        private string _name;
        private string _surname;
        private string _age;
        private string _phone;
        private string _email;
        private string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
