using System.Collections.Generic;
using Crowdfunder.Data.Entities.Core;

namespace Crowdfunder.Data.Entities
{
    public class User: BaseEntity
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        
        public virtual IReadOnlyCollection<Project> OwnProjects { get; set; }
        public virtual IReadOnlyCollection<ProjectMember> Projects { get; set; }
        public virtual IReadOnlyCollection<Balance> Balances { get; set; }
    }
}