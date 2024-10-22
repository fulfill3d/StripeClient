using Client.Model.PaymentMethod;

namespace Client.Interface
{
    public interface IPaymentMethodClient
    {
        PaymentMethodResult GetPaymentMethod(string id);
        void Detach(string id);
    }
}