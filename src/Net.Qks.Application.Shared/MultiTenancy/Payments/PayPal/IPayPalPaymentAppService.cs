using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.MultiTenancy.Payments.PayPal.Dto;

namespace Net.Qks.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
