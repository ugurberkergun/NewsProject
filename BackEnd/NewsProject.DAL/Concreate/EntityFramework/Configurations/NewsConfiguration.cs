using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NewsProject.DAL.Concreate.EntityFramework.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NewsHeader).IsRequired().HasMaxLength(70);
            builder.Property(x => x.NewsContext).IsRequired().HasMaxLength(1200);
            builder.Property(x => x.PhotoUrl).IsRequired().HasMaxLength(300);
            builder.HasOne(x => x.NewsCategory).WithMany(x => x.News).HasForeignKey(x => x.NewsCategoryId);
        }
    }
}
