using Abp.Runtime.Validation;
using Net.Qks.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Qks.Develop
{
    public class GetTablesInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string Filter { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name";
            }
            Filter = Filter?.Trim();
        }
    }
}
