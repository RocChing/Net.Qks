using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace Net.Qks.Develop
{
    public class TableDto : FullDto
    {
        public TableDto()
        {
            Columns = new List<ColumnDto>();
        }

        [Display(Name = "名称")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string Name { get; set; }

        [Display(Name = "表名")]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string DbName { get; set; }

        [Display(Name = "命名空间")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        [MaxLength(QksConsts.Field.Len200, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string Namespace { get; set; }

        [Display(Name = "服务名称")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string ServiceName { get; set; }

        [Display(Name = "Dto名称")]
        [Required(ErrorMessage = QksConsts.ErrorMsg.Required)]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string DtoName { get; set; }

        [Display(Name = "授权名称")]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string AuthorizeName { get; set; }

        [Display(Name = "查询参数名称")]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string GetAllInputName { get; set; }

        [Display(Name = "创建参数名称")]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string CreateInputName { get; set; }

        [Display(Name = "更新参数名称")]
        [MaxLength(QksConsts.Field.Len50, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string UpdateInputName { get; set; }

        [Display(Name = "创建权限名称")]
        [MaxLength(QksConsts.Field.Len100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string CreatePermissionName { get; set; }

        [Display(Name = "列表权限名称")]
        [MaxLength(QksConsts.Field.Len100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string GetAllPermissionName { get; set; }

        [Display(Name = "单个权限名称")]
        [MaxLength(QksConsts.Field.Len100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string GetPermissionName { get; set; }

        [Display(Name = "更新权限名称")]
        [MaxLength(QksConsts.Field.Len100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string UpdatePermissionName { get; set; }

        [Display(Name = "删除权限名称")]
        [MaxLength(QksConsts.Field.Len100, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string DeletePermissionName { get; set; }

        public virtual List<ColumnDto> Columns { get; set; }

        public ColumnDto Find(int id)
        {
            if (Columns != null && Columns.Count > 0)
                return Columns.Find(m => m.Id == id);
            return null;
        }
    }
}
