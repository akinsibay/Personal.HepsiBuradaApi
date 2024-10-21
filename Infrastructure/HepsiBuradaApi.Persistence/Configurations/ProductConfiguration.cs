using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using HepsiBuradaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiBuradaApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id = 1,
                Title = faker.Finance.AccountName(),
                Description = faker.Finance.CreditCardNumber(),
                BrandId = 1,
                Discount = faker.Random.Number(0, 10),
                Price = faker.Finance.Amount(10, 1000)
            };
            Product product2 = new()
            {
                Id = 1,
                Title = faker.Finance.AccountName(),
                Description = faker.Finance.CreditCardNumber(),
                BrandId = 3,
                Discount = faker.Random.Number(0, 10),
                Price = faker.Finance.Amount(10, 1000)
            };
            builder.HasData(product1, product2);
        }
    }
}