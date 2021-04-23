using Crowdfunder.DAL.Configurations.Core;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations
{
    internal sealed class ProjectConfiguration: BaseEntityTypeConfiguration<Project>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Project> builder)
        {
            base.ConfigureEntity(builder);
            builder
                .Property(project => project.Title)
                .IsRequired();

            builder
                .Property(project => project.Description)
                .IsRequired();
            
            builder
                .HasMany(project => project.Wallets)
                .WithOne(wallet => wallet.Project)
                .HasForeignKey(wallet => wallet.ProjectId);
        }
    }
}