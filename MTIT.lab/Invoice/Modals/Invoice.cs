using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Modals
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public double TotalAmount { get; set; }

        public string OrderId { get; set; }

        public DateTime? InvoicedDate { get; set; }
    }
}
