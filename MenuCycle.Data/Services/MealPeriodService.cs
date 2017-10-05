using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Generators;
using MenuCycle.Data.Repositories;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Services
{
    public class MealPeriodService
    {
        private readonly MealPeriodGenerator mealPeriodGenerator;
        private readonly MealPeriodRepository mealPeriodRepository;
        private readonly DefaultValues defaultValues;

        public MealPeriodService(MealPeriodGenerator mealPeriodGenerator, MealPeriodRepository mealPeriodRepository, DefaultValues defaultValues)
        {
            this.mealPeriodGenerator = mealPeriodGenerator;
            this.mealPeriodRepository = mealPeriodRepository;
            this.defaultValues = defaultValues;
        }

        public IList<MealPeriods> CreateMealPeriod(int count)
        {
            var mealPeriods = this.mealPeriodGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.mealPeriodRepository.BulkInsert(mealPeriods.ToList());

            return mealPeriods;
        }
        public void DeleteMealPeriod(IList<MealPeriods> list)
        {
            this.mealPeriodRepository.DeleteAll(list);
        }
    }
}