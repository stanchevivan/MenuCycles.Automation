using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class UserRepository : IRepository<Users>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public UserRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }
        public void SingleInsert(Users item)
        {
            dbContext.Users.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Users> list)
        {
            dbContext.Users.AddRange(list);
            dbContext.SaveChanges();
        }

        public Users FindByName(string name)
        {
            return dbContext.Users.FirstOrDefault(m => m.Name == name);
        }

        public Users FindById(int id)
        {
            return dbContext.Users.FirstOrDefault(m => m.UserId == id);
        }

        public void DeleteAll(IList<Users> list)
        {
            dbContext.Users.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
