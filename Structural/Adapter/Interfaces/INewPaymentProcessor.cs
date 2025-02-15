
namespace Adapter.Interfaces;

public interface INewPaymentProcessor
{
    void ProcessPayment(string account, double amount);
}
