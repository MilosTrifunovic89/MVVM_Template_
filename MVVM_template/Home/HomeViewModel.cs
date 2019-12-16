using MVVM_template.Base.ViewModel;
using System;

namespace MVVM_template.Home
{
    public enum HomeViewModelResultType
    {

    }

    public class HomeViewModel : ViewModelBase, IHomeViewModel
    {
        public event EventHandler Started;
        public event EventHandler Succeeded;

        public HomeViewModel()
        {
        }

        public void Start()
        {
            Started?.Invoke(this, new EventArgs());
        }
    }
}
