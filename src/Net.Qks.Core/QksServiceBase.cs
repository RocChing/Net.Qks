using Abp;

namespace Net.Qks
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="QksDomainServiceBase"/>.
    /// For application services inherit QksAppServiceBase.
    /// </summary>
    public abstract class QksServiceBase : AbpServiceBase
    {
        protected QksServiceBase()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}