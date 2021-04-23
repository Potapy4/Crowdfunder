using Crowdfunder.Data.Entities.Core;
using Crowdfunder.Data.Enums;

namespace Crowdfunder.Data.Entities
{
    public class Balance : BaseEntity
    {
        public long UserId { get; set; }
        public decimal Amount { get; set; }
        public CurrencyType Currency { get; set; }

        public virtual User User { get; set; }
    }
}