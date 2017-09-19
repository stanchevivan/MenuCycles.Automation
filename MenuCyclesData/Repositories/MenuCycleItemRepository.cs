using System;
using Dapper;
using MenuCyclesData.Helpers;
using MenuCyclesData.DatabaseDataModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using MenuCyclesData.Repositories;

namespace MenuCyclesData.Repositories
{
    public class MenuCycleItemRepository
    {
        private IDbConnection db = new SqlConnection(DbHelper.connectionString);

        public List<T> BulkInsertAndReturn<T>(List<T> list)
        {
            var sql =
               "INSERT INTO MenuCycleItems VALUES (" +
                    "@Day, @Order, @ParentId, @MenuId, " +
                    "@MenuName,@Course, @MenuCycleId, " +
                    "@RecipeId, @MenuCycleItemType, " +
                    "@MenuType, @MealPeriodId, " +
                    "@DateCreatedUtc, @CreatedByExternalId, " +
                    "@DateUpdatedUtc,@UpdatedByExternalId)";
            this.db.Execute(sql, list);

            return GetAll<T>();
        }
        public int SingleInsert<T>(T item)
        {
            var sql = "INSERT INTO MenuCycleItems VALUES (" +
                    "@Day, @Order, @ParentId, @MenuId, " +
                    "@MenuName,@Course, @MenuCycleId, " +
                    "@RecipeId, @MenuCycleItemType, " +
                    "@MenuType, @MealPeriodId, " +
                    "@DateCreatedUtc, @CreatedByExternalId, " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            return this.db.Query<int>(sql, item).Single();
        }

        public void Update<T>(List<T> list)
        {
            var sql = "UPDATE MenuCycleItems SET ParentId = @ParentId WHERE MenuCycleItemId = @MenuCycleItemId";
            this.db.Execute(sql, list);
        }
        public List<T> GetAll<T>()
        {
            return this.db.Query<T>("SELECT * FROM MenuCycleItems WHERE Course LIKE 'Seed%'").ToList();
        }
        public void DeleteAdditionalItems()
        {
            this.db.Execute("DELETE FROM MenuCycleItems WHERE CreatedByExternalId LIKE 'Seed%'");
        }
    }
}
