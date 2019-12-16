namespace MVVM_template.Base.ViewModel
{
    public interface IContainerViewModel : IViewModel
    {
        IViewModel CurrentViewModel { get; }
    }
}
