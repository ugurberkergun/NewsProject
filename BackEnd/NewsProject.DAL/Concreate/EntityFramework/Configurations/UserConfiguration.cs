using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsProject.Core.Entities.Concreate;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Concreate.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Status).IsRequired().HasColumnType("bit");
            builder.Property(x => x.PasswordSalt).IsRequired().HasColumnType("varbinary");
            builder.Property(x => x.PasswordSalt).HasMaxLength(500);
            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("varbinary");
            builder.Property(x => x.PasswordHash).HasMaxLength(500);



        }
    }
}
