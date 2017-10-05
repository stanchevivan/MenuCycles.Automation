using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Groups = new HashSet<Groups>();
            Locations = new HashSet<Locations>();
            MealPeriods = new HashSet<MealPeriods>();
            MenuCycles = new HashSet<MenuCycles>();
            Menus = new HashSet<Menus>();
            RecipeLocationPrices = new HashSet<RecipeLocationPrices>();
            Recipes = new HashSet<Recipes>();
            Tariffs = new HashSet<Tariffs>();
            Users = new HashSet<Users>();
        }

        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public ICollection<Groups> Groups { get; set; }
        public ICollection<Locations> Locations { get; set; }
        public ICollection<MealPeriods> MealPeriods { get; set; }
        public ICollection<MenuCycles> MenuCycles { get; set; }
        public ICollection<Menus> Menus { get; set; }
        public ICollection<RecipeLocationPrices> RecipeLocationPrices { get; set; }
        public ICollection<Recipes> Recipes { get; set; }
        public ICollection<Tariffs> Tariffs { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
