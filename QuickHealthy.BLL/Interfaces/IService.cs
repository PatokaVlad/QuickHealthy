using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        void Create(T DTO);
        T Get(int? id);
        IEnumerable<T> GetAll();
    }
}
