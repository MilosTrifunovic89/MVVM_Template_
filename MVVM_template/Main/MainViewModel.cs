using MVVM_template.Base.ViewModel;
using MVVM_template.Home;
using System;

namespace MVVM_template.Main
{
    public class MainViewModel : ContainerViewModelBase, IMainViewModel
    {
        private IHomeViewModel _homeViewModel;

        public MainViewModel(IHomeViewModel homeViewModel)
        {
            _homeViewModel = homeViewModel;
            _homeViewModel.Started += homeViewModel_Started;
            _homeViewModel.Succeeded += homeViewModel_Succeeded;

            setHomePageCurrent();
        }

        private void homeViewModel_Succeeded(object sender, EventArgs e)
        {

        }

        private void homeViewModel_Started(object sender, EventArgs e)
        {
            CurrentViewModel = _homeViewModel;
        }

        private void setHomePageCurrent()
        {
            CurrentViewModel = null;
            _homeViewModel.Start();
        }
    }
}
