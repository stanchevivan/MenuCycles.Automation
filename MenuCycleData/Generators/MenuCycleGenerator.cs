using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace MenuCycleData.Generators
{


    public class MenuCycleGenerator : IGenerator<MenuCycle>
    {
        private readonly Faker<MenuCycle> faker;

        public MenuCycleGenerator()
        {
            this.faker = new Faker<MenuCycle>()
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

        public MenuCycle Generate() =>
            this.faker.Generate();

        public IList<MenuCycle> Generate(int count)
        {
            throw new NotImplementedException();
        }

        public IList<MenuCycle> Generate(int count, long customerId)
        {
            var result = this.faker.Generate(count).ToList();
            result.ForEach(r => r.CustomerId = customerId);
            return result;
        }
    }
}