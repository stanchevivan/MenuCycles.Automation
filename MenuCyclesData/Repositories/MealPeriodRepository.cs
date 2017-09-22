﻿using System;
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
    public class MealPeriodRepository : IRepository
    {
        private IDbConnection db = new SqlConnection(DbHelper.connectionString);
        public T Find<T>(int id)
        {
            return this.db.Query<T>("SELECT * FROM MealPeriods WHERE MealPeriodId = @MealPeriodId", new { MealPeriodId = id }).SingleOrDefault();
        }
        public T Find<T>(string name)
        {
            return this.db.Query<T>("SELECT * FROM MealPeriods WHERE Name = @Name", new { Name = name }).SingleOrDefault();
        }
        public int SingleInsert<T>(T item)
        {
            var sql = "INSERT INTO MealPeriods VALUES (@ExternalId, @Name, @CustomerId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            return this.db.Query<int>(sql, item).Single();
        }
        public void BulkInsert<T>(List<T> list)
        {
            var sql = "INSERT INTO MealPeriods VALUES (@ExternalId, @Name, @CustomerId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
            this.db.Execute(sql, list);
        }
        public List<T> BulkInsertAndReturn<T>(List<T> list)
        {
            var sql = "INSERT INTO MealPeriods VALUES (@ExternalId, @Name, @CustomerId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
            this.db.Execute(sql, list);

            return GetAll<T>();
        }
        public List<T> GetAll<T>()
        {
            return this.db.Query<T>("SELECT * FROM MealPeriods WHERE Name LIKE '" + Constants.myPrefix + "%'").ToList();
        }
        public void DeleteAll()
        {
            this.db.Execute("DELETE FROM MealPeriods WHERE Name LIKE 'Seed%'");
        }
    }
}
