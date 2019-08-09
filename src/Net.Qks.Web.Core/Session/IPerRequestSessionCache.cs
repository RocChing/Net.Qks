using System.Threading.Tasks;
using Net.Qks.Sessions.Dto;

namespace Net.Qks.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
