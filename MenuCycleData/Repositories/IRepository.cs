using System.Collections.Generic;

namespace MenuCycleData.Repositories
{
    public interface IRepository<T>
    {
        void SingleInsert(T item);
        void BulkInsert(List<T> list);
        T FindById(int id);
        T FindByName(string name);
        void DeleteAll(List<T> list);
    }
}
