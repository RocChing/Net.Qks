using System.Collections.Generic;
using Net.Qks.Authorization.Users.Importing.Dto;
using Net.Qks.Dto;

namespace Net.Qks.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
