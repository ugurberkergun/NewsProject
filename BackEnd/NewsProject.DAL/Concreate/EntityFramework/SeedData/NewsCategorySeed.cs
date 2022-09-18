using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Concreate.EntityFramework.SeedData
{
    public class NewsCategorySeed : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.HasData(
                new NewsCategory { Id = 1, CategoryName = "Ekonomi" },
                new NewsCategory { Id = 2, CategoryName = "Spor" },
                new NewsCategory { Id = 3, CategoryName = "Magazin" },
                new NewsCategory { Id = 4, CategoryName = "Turizm" },
                new NewsCategory { Id = 5, CategoryName = "Dünya" }
                );
        }
    }
}
