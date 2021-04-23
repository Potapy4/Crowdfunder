using System.Collections.Generic;
using Crowdfunder.Data.Entities.Core;

namespace Crowdfunder.Data.Entities
{
    public class Project: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long OwnerId { get; set; }

        public virtual User Owner { get; set; }
        public virtual IReadOnlyCollection<ProjectMember> Team { get; set; }
        public virtual IReadOnlyCollection<Wallet> Wallets { get; set; }
    }
}