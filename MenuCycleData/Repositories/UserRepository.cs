using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public UserRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }
        public void SingleInsert(User item)
        {
            dbContext.Users.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(List<User> list)
        {
            dbContext.Users.AddRange(list);
            dbContext.SaveChanges();
        }

        public User FindByName(string name)
        {
            return dbContext.Users.FirstOrDefault(m => m.Name == name);
        }

        public User FindById(int id)
        {
            return dbContext.Users.FirstOrDefault(m => m.UserId == id);
        }

        public void DeleteAll(List<User> list)
        {
            dbContext.Users.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
