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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("tr");

            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentance(1),
                Description = faker.Lorem.Sentance(5),
                CategoryId = 1,
            };
            Detail detail2 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentance(1),
                Description = faker.Lorem.Sentance(5),
                CategoryId = 3,
                IsDeleted = true,
            };
            Detail detail3 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentance(1),
                Description = faker.Lorem.Sentance(5),
                CategoryId = 4,
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}