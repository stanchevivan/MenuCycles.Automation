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
    public class MenuCycleRepository :IRepository
    {
        private IDbConnection db = new SqlConnection(DbHelper.connectionString);

        public T Find<T>(int id)
        {
            return this.db.Query<T>("SELECT * FROM MenuCycles WHERE MenuCycleId = @MenuCycleId", new { MenuCycleId = id }).SingleOrDefault();
        }

        public T Find<T>(string name)
        {
            return this.db.Query<T>("SELECT * FROM MenuCycles WHERE Name = @Name", new { Name = name }).SingleOrDefault();
        }

        public int SingleInsert<T>(T item)
        {
            var sql = "INSERT INTO MenuCycles VALUES (" +
                   "@Name, @Description, @ParentId, @IsPublished, " +
                   "@IsMaster, @IsDeleted, @StartDate, " +
                   "@EndDate, @NonServingDays, @CustomerId, @DateCreatedUtc, " +
                   "@CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);" +
            "SELECT CAST(SCOPE_IDENTITY() as int)";

            return this.db.Query<int>(sql, item).Single();
        }

        public void BulkInsert<T>(List<T> list)
        {
            var sql =
                "INSERT INTO MenuCycles VALUES (" +
                "@Name, @Description, @ParentId, @IsPublished, " +
                "@IsDeleted, @StartDate, " +
                "@EndDate, @NonServingDays, @CustomerId, @DateCreatedUtc, " +
                "@CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId, " +
                "@LocationId, @ReleaseDate, @Status, @IsModifiedLocally);";

            this.db.Execute(sql, list);
        }
        public List<T> BulkInsertAndReturn<T>(List<T> list)
        {
            var sql =
                "INSERT INTO MenuCycles VALUES (" +
                "@Name, @Description, @ParentId, @IsPublished, " +
                "@IsDeleted, @StartDate, " +
                "@EndDate, @NonServingDays, @CustomerId, @DateCreatedUtc, " +
                "@CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId, " +
                "@LocationId, @ReleaseDate, @Status, @IsModifiedLocally);";

            this.db.Execute(sql, list);

            return GetAll<T>();
        }
        public List<T> GetAll<T>()
        {
            return this.db.Query<T>("SELECT * FROM MenuCycles WHERE Name LIKE '" + Constants.myPrefix + "%'").ToList();
        }
        public List<T> GetAllModified<T>()
        {
            return this.db.Query<T>("SELECT * FROM MenuCycles WHERE Name LIKE 'Seed % Updated'").ToList();
        }
        public void DeleteAll()
        {
            this.db.Execute("DELETE FROM MenuCycles WHERE Name LIKE 'Seed%'"); //Seeded Menu Cycles
            DeleteCreatedMenuCycles(); //Created by CreateMenuCycles webtest
        }

        public void DeleteCreatedMenuCycles()
        {
            this.db.Execute("DELETE FROM MenuCycleGroups where MenuCycleId IN (SELECT MenuCycleId from MenuCycles where name like '%Perf Menu%')"); 
            this.db.Execute("DELETE FROM MenuCycles WHERE Name LIKE 'Perf Menu%'"); 
        }

        public void Update<T>(List<T> list)
        {
            var sql =
                "UPDATE MenuCycles SET " +
                "Name = @Name, " +
                "Description = @Description " +
                "WHERE MenuCycleId = @MenuCycleId";

            this.db.Execute(sql, list);
        }

        public void DeleteAllById(List<string> ids)
        {
            this.db.Execute("DELETE FROM MenuCycleItems WHERE MenuCycleId IN @MenuCycleId", new { MenuCycleId = ids.ToArray() });
            this.db.Execute("DELETE FROM MenuCycleGroups WHERE MenuCycleId IN @MenuCycleId", new { MenuCycleId = ids.ToArray() });
            this.db.Execute("DELETE FROM MenuCycles WHERE MenuCycleId IN @MenuCycleId", new { MenuCycleId = ids.ToArray() });
        }

        public void DeleteAllByName(List<string> names)
        {
            this.db.Execute("DELETE FROM MenuCycleItems WHERE Name IN @Name", new { Name = names.ToArray() });
            this.db.Execute("DELETE FROM MenuCycleGroups WHERE Name IN @Name", new { Name = names.ToArray() });
            this.db.Execute("DELETE FROM MenuCycles WHERE Name IN @Name", new { Name = names.ToArray() });
        }
    }
}
