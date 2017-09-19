

using System.IO;

namespace MenuCyclesData.Helpers
{
    public static class Constants
    {
        public static string baseUrl = "https://api-dev.fourth.com/prelive/api/menuservice";
        public static string csvBaseFolder = @"ApiPerformanceTests\CsvFiles";

        public static string jsonBaseFolder = @"ApiPerformanceTests\Json";
        public static string rootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static DataBaseActions DatabaseAction = DataBaseActions.NONE;

        public static string ConnectionString = "Data Source=ie1apiqdb02.cloudapp.net;User ID=SQLA-VenkatSalivendra;Password=hi2o2qcDYD5ipK6DvOM7; Initial Catalog = MenuServiceSodexoQAI;";

        public static int customerId = 1;
        public static int userId = 36;

        public static int baseValue                         = 1; //Users
            public static int groupBase                         = 1;
            public static int locationBase                      = 1;
                public static int menuCycleBase                 = 5;
                    public static int mealPeriodBase            = 12;
                        public static int recipePerMenu         = 5;
                        public static int recipePerMealPeriod   = 5;
                        public static int menuBase              = 1;
                    public static int noteBase                  = 1;

            public static int nonServingDay                     = 7; //1 = Monday, 2 = Tuesday...
            public static int mealPeriodsPerDay                 = 3;
            public static int scheduleWeeks                     = 1;

    }

    public enum DataBaseActions
    {
        NONE = 1,
        RESET = 2,
        SEED = 3
    }
}
