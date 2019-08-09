using Abp.Domain.Entities.Auditing;

namespace Net.Qks.Develop
{
    public class FullEntity<TKey> : FullAuditedEntity<TKey>
    {
        public int Order { get; set; }

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
