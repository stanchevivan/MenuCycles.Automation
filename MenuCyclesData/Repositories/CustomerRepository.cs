using System;
using Dapper;
using MenuCyclesData.Helpers;
using MenuCyclesData.DatabaseDataModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using MenuCyclesData.Repositories;

namespace MenuCyclesData.Repositories
{
    public class CustomerRepository : IRepository
    {
        private IDbConnection db = new SqlConnection(DbHelper.connectionString);

        public T Find<T>(int id)
        {
            return this.db.Query<T>("SELECT * FROM Customers WHERE CustomerId = @CustomerId", new { CustomerId = id }).SingleOrDefault();
        }
        public T Find<T>(string name)
        {
            return this.db.Query<T>("SELECT * FROM Customers WHERE Name = @Name", new { Name = name }).SingleOrDefault();
        }
        public int SingleInsert<T>(T item)
        {
            var sql = "INSERT INTO Customers VALUES (@Name, @ExternalId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            return this.db.Query<int>(sql, item).Single();
        }
        public void BulkInsert<T>(List<T> list)
        {
            var sql = "INSERT INTO Customers VALUES (@Name, @ExternalId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
            this.db.Execute(sql, list);
        }
    }
}
