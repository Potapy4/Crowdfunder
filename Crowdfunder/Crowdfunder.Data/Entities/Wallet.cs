using Crowdfunder.Data.Entities.Core;
using Crowdfunder.Data.Enums;

namespace Crowdfunder.Data.Entities
{
    public class Wallet: BaseEntity
    {
        public long ProjectId { get; set; }
        public decimal Amount { get; set; }
        public CurrencyType Currency { get; set; }

        public virtual Project Project { get; set; }
    }
}