
using Adapter.Services; 
using Adapter.Interfaces;

namespace Adapter.Adapters;

public class PaymentAdapter : INewPaymentProcessor
{
    private readonly OldPayementGateway _oldPayementGateway;

    public PaymentAdapter(OldPayementGateway oldPayementGateway)
    {
        _oldPayementGateway = oldPayementGateway;
    }

    public void ProcessPayment(string account, double amount) 
    {
        _oldPayementGateway.MakePayment(account, amount);
    }
}