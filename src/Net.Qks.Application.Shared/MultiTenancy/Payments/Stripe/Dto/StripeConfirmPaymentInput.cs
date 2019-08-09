namespace Net.Qks.MultiTenancy.Payments.Stripe.Dto
{
    public class StripeConfirmPaymentInput
    {
        public long PaymentId { get; set; }

        public string StripeToken { get; set; }
    }
}