using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SampaWebServices
{
    public class Fatura
    {
        public ZEBA_INV_DETAIL[] FaturaGetir()
        {
            ZAPP_EBA_FATURA_GONDER_RFC rfc = new ZAPP_EBA_FATURA_GONDER_RFC();
            
            var request = new ZAPP_EBA_FATURA_GONDER_RFC1();

            request.ET_INVOICE = new ZEBA_INV_DETAIL[] { };

            var response = rfc.CallZAPP_EBA_FATURA_GONDER_RFC(request);

            return response.ET_INVOICE;
        }

        public ZEBA_INV_APPROVL FaturaOnay(string id, string mandt, string vbeln, string eba_ref, string statu, string appr_user, string appr_date, DateTime? appr_time, string appr_date_time)
        {
            ZAPP_EBA_FATURA_ONAY_RFC rfc = new ZAPP_EBA_FATURA_ONAY_RFC();

            var request = new ZAPP_EBA_FATURA_ONAY_RFC1();

            ZEBA_INV_APPROVL approval = new ZEBA_INV_APPROVL();
            approval.ID = id;
            approval.MANDT = mandt;
            approval.VBELN = vbeln;
            approval.EBA_REF = eba_ref;
            approval.STATU = statu;
            approval.APPR_USER = appr_user;
            approval.APPR_DATE = appr_date;
            approval.APPR_TIME = appr_time;
            approval.APPR_DATE_TIME = appr_date_time;

            request.IT_INVOICE = new ZEBA_INV_APPROVL[] { approval };

            var response = rfc.CallZAPP_EBA_FATURA_ONAY_RFC(request);

            return response.IT_INVOICE[0];
        }

        public Stream FaturaPDFGetir(string vbeln)
        {
            ZAPP_EBA_FATURA_PDF_GONDER_RFC rfc = new ZAPP_EBA_FATURA_PDF_GONDER_RFC();

            var request = new ZAPP_EBA_FATURA_PDF_GONDER_RFC1();

            request.I_VBELN = vbeln;

            var response = rfc.CallZAPP_EBA_FATURA_PDF_GONDER_RFC(request);

            byte[] byteArray = Convert.FromBase64String(response.E_PDF);

            Stream stream = new MemoryStream(byteArray);

            return stream;
        }

    }
}
