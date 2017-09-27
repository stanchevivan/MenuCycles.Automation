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
            //Makes sure that Recipes created by user can also be deleted by the repository
            list.Where(l => l.MealPeriodId == 0).ToList().ForEach(l => l.MealPeriodId = this.mealPeriodRepository.FindByName(l.Name).MealPeriodId);

            this.mealPeriodRepository.DeleteAll(list);
        }
    }
}