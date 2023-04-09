using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Service
{
    public interface IInvoiceServicecs
    {
        Modals.Invoice CreateInvoice(Modals.Invoice invoice);

        List<Modals.Invoice> GetAllInvoices();

        Modals.Invoice GetInvoiceByOrderId(string orderId);

        string DeleteInvoice(int invoiceId);
    }
}
