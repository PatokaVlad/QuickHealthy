
using System.Threading.Tasks;

namespace QuickHealthy.PL.Interfaces.Presenters
{
    public interface IPresenter<T> where T : class
    {
        Task LoadModelsToView();
        Task<string> Create(T viewModel);
    }
}
