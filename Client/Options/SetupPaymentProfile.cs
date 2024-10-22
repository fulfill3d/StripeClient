using AutoMapper;
using Client.Model.Customer;
using Client.Model.SetupIntent;
using Stripe;

namespace Client.Options
{
    public class SetupPaymentProfile : Profile
    {
        public SetupPaymentProfile()
        {
            CreateMap<SetupIntent, SetupIntentResult>().ReverseMap();
            CreateMap<Customer, CustomerResult>();
        }
    }
}