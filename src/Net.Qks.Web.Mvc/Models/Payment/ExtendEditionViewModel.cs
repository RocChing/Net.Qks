using System.Collections.Generic;
using Net.Qks.Editions.Dto;
using Net.Qks.MultiTenancy.Payments;

namespace Net.Qks.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}