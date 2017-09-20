using System.Collections.Generic;

namespace MenuCyclesData.Repositories
{
    public interface IRepository
    {
        T Find<T>(int id);
        T Find<T>(string name);
        int SingleInsert<T>(T item);
        void BulkInsert<T>(List<T> list);
    }
}
