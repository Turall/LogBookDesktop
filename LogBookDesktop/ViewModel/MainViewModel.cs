using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using LogBookDesktop.Model;

namespace LogBookDesktop.ViewModel
{
    public  class MainViewModel : Notify
    {
        public ObservableCollection<StudentModel> UsersList { get; set; }
        private BaseViewModel _baseViewModel;
        private string _title;

        public MainViewModel()
        {
            UsersList = new ObservableCollection<StudentModel>
            {
                new StudentModel
                {
                    Name = "Tural",
                    Surname = "Muradov",
                    Age = "28",
                    Email = "asdasdasd",
                    Phone = "234234234",
                    Password = "123"
                }
            };
           
            ViewModel = new LoginModelView(this);
        }


        public BaseViewModel ViewModel
        {
            get => _baseViewModel;
            set
            {
                _baseViewModel = value;
                NotifyPropertyChanged("ViewModel");
            }
        }

        //public string Title
        //{
        //    get => _title;
        //    set
        //    {
        //        _title = value;
        //        NotifyPropertyChanged("Title");
        //    }
        //}

        public EventHandler Close;



        public void Next(BaseViewModel nextState)
        {

            ViewModel = nextState;
        }

        public void Previous(BaseViewModel previousState)
        {
            ViewModel = previousState;
        }
    }
}
