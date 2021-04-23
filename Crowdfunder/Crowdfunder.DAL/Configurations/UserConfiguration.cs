using Crowdfunder.DAL.Configurations.Core;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations
{
    internal sealed class UserConfiguration: BaseEntityTypeConfiguration<User>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
        {
            base.ConfigureEntity(builder);
            builder
                .Property(user => user.Email)
                .IsRequired();

            builder
                .Property(user => user.PasswordHash)
                .IsRequired();
            
            builder
                .HasMany(user => user.Balances)
                .WithOne(balance => balance.User)
                .HasForeignKey(balance => balance.UserId);
            
            builder
                .HasMany(user => user.OwnProjects)
                .WithOne(project => project.Owner)
                .HasForeignKey(project => project.OwnerId);
        }
    }
}