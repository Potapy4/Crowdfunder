using Crowdfunder.Data.Enums;

namespace Crowdfunder.Data.Entities
{
    public class ProjectMember
    {
        public long UserId { get; set; }
        public long ProjectId { get; set; }
        public TeamMemberRole Role { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }
}