using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleInvoice
    {
        public string RefundInvoiceForAccount(string accountId)
        {
            try
            {
                string invoiceId = FetchInvoiceByAccountId(accountId);
                var refundReq = new InvoiceRefund()
                {
                    CreditCustomerNotes = "Notes on credits",
                    Type = Recurly.Constants.InvoiceRefundType.Amount, // could also be "line_items"
                    Amount = 100
                };
                Invoice invoice = HandleClient.client.RefundInvoice(invoiceId, refundReq);
                return $"Refunded Invoice #{invoice.Number}";
            }
            catch (Recurly.Errors.Validation ex)
            {
                // If the request was not valid, you may want to tell your user
                // why. You can find the invalid params and reasons in ex.Error.Params
                return $"Failed validation: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }

        }

        public string FetchInvoiceByAccountId(string accountId)
        {
            var invoices = HandleClient.client.ListAccountInvoices(accountId);
            foreach (Invoice invoice in invoices)
            {
               return invoice.Id;
            }
            return string.Empty;
        }


    }
}
