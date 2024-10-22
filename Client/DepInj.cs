using Client.Interface;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
    public static class DepInj
    {
        public static void AddStripePaymentIntentClient(
            this IServiceCollection services,
            Action<StripeClientOptions> configureStripeClientOptions)
        {
            services.ConfigureServiceOptions<StripeClientOptions>((_, options) => configureStripeClientOptions(options));
            
            services.AddAutoMapper(typeof(PaymentIntentProfile));

            services.AddTransient<IPaymentIntentClient, PaymentIntentClient>();
        }

        public static void AddStripeSetupPaymentClients(
            this IServiceCollection services,
            Action<StripeClientOptions> configureStripeClientOptions)
        {
            services.ConfigureServiceOptions<StripeClientOptions>((_, options) => configureStripeClientOptions(options));
            
            services.AddAutoMapper(typeof(SetupPaymentProfile));

            services.AddTransient<ICustomerClient, CustomerClient>();
            services.AddTransient<IPaymentMethodClient, PaymentMethodClient>();
            services.AddTransient<ISetupIntentClient, SetupIntentClient>();
        }

        private static void ConfigureServiceOptions<TOptions>(
            this IServiceCollection services,
            Action<IServiceProvider, TOptions> configure)
            where TOptions : class
        {
            services
                .AddOptions<TOptions>()
                .Configure<IServiceProvider>((options, resolver) => configure(resolver, options));
        }
    }
}