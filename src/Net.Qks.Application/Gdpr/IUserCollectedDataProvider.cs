using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Net.Qks.Dto;

namespace Net.Qks.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
