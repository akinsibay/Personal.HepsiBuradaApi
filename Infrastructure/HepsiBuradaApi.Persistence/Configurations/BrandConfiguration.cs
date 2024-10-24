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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker = new("tr");

            Brand brand1 = new() { Id = 1, Name = faker.Finance.Account() };
            Brand brand2 = new() { Id = 2, Name = faker.Finance.Account() };
            Brand brand3 = new() { Id = 3, Name = faker.Finance.Account(), IsDeleted = true };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}