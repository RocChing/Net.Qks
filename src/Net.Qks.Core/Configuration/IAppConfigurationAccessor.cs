using Microsoft.Extensions.Configuration;

namespace Net.Qks.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
