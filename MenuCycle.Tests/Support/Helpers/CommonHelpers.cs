﻿using System;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;

namespace MenuCycle.Tests
{
    public static class CommonHerlpers
    {
        public static string GetRandomValueExcluding(string previousValue)
        {
            Random rnd = new Random();
            string randomNumber;

            int counter = 0;

            do
            {
                randomNumber = rnd.Next(0, 99).ToString();

                if (randomNumber != previousValue)
                {
                    return randomNumber;
                }
                counter++;
            }
            while (counter < 100);

            throw new Exception("Sorry, you are very unlucky. Terminating endless loop!");
        }

        internal static string GetRandomDecimalValue(int min, int max)
        {
            Random rnd = new Random();
            string randomNumber;
            string fractional;

            // Substract '1' from {max}, because of the addition of fractional part
            randomNumber = rnd.Next(min, max - 1).ToString();
            fractional = rnd.Next(10, 99).ToString();

            return randomNumber + '.' + fractional;
        }

        internal static string GetRandomIntValue(int min, int max)
        {
            Random rnd = new Random();
            string randomNumber;

            // Substract '1' from {max}, because of the addition of fractional part
            randomNumber = rnd.Next(min, max - 1).ToString();
            return randomNumber;
        }

        public static string ValueForFieldInRecipeRow(string field, RecipeRow row) =>

            field switch
            {
                "PlannedQuantity" => row.PlannedQuantity,
                "CostPerUnit" => row.CostPerUnit,
                "TotalCosts" => row.TotalCosts,
                "TariffType" => row.TariffType,
                "PriceModel" => row.PriceModel,
                "Target" => row.Target,
                "TaxPercentage" => row.TaxPercentage,
                "SellPrice" => row.SellPrice,
                "Revenue" => row.Revenue,
                "ActualGP" => row.ActualGP,
                _ => null
            };
    }
}