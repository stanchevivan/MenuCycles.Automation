using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycleData.Generators;
using MenuCycleData.Repositories;

namespace MenuCycleData.Services
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

        public IList<MealPeriod> CreateMealPeriod(int count)
        {
            var mealPeriods = this.mealPeriodGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.mealPeriodRepository.BulkInsert(mealPeriods.ToList());

            return mealPeriods;
        }
        public void DeleteMealPeriod(IList<MealPeriod> list)
        {
            this.mealPeriodRepository.DeleteAll(list);
        }
    }
}