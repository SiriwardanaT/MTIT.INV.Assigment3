using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Data
{
    public static class InvoiceDAO
    {
        public static List<Modals.Invoice> Invoices = new List<Modals.Invoice>()
        {
            new Modals.Invoice(){ InvoiceId=10,InvoicedDate=DateTime.Now,OrderId="O13",TotalAmount=7000 },
            new Modals.Invoice(){ InvoiceId=11,InvoicedDate=DateTime.Now,OrderId="O12",TotalAmount=3000 }
        };
    }
}
