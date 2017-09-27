using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public CustomerRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }

        public void SingleInsert(Customer item)
        {
            dbContext.Customers.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Customer> list)
        {
            dbContext.Customers.AddRange(list);
            dbContext.SaveChanges();
        }

        public Customer FindByName(string name)
        {
            return dbContext.Customers.FirstOrDefault(m => m.Name == name);
        }

        public Customer FindById(int id)
        {
            return dbContext.Customers.FirstOrDefault(m => m.CustomerId == id);
        }

        public void DeleteAll(IList<Customer> list)
        {
        }
    }
}
