using AutoMapper;
using Client.Interface;
using Client.Model.Customer;
using Client.Options;
using Microsoft.Extensions.Options;
using Stripe;

namespace Client
{
    internal class CustomerClient(IOptions<StripeClientOptions> options, IMapper mapper) : BaseClient(options), ICustomerClient
    {
        public CustomerResult CreateCustomer(CreateCustomerRequest request)
        {
            var options = new CustomerCreateOptions
            {
                Email = request.Email,
                Phone = request.Phone,
                Name = request.Name
            };
            var customerService = new CustomerService();
            var customer = customerService.Create(options);
            return mapper.Map<Customer, CustomerResult>(customer);
        }
    }
}