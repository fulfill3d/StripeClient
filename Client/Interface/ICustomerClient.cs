using Client.Model.Customer;

namespace Client.Interface
{
    public interface ICustomerClient
    {
        CustomerResult CreateCustomer(CreateCustomerRequest request);
    }
}