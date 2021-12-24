
namespace QuickHealthy.PL.Interfaces.Presenters
{
    public interface IPresenter<T> where T : class
    {
        void LoadModelsToView();
        string Create(T viewModel);
    }
}
