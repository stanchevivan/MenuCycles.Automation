using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Generators
{
    public class MealPeriodGenerator : IGenerator<MealPeriods>
    {
        private readonly Faker<MealPeriods> faker;

        public MealPeriodGenerator()
        {
           this.faker = new Faker<MealPeriods>()
                .RuleFor(f => f.Name, f => f.Name.FirstName())
                .RuleFor(f => f.ExternalId, f => Guid.NewGuid())
                .RuleFor(f => f.DateCreatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.CreatedByExternalId, f => "admin")
                .RuleFor(f => f.DateUpdatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.UpdatedByExternalId, f => "admin");
        }

        public MealPeriods Generate()
        {
            return this.faker.Generate();
        }

        public IList<MealPeriods> Generate(int count)
        {
            return this.faker.Generate(count);
        }

        public IList<MealPeriods> Generate(int count, long customerId)
        {
            var result = this.faker.Generate(count).ToList();
            result.ForEach(r => r.CustomerId = customerId);
            return result;
        }
    }
}