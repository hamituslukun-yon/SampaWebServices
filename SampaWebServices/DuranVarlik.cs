using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampaWebServices
{
    public class DuranVarlik
    {
        public ZAPP_EBA_DV[] DuranVarlikGetir()
        {
            ZAPP_EBA_FI_DV_GONDER rfc = new ZAPP_EBA_FI_DV_GONDER();

            var request = new ZAPP_EBA_FI_DV_GONDER1();

            request.LT_DV = new ZAPP_EBA_DV[] { };

            var response = rfc.CallZAPP_EBA_FI_DV_GONDER(request);

            return response.LT_DV;
        }
    }
}
