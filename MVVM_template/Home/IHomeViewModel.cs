using MVVM_template.Base.ViewModel;
using System;

namespace MVVM_template.Home
{
    public interface IHomeViewModel : IViewModel
    {
        event EventHandler Started;
        event EventHandler Succeeded;

        void Start();
    }
}
