using AutoMapper;
using Client.Model.PaymentIntent;
using Stripe;

namespace Client.Options
{
    public class PaymentIntentProfile : Profile
    {
        public PaymentIntentProfile()
        {
            CreateMap<PaymentIntent, PaymentIntentResult>().ReverseMap();
        }
    }
}