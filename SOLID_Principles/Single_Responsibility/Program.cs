
using Single_Responsibility;

Invoice invoice = new Invoice { InvoiceId = 101, Amount = 100m };

InvoicePrinter printer = new InvoicePrinter();

printer.Print(invoice);


Console.WriteLine("Press any key to exit...");
Console.ReadLine();


