using System.Collections.Generic;
using Net.Qks.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Net.Qks.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
