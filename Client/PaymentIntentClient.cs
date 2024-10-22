using AutoMapper;
using Client.Interface;
using Client.Model.PaymentIntent;
using Client.Options;
using Microsoft.Extensions.Options;
using Stripe;

namespace Client
{
    internal class PaymentIntentClient(IOptions<StripeClientOptions> options, IMapper mapper) : BaseClient(options), IPaymentIntentClient
    {
        public async Task<PaymentIntentResult> ChargeStripe(long amount, string currency, string customerId, string paymentMethodId)
        {
            var service = new PaymentIntentService();
            var options = new PaymentIntentCreateOptions
            {
                Amount = amount,
                Currency = currency,
                Customer = customerId,
                PaymentMethod = paymentMethodId,
                Confirm = true,
                OffSession = true,
            };
            
            var paymentIntent = await service.CreateAsync(options);

            return mapper.Map<PaymentIntentResult>(paymentIntent);
        }
    }
}