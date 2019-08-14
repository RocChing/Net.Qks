using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Develop
{
    public class FullEntity<TKey> : FullAuditedEntity<TKey>
    {
        public int Order { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public FullEntity()
        {
            Order = QksConsts.DefaultOrderValue;
        }
    }

    public class FullEntity : FullEntity<int>
    {

    }
}
