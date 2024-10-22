using AutoMapper;
using Client.Interface;
using Client.Model.SetupIntent;
using Client.Options;
using Microsoft.Extensions.Options;
using Stripe;

namespace Client
{
    internal class SetupIntentClient(IOptions<StripeClientOptions> options, IMapper mapper) : BaseClient(options), ISetupIntentClient
    {
        public SetupIntentResult SetupCardIntent(string stripeCustomerId)
        {
            var intentOptions = new SetupIntentCreateOptions
            {
                Customer = stripeCustomerId,
                PaymentMethodTypes = { "card" },
            };
            var intentService = new SetupIntentService();
            var intent = intentService.Create(intentOptions);
            return mapper.Map<SetupIntent, SetupIntentResult>(intent);
        }
    }
}