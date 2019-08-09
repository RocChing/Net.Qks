using System.Collections.Generic;
using Net.Qks.Editions;
using Net.Qks.Editions.Dto;
using Net.Qks.MultiTenancy.Payments;
using Net.Qks.MultiTenancy.Payments.Dto;

namespace Net.Qks.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
