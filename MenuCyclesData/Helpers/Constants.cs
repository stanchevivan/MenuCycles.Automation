

using System.IO;

namespace MenuCyclesData.Helpers
{
    public static class Constants
    {
        public static string ConnectionString = "Data Source=ie1apiqdb02.cloudapp.net;User ID=SQLA-VenkatSalivendra;Password=hi2o2qcDYD5ipK6DvOM7; Initial Catalog = MenuServiceSodexoQAI;";

        public static string myPrefix = "Ico ";

        public static int customerId = 1;
        public static int userId = 36;
        public static string groupName = "SodexoUp";

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
}
