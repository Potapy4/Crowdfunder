using Crowdfunder.DAL.Configurations.Core;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations
{
    internal sealed class BalanceConfiguration: BaseEntityTypeConfiguration<Balance>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Balance> builder)
        {
            base.ConfigureEntity(builder);

            builder
                .Property(balance => balance.Amount)
                .HasColumnType("Money")
                .IsRequired();
            
            builder
                .Property(balance => balance.Currency)
                .IsRequired();
        }
    }
}