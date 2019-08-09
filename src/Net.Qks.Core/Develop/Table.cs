using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Net.Qks.Develop
{
    [Table("QksTables")]
    public class Table : FullEntity
    {
        [MaxLength(QksConsts.Field.Len50)]
        public string Name { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string DbName { get; set; }

        [MaxLength(QksConsts.Field.Len200)]
        public string Namespace { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string ServiceName { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string DtoName { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string AuthorizeName { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string GetAllInputName { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string CreateInputName { get; set; }

        [MaxLength(QksConsts.Field.Len50)]
        public string UpdateInputName { get; set; }

        [MaxLength(QksConsts.Field.Len100)]
        public string CreatePermissionName { get; set; }
        [MaxLength(QksConsts.Field.Len100)]
        public string GetAllPermissionName { get; set; }
        [MaxLength(QksConsts.Field.Len100)]
        public string GetPermissionName { get; set; }
        [MaxLength(QksConsts.Field.Len100)]
        public string UpdatePermissionName { get; set; }
        [MaxLength(QksConsts.Field.Len100)]
        public string DeletePermissionName { get; set; }

        [ForeignKey("TableId")]
        public virtual List<Column> Columns { get; set; }

        public Table()
        {

        }
    }
}
