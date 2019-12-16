using MVVM_template.Common;
using MVVM_template.Main;
using System.Windows;

namespace MVVM_template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ServiceProvider.Instance.GetService(typeof(IMainViewModel));
        }
    }
}
