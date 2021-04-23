using System;
using System.Linq.Expressions;
using Crowdfunder.DAL.Configurations.Core;
using Crowdfunder.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdfunder.DAL.Configurations
{
    internal sealed class ProjectMemberConfiguration: BaseTypeConfiguration<ProjectMember>
    {
        protected override Expression<Func<ProjectMember, object>> Key => 
            member => new {member.UserId, member.ProjectId};
        protected override void ConfigureEntity(EntityTypeBuilder<ProjectMember> builder)
        {
            builder
                .HasOne(member => member.Project)
                .WithMany(project => project.Team)
                .HasForeignKey(member => member.ProjectId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            
            builder
                .HasOne(member => member.User)
                .WithMany(user => user.Projects)
                .HasForeignKey(member => member.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .Property(member => member.Role)
                .IsRequired();
        }
    }
}