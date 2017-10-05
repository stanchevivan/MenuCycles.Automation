using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class GroupRepository : IRepository<Groups>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public GroupRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }

        public void SingleInsert(Groups item)
        {
            dbContext.Groups.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Groups> list)
        {
            dbContext.Groups.AddRange(list);
            dbContext.SaveChanges();
        }

        public Groups FindByName(string name)
        {
            return dbContext.Groups.FirstOrDefault(m => m.Name == name);
        }

        public Groups FindById(int id)
        {
            return dbContext.Groups.FirstOrDefault(m => m.GroupId == id);
        }

        public void DeleteAll(IList<Groups> list)
        {

        }
    }
}
