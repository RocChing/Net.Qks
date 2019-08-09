using Abp.AutoMapper;
using Net.Qks.Editions;
using Net.Qks.MultiTenancy.Payments.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}