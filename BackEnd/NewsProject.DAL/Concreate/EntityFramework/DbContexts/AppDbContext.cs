using Core.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewsProject.Core.Entities.Concreate;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Concreate.EntityFramework.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
