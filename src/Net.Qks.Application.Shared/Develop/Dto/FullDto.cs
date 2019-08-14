using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Develop
{
    public class FullDto : EntityDto<int>
    {
        [Display(Name = "排序")]
        public int Order { get; set; }

        [Display(Name = "描述")]
        [MaxLength(300, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "操作类型")]
        public string ActionType { get; set; }

        public FullDto()
        {
            Order = QksConsts.DefaultOrderValue;
            ActionType = QksConsts.Action.Create;
        }
    }

    public class FullWithOutIdDto
    {
        [Display(Name = "排序")]
        public int Order { get; set; }

        [Display(Name = "描述")]
        [MaxLength(300, ErrorMessage = QksConsts.ErrorMsg.MaxLength)]
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "操作类型")]
        public string ActionType { get; set; }

        public FullWithOutIdDto()
        {
            Order = QksConsts.DefaultOrderValue;
            ActionType = QksConsts.Action.Create;
        }
    }
}
