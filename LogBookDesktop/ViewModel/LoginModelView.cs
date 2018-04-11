using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using LogBookDesktop.Model;

namespace LogBookDesktop.ViewModel
{
    public class LoginModelView : BaseViewModel
    {
        public RelayCommand LoginCommand { get; set; }
        private string _username;
        private string _password;
        private StudentModel _currentUser { get; set; }


        public LoginModelView(MainViewModel mainViewModel) : base(mainViewModel)
        {
            LoginCommand = new RelayCommand(new Action<object>(Login));
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyPropertyChanged("Username");
            }

        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyPropertyChanged("Password");
            }

        }


        public void Login(object obj)
        {
            var loginedUser = MainViewModel.UsersList.FirstOrDefault(s => s.Name == Username && s.Password == Password);
            if (loginedUser != null)
            {
                _currentUser = loginedUser;
                Next();
            }

        }

        public override bool CanNext() => true;

        public override bool CanPrevious() => false;


        protected override void SetNext()
        {
            //next = new StudentAccountViewModel(MainViewModel, _currentUser, this);
        }

        protected override void SetPrevious()
        {

        }

    }
}
