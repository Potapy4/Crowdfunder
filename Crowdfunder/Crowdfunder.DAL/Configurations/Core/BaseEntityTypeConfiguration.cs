using System;
using System.Linq.Expressions;
using Crowdfunder.Data.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations.Core
{
    internal abstract class BaseEntityTypeConfiguration<TEntity>: BaseTypeConfiguration<TEntity> where TEntity: BaseEntity
    {
        protected override Expression<Func<TEntity, object>> Key => entity => entity.Id;
        protected override void ConfigureEntity(EntityTypeBuilder<TEntity> builder)
        {
            builder
                .Property(entity => entity.CreatedAt)
                .HasColumnType("Date")
                .HasDefaultValueSql("GETUTCDATE()")
                .IsRequired();
            
            builder
                .Property(entity => entity.ModifiedAt)
                .HasColumnType("Date")
                .HasDefaultValueSql("GETUTCDATE()")
                .IsRequired();
        }
    }
}