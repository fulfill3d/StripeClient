using Client.Options;
using Microsoft.Extensions.Options;
using Stripe;

namespace Client
{
    internal abstract class BaseClient
    {
        protected BaseClient(IOptions<StripeClientOptions> options)
        {
            StripeConfiguration.ApiKey = options.Value.ApiKey;
        }
    }
}