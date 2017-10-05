using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Generators
{
    public class MenuCycleGenerator : IGenerator<MenuCycles>
    {
        private readonly Faker<MenuCycles> faker;
        public MenuCycleGenerator()
        {
            this.faker = new Faker<MenuCycles>()
                .RuleFor(f => f.Name, f => f.Name.FirstName())
                .RuleFor(f => f.Description, f => f.Lorem.Sentence(10))
                .RuleFor(f => f.ParentId, f => null)
                .RuleFor(f => f.IsPublished, f => false)
                .RuleFor(f => f.StartDate, f => null)
                .RuleFor(f => f.EndDate, f => null)
                .RuleFor(f => f.NonServingDays, 0)
                .RuleFor(f => f.DateCreatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.CreatedByExternalId, f => "admin")
                .RuleFor(f => f.DateUpdatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.UpdatedByExternalId, f => "admin");
        }

        public MenuCycles Generate()
        {
            return this.faker.Generate();
        }

        public IList<MenuCycles> Generate(int count)
        {
            return this.faker.Generate(count);
        }

        public IList<MenuCycles> Generate(int count, long customerId)
        {
            var result = this.faker.Generate(count).ToList();
            result.ForEach(r => r.CustomerId = customerId);
            return result;
        }
    }
}