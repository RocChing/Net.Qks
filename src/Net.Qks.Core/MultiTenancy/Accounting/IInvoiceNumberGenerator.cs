using System.Threading.Tasks;
using Abp.Dependency;

namespace Net.Qks.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}