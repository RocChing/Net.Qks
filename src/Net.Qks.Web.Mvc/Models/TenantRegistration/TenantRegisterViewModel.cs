using Net.Qks.Editions;
using Net.Qks.Editions.Dto;
using Net.Qks.MultiTenancy.Payments;
using Net.Qks.Security;
using Net.Qks.MultiTenancy.Payments.Dto;

namespace Net.Qks.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
