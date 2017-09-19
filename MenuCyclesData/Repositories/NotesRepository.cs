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
    public class NotesRepository : IRepository
    {
        private IDbConnection db = new SqlConnection(DbHelper.connectionString);
        public T Find<T>(int id)
        {
            return this.db.Query<T>("SELECT * FROM Notes WHERE NoteId = @NoteId", new { NoteId = id }).SingleOrDefault();
        }
        public T Find<T>(string content)
        {
            return this.db.Query<T>("SELECT * FROM Notes WHERE Content = @Content", new { Content = content }).SingleOrDefault();
        }
        public int SingleInsert<T>(T item)
        {
            var sql = "INSERT INTO Notes VALUES (@Content, @Date, @MenuCycleId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            return this.db.Query<int>(sql, item).Single();
        }
        public void BulkInsert<T>(List<T> list)
        {
            var sql = "INSERT INTO Notes VALUES (@Content, @Date, @MenuCycleId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
            this.db.Execute(sql, list);
        }
        public List<T> BulkInsertAndReturn<T>(List<T> list)
        {
            var sql = "INSERT INTO Notes VALUES (@Content, @Date, @MenuCycleId, @DateCreatedUtc, @CreatedByExternalId, @DateUpdatedUtc , @UpdatedByExternalId);";
            this.db.Execute(sql, list);

            return GetAll<T>();
        }
        public List<T> GetAll<T>()
        {
            return this.db.Query<T>("SELECT * FROM Notes WHERE Content LIKE 'Seed%'").ToList();
        }
        public void DeleteAll()
        {
            this.db.Execute("DELETE FROM Notes WHERE Content LIKE 'Seed%'");
        }
    }
}
