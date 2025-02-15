
namespace Adapter.Services;

public class OldPayementGateway
{
    public void MakePayment(string customer, double money)
    {
        Console.WriteLine($"Processing payment for {customer} of {money} using old payment gateway");
    }
}