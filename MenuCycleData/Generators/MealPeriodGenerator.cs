using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace MenuCycleData.Generators
{


    public class MealPeriodGenerator : IGenerator<MealPeriod>
    {
        private readonly Faker<MealPeriod> faker;

        public MealPeriodGenerator()
        {
           this.faker = new Faker<MealPeriod>()
                .RuleFor(f => f.Name, f => f.Name.FirstName())
                .RuleFor(f => f.ExternalId, f => Guid.NewGuid())
                .RuleFor(f => f.DateCreatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.CreatedByExternalId, f => "admin")
                .RuleFor(f => f.DateUpdatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.UpdatedByExternalId, f => "admin");
        }

        public MealPeriod Generate() =>
            this.faker.Generate();

        public IList<MealPeriod> Generate(int count)
        {
            throw new NotImplementedException();
        }

        public IList<MealPeriod> Generate(int count, long customerId)
        {
            var result = this.faker.Generate(count).ToList();
            result.ForEach(r => r.CustomerId = customerId);
            return result;
        }
    }
}