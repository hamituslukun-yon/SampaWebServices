using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampaWebServices
{
    public class CreditNote
    {
        public ZEBA_F_MUHASEB_ENTGResponse CreditNoteOnay(List<ZEBA_T_MUHKAYIT> kayitlar)
        {
            ZEBA_GET_FAT rfc = new ZEBA_GET_FAT();

            ZEBA_F_MUHASEB_ENTG ent = new ZEBA_F_MUHASEB_ENTG();
            ent.IT_EBANR = kayitlar.ToArray();

            var response = rfc.ZEBA_F_MUHASEB_ENTG(ent);

            return response;
        }
    }
}
