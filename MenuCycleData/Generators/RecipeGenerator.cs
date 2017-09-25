using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace MenuCycleData.Generators
{


    public class RecipeGenerator
    {
        private readonly Faker<Recipe> faker;

        public RecipeGenerator() =>
            this.faker = new Faker<Recipe>()
                .RuleFor(f => f.ExternalId, f => Guid.NewGuid())
                .RuleFor(f => f.Name, f => f.Commerce.Product())
                .RuleFor(f => f.Cost, f => f.Random.Decimal(1, 50))
                .RuleFor(f => f.CostQuantity, f => f.Random.Double(11, 39))
                .RuleFor(f => f.CostUnitOfMeasure, f => "kg")
                ////.RuleFor(f => f.CustomerId, f => customerId)
                .RuleFor(f => f.MinimumCost, f => f.Random.Decimal(1, 10))
                .RuleFor(f => f.MaximumCost, f => f.Random.Decimal(40, 50))
                .RuleFor(f => f.SellPriceModel, f => 1)
                .RuleFor(f => f.SellPriceModelValue, f => 1)
                .RuleFor(f => f.DateCreatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.CreatedByExternalId, f => "admin")
                .RuleFor(f => f.DateUpdatedUtc, f => DateTime.UtcNow)
                .RuleFor(f => f.UpdatedByExternalId, f => "admin");

        public Recipe Generate() =>
            this.faker.Generate();

        public IList<Recipe> Generate(int count, long customerId)
        {
            var result = this.faker.Generate(count).ToList();
            result.ForEach(r => r.CustomerId = customerId);
            return result;
        }
    }
}