using System.Collections.Generic;

namespace MenuCycle.Data.Repositories
{
    public interface IRepository<T>
    {
        void SingleInsert(T item);
        void BulkInsert(IList<T> list);
        T FindById(int id);
        T FindByName(string name);
        void DeleteAll(IList<T> list);
    }
}
