using System.Data;

namespace MenuCyclesData.Helpers
{
    public class DbHelper
    {
        public static string connectionString = Constants.ConnectionString;

        public static void EnsureOpenConnection(IDbConnection db)
        {
            if (db.State != ConnectionState.Open)
            {
                db.Open();
            }
        }
    }
}
