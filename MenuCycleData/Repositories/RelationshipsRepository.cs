using System;
using System.Collections.Generic;
using System.Linq;


namespace MenuCycleData.Repositories
{
    public class RelationshipsRepository
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public RelationshipsRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }

        public void InsertMenuCycleGroup(MenuCycleGroup item)
        {
            dbContext.MenuCycleGroups.Add(item);
            dbContext.SaveChanges();
        }

        public void InsertGroupRecipe(GroupRecipe item)
        {
            dbContext.GroupRecipes.Add(item);
            dbContext.SaveChanges();
        }

        //public void InsertUserLocation(dynamic item)
        //{

        //    var sql = "INSERT INTO UserLocations VALUES " +
        //                "(@UserId, @LocationId, " +
        //                "@DateCreatedUtc, @CreatedByExternalId, " +
        //                "@DateUpdatedUtc , @UpdatedByExternalId);"; 

        //    this.db.Execute(sql,
        //                    new
        //                    {
        //                        UserId = item.id1,
        //                        LocationId = item.id2,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId
        //                    }
        //                    );
        //}
        //public void InsertGroupUser(dynamic item)
        //{
        //    var sql = "INSERT INTO GroupUsers VALUES (@GroupId, @UserId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
        //    this.db.Execute(sql,
        //                    new
        //                    {
        //                        GroupId = item.id1,
        //                        UserId = item.id2,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId
        //                    }
        //                    );
        //}
        
        //public void InsertGroupMenu(dynamic item)
        //{
        //    var sql = "INSERT INTO GroupMenus VALUES (@GroupId, @MenuId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";

        //    this.db.Execute(sql,
        //                    new
        //                    {
        //                        GroupId = item.id1,
        //                        MenuId = item.id2,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId
        //                    }
        //                    );
        //}
        //public void InsertGroupLocation(dynamic item)
        //{
        //    var sql = "INSERT INTO GroupLocations VALUES (@GroupId, @LocationId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";

        //    this.db.Execute(sql, 
        //                    new
        //                    {
        //                        GroupId = item.id1,
        //                        LocationId = item.id2,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId
        //                    }
        //                    );
        //}
        //public void InsertMenuCycleLocation(dynamic item)
        //{
        //    var sql = "INSERT INTO MenuCycleLocations VALUES (@MenuCycleId, @LocationId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";

        //    this.db.Execute(sql,
        //                    new
        //                    {
        //                        MenuCycleId = item.id1,
        //                        LocationId = item.id2,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId
        //                    }
        //                    );

        //}
        //public void InsertMenuRecipe(dynamic item)
        //{
        //    var sql = "INSERT INTO MenuRecipes VALUES (@MenuId, @RecipeId, @Course, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";

        //    this.db.Execute(sql,
        //                    new
        //                    {
        //                        MenuId = item.id1,
        //                        RecipeId = item.id2,
        //                        Course = (string)item.Course,
        //                        DateCreatedUtc = item.DateCreatedUtc,
        //                        CreatedByExternalId = item.CreatedByExternalId,
        //                        DateUpdatedUtc = item.DateUpdatedUtc,
        //                        UpdatedByExternalId = item.UpdatedByExternalId,
        //                    }
        //                    );

        //}
        //public void DeleteAll()
        //{
        //    //GroupUsers
        //    //GroupRecipes
        //    //GroupMenus
        //    //GroupLocations
        //    //MenuCycleGroups
        //    List<Group> gpList = new GroupRepository().GetAll<Group>();
        //    foreach (Group item in gpList)
        //    {
        //        this.db.Execute("DELETE FROM GroupUsers WHERE GroupId = @Id", new { Id = item.GroupId });
        //        this.db.Execute("DELETE FROM GroupRecipes WHERE GroupId = @Id", new { Id = item.GroupId });
        //        this.db.Execute("DELETE FROM GroupMenus WHERE GroupId = @Id", new { Id = item.GroupId });
        //        this.db.Execute("DELETE FROM GroupLocations WHERE GroupId = @Id", new { Id = item.GroupId });
        //        this.db.Execute("DELETE FROM MenuCycleGroups WHERE GroupId = @Id", new { Id = item.GroupId });

        //    }


        //    //MenuCycleLocations
        //    //MenuCycleItems
        //    List<MenuCycle> mcList = new MenuCycleRepository().GetAll<MenuCycle>();
        //    foreach (MenuCycle item in mcList)
        //    {
        //        this.db.Execute("DELETE FROM MenuCycleLocations WHERE MenuCycleId = @Id", new { Id = item.MenuCycleId });
        //        this.db.Execute("DELETE FROM MenuCycleItems WHERE MenuCycleId = @Id", new { Id = item.MenuCycleId });
                
        //    }

        //    //UserLocations
        //    List<Location> lList = new LocationRepository().GetAll<Location>();
        //    foreach (Location item in lList)
        //    {
        //        this.db.Execute("DELETE FROM UserLocations WHERE LocationId = @Id", new { Id = item.LocationId });
        //    }


        //    //MenuRecipes
        //    List<Recipe> rList = new RecipeRepository().GetAll<Recipe>();
        //    foreach (Recipe item in rList)
        //    {
        //        this.db.Execute("DELETE FROM MenuRecipes WHERE RecipeId = @Id", new { Id = item.RecipeId });
        //    }

        //}

    }
}
