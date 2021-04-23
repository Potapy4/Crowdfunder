using System.Reflection;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crowdfunder.DAL.Context
{
    internal sealed class CrowdfunderContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        
        public CrowdfunderContext(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(CrowdfunderContext))!);
        }
    }
}