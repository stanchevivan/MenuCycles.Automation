using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class CustomerRepository : IRepository<Customers>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public CustomerRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }

        public void SingleInsert(Customers item)
        {
            dbContext.Customers.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Customers> list)
        {
            dbContext.Customers.AddRange(list);
            dbContext.SaveChanges();
        }

        public Customers FindByName(string name)
        {
            return dbContext.Customers.FirstOrDefault(m => m.Name == name);
        }

        public Customers FindById(int id)
        {
            return dbContext.Customers.FirstOrDefault(m => m.CustomerId == id);
        }

        public void DeleteAll(IList<Customers> list)
        {
        }
    }
}
