using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampaWebServices
{
    public class MusteriTedarikci
    {
        public ZQDMS_CUST_SUP_RFCResponse MusteriTedarikciListesi(string bukrs)
        {
            ZQDMS_CUST_SUP_RFC rfc = new ZQDMS_CUST_SUP_RFC();

            var request = new ZQDMS_CUST_SUP_RFC1();

            request.E_LIST = new ZQDMS_STR_SUPL_CUST_ADD[] { };
            request.E_LIST_BNK = new ZQDMS_STR_SUPL_BANKA[] { };
            request.E_LIST_ZTERM = new ZQDMS_STR_ZTERM[] { };
            request.IV_BUKRS = bukrs;

            var response = rfc.CallZQDMS_CUST_SUP_RFC(request);

            return response;
        }
    }
}
