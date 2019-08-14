using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using System;

namespace Net.Qks.Develop
{
    public class ColumnDto : FullDto
    {
        public ColumnDto()
        {
            Type = SubTypeCode.String;
            IsAllowNull = true;
        }
        [Display(Name = "名称")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        [MaxLength(50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string Name { get; set; }

        [Display(Name = "字段名")]
        [MaxLength(100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string FieldName { get; set; }

        [Display(Name = "类型")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        public SubTypeCode Type { get; set; }

        [Display(Name = "长度")]
        public int MaxLength { get; set; }

        [Display(Name = "主键")]
        public bool IsPrimaryKey { get; set; }

        [Display(Name = "自增")]
        public bool IsIdentity { get; set; }

        [Display(Name = "允许为NULL")]
        public bool IsAllowNull { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "表ID")]
        public int TableId { get; set; }

        [ScaffoldColumn(false)]
        public bool IsDeleted { get; set; }
    }
}
