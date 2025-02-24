using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public decimal Amount { get; set; }

        public decimal CalculateTotal() {
            return Amount * 1.05m;
        }
    }
}
