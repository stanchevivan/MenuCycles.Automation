using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesData.Repositories
{
    public interface IRepository
    {
        T Find<T>(int id);
        T Find<T>(string name);
        int SingleInsert<T>(T item);
        void BulkInsert<T>(List<T> list);
        

        //void UpdateItem<T>(T item);
        //void DeleteItem<T>(T item);
    }
}
