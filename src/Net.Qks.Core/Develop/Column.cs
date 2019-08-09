using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Develop
{
    [Table("QksColumns")]
    public class Column : FullEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string FieldName { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        public int MaxLength { get; set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsAllowNull { get; set; }

        public int TableId { get; set; }

        public Column()
        {
            IsAllowNull = true;
        }
    }
}
