using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Service
{
    public class InvoiceService : IInvoiceServicecs
    {
        public Modals.Invoice CreateInvoice(Modals.Invoice invoice)
        {
            Data.InvoiceDAO.Invoices.Add(invoice);
            return invoice;
        }

        public string DeleteInvoice(int invoiceId)
        {
            Modals.Invoice getInvoice =  Data.InvoiceDAO.Invoices.Find(invoice => invoice.InvoiceId == invoiceId);
            Data.InvoiceDAO.Invoices.Remove(getInvoice);
            return invoiceId.ToString();
        }

        public List<Modals.Invoice> GetAllInvoices()
        {
            return Data.InvoiceDAO.Invoices;
        }

        public Modals.Invoice GetInvoiceByOrderId(string orderId)
        {
            return Data.InvoiceDAO.Invoices.FirstOrDefault(invoice => invoice.OrderId == orderId);
        }
    }
}
