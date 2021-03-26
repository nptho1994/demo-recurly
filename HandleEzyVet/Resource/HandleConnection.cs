using HandleEzyVet.Config;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    public class HandleConnection
    {
        public string GetAccessTokenByScope()
        {
            string scopeTest = "read-stockadjustmentitem,read-address,read-animal,read-animalcolour,read-appointment,read-appointmentstatus,read-appointmenttype,read-assessment,read-attachment,read-batch,read-breed,read-communication,read-consult,read-contact,read-contactdetail,read-contactdetailtype,read-country,read-diagnostic,read-diagnosticrequest,read-diagnosticresult,read-diagnosticresultitem,read-healthstatus,read-history,read-integrateddiagnostic,read-invoice,read-invoiceline,read-operation,read-payment,read-paymentallocation,read-paymentmethod,read-physicalexam,read-plan,read-prescription,read-prescriptionitem,read-presentingproblem,read-presentingproblemlink,read-product,read-productgroup,read-productpricing,read-purchaseorder,read-purchaseorderitem,read-receiveinvoice,read-receiveinvoiceitem,read-resource,read-separation,read-sex,read-species,read-stockadjustment,read-stocktransaction,read-systemsetting,read-tag,read-tagcategory,read-tagname,read-taxrate,read-therapeutic,read-user,read-vaccination,read-webhookevents,read-webhooks,read-wellnessplan,read-wellnessplanbenefit,read-wellnessplanbenefititem,read-wellnessplanmembership,read-wellnessplanmembershipoption,read-wellnessplanmembershipstatusperiod,write-animal,write-appointment,write-batch,write-communication,write-contact,write-productpricing,write-stockadjustment,write-stockadjustmentitem,write-webhooks,read-productminimumstock,write-wellnessplan,write-wellnessplanmembership";
            var client = new RestClient(ClientConfig.EZYVET_URL_GETTOKEN);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", ClientConfig.EZYVET_HEADER_CONTENT_TYPE);
            request.AddParameter("partner_id", ClientConfig.EZYVET_PARTNER_ID);
            request.AddParameter("client_id", ClientConfig.EZYVET_CLIENT_ID);
            request.AddParameter("client_secret", ClientConfig.EZYVET_CLIENT_SECRET);
            request.AddParameter("grant_type", ClientConfig.EZYVET_GRANT_TYPE);
            request.AddParameter("scope", scopeTest);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
