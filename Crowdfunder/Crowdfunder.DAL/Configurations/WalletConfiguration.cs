using Crowdfunder.DAL.Configurations.Core;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations
{
    internal sealed class WalletConfiguration: BaseEntityTypeConfiguration<Wallet>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Wallet> builder)
        {
            base.ConfigureEntity(builder);
            
            builder
                .Property(wallet => wallet.Amount)
                .HasColumnType("Money")
                .IsRequired();
            
            builder
                .Property(wallet => wallet.Currency)
                .IsRequired();
        }
    }
}