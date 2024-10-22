using Client.Model.PaymentIntent;

namespace Client.Interface
{
    public interface IPaymentIntentClient
    {
        Task<PaymentIntentResult> ChargeStripe(long amount, string currency, string customerId, string paymentMethodId);
    }
}