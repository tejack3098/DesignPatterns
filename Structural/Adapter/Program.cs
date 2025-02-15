
using Adapter.Adapters;
using Adapter.Services; 
using Adapter.Interfaces;

//Existing old payment gateway
OldPayementGateway oldPaymentGateway = new OldPayementGateway();

// Using Adapter to make payment
INewPaymentProcessor paymentProcessor = new PaymentAdapter(oldPaymentGateway);

// Process payment using new payment processor
paymentProcessor.ProcessPayment("Tejas", 1000);

