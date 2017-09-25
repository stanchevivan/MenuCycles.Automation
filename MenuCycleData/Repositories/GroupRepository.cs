using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public GroupRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }

        public void SingleInsert(Group item)
        {
            dbContext.Groups.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(List<Group> list)
        {
            dbContext.Groups.AddRange(list);
            dbContext.SaveChanges();
        }

        public Group FindByName(string name)
        {
            return dbContext.Groups.FirstOrDefault(m => m.Name == name);
        }

        public Group FindById(int id)
        {
            return dbContext.Groups.FirstOrDefault(m => m.GroupId == id);
        }

        public void DeleteAll(List<Group> list)
        {
            dbContext.Groups.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
