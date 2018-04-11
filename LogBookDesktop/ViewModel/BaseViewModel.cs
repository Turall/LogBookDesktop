using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBookDesktop.Model;

namespace LogBookDesktop.ViewModel
{
    public abstract class BaseViewModel : Notify
    {
        protected readonly MainViewModel MainViewModel;
        public BaseViewModel next { get; protected set; }
        public BaseViewModel previous { get; protected set; }

        public BaseViewModel(MainViewModel main)
        {
            MainViewModel = main;
        }

        public BaseViewModel(MainViewModel main, BaseViewModel previous)
        {
            MainViewModel = main;
            this.previous = previous;
        }

        public void Next()
        {
            if (CanNext())
            {
                SetNext();
                if (next != null)
                    MainViewModel.Next(next);
            }
        }

        public void Previous()
        {
            if (CanPrevious())
            {
                SetPrevious();
                if (previous != null)
                {
                    MainViewModel.Previous(previous);
                }
            }

        }

        public abstract bool CanNext();
        public abstract bool CanPrevious();
        protected abstract void SetNext();

        protected abstract void SetPrevious();
    }
}
