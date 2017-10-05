using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class RecipeIngredientDetails
    {
        public long RecipeId { get; set; }
        public bool? ContainsMilkOrMilkProducts { get; set; }
        public bool? ContainsEggOrEggDerivatives { get; set; }
        public bool? ContainsCerealsThatContainGluten { get; set; }
        public bool? ContainsPeanuts { get; set; }
        public bool? ContainsNutsOrNutTrace { get; set; }
        public bool? ContainsSesameSeedOrSesameSeedProducts { get; set; }
        public bool? ContainsSoya { get; set; }
        public bool? ContainsFishOrFishProducts { get; set; }
        public bool? ContainsCrustaceans { get; set; }
        public bool? ContainsMolluscs { get; set; }
        public bool? ContainsMustardOrMustardProducts { get; set; }
        public bool? ContainsCeleryOrCeleriacProducts { get; set; }
        public bool? ContainsSulphurDioxideOrSulphites { get; set; }
        public bool? ContainsLupinFlourOrLupinProducts { get; set; }
        public bool? ContainsGlutenOrGlutenProducts { get; set; }
        public double? EnergyKjperServing { get; set; }
        public double? EnergyKcalPerServing { get; set; }
        public double? FatPerServing { get; set; }
        public double? SaturatedFatPerServing { get; set; }
        public double? SugarPerServing { get; set; }
        public double? SaltPerServing { get; set; }

        public Recipes Recipe { get; set; }
    }
}
