using System.Collections.Generic;
using Net.Qks.Authorization.Users.Dto;
using Net.Qks.Dto;

namespace Net.Qks.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}