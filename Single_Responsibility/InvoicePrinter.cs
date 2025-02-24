using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class InvoicePrinter
    {
        public void Print(Invoice invoice) {

            // This class handles only the printing resposibility
            Console.WriteLine($"Invoice {invoice.InvoiceId}: {invoice.CalculateTotal()}");
        }
    }
}
