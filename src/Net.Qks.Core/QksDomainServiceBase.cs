using Abp.Domain.Services;

namespace Net.Qks
{
    public abstract class QksDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected QksDomainServiceBase()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}
