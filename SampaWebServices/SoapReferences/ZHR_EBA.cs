﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 


/// <remarks/>
// CODEGEN: 'http://schemas.xmlsoap.org/ws/2004/09/policy' ad alanındaki 'Policy' isteğe bağlı WSDL uzantı öğesi işlenmedi.
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "ZHR_EBA", Namespace = "urn:sap-com:document:sap:rfc:functions")]
public partial class ZHR_EBA : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback ZHR_EBA_PERS_INFOOperationCompleted;

    /// <remarks/>
    public ZHR_EBA()
    {
        this.Url = "http://SMPERPPRDA1.sampadc.local:8000/sap/bc/srt/rfc/sap/zhr_eba/400/zhr_eba/zhr_" +
            "eba";
    }

    /// <remarks/>
    public event ZHR_EBA_PERS_INFOCompletedEventHandler ZHR_EBA_PERS_INFOCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:rfc:functions:ZHR_EBA:ZHR_EBA_PERS_INFORequest", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("ZHR_EBA_PERS_INFOResponse", Namespace = "urn:sap-com:document:sap:rfc:functions")]
    public ZHR_EBA_PERS_INFOResponse ZHR_EBA_PERS_INFO([System.Xml.Serialization.XmlElementAttribute("ZHR_EBA_PERS_INFO", Namespace = "urn:sap-com:document:sap:rfc:functions")] ZHR_EBA_PERS_INFO ZHR_EBA_PERS_INFO1)
    {
        object[] results = this.Invoke("ZHR_EBA_PERS_INFO", new object[] {
                    ZHR_EBA_PERS_INFO1});
        return ((ZHR_EBA_PERS_INFOResponse)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginZHR_EBA_PERS_INFO(ZHR_EBA_PERS_INFO ZHR_EBA_PERS_INFO1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("ZHR_EBA_PERS_INFO", new object[] {
                    ZHR_EBA_PERS_INFO1}, callback, asyncState);
    }

    /// <remarks/>
    public ZHR_EBA_PERS_INFOResponse EndZHR_EBA_PERS_INFO(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((ZHR_EBA_PERS_INFOResponse)(results[0]));
    }

    /// <remarks/>
    public void ZHR_EBA_PERS_INFOAsync(ZHR_EBA_PERS_INFO ZHR_EBA_PERS_INFO1)
    {
        this.ZHR_EBA_PERS_INFOAsync(ZHR_EBA_PERS_INFO1, null);
    }

    /// <remarks/>
    public void ZHR_EBA_PERS_INFOAsync(ZHR_EBA_PERS_INFO ZHR_EBA_PERS_INFO1, object userState)
    {
        if ((this.ZHR_EBA_PERS_INFOOperationCompleted == null))
        {
            this.ZHR_EBA_PERS_INFOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZHR_EBA_PERS_INFOOperationCompleted);
        }
        this.InvokeAsync("ZHR_EBA_PERS_INFO", new object[] {
                    ZHR_EBA_PERS_INFO1}, this.ZHR_EBA_PERS_INFOOperationCompleted, userState);
    }

    private void OnZHR_EBA_PERS_INFOOperationCompleted(object arg)
    {
        if ((this.ZHR_EBA_PERS_INFOCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ZHR_EBA_PERS_INFOCompleted(this, new ZHR_EBA_PERS_INFOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sap-com:document:sap:rfc:functions")]
public partial class ZHR_EBA_PERS_INFO
{

    private string dATEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATE
    {
        get
        {
            return this.dATEField;
        }
        set
        {
            this.dATEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions")]
public partial class ZHR_ST_EBA_PERSONEL
{

    private string uSERIDField;

    private string fIRSTNAMEField;

    private string lASTNAMEField;

    private string eMPLOYEMENTSTARTField;

    private string dEPARTMENTField;

    private string dEPARTMENTNAMEField;

    private string pROFESSIONField;

    private string pROFESSIONNAMEField;

    private string pOSITIONField;

    private string pOSITIONNAMEField;

    private string mANAGERUSERIDField;

    private string mANAGERNAMEField;

    private string mANAGERDEPARTMENTField;

    private string mANAGERDEPARTMENTTXTField;

    private string mANAGERUSERID2Field;

    private string mANAGERNAME2Field;

    private string mANAGERDEPARTMENT2Field;

    private string mANAGERDEPARTMENT2TXTField;

    private string eMAILField;

    private string cOMPANYField;

    private string cOMPANYNAMEField;

    private string eMPLOYEMENTENDField;

    private string oSIDField;

    private string pVALUEField;

    private string pNAMEField;

    private string cTTYPField;

    private string cTTXTField;

    private string cBEGDAField;

    private string cENDDAField;

    private string fAMSTField;

    private string fTEXTField;

    private string cSAYIField;

    private string mOBIL1Field;

    private string mOBIL2Field;

    private string mOBIL3Field;

    private string sTRASField;

    private string lOCATField;

    private string oRT02Field;

    private string sTATEField;

    private string sTATETXTField;

    private string lAND1Field;

    private string lAND1TXTField;

    private string aDRESTYPEField;

    private string aDRESTYPETXTField;

    private string bLOODField;

    private string bLOODTXTField;

    private string sLARTField;

    private string sTEXTField;

    private string cATEGORYField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string USERID
    {
        get
        {
            return this.uSERIDField;
        }
        set
        {
            this.uSERIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FIRSTNAME
    {
        get
        {
            return this.fIRSTNAMEField;
        }
        set
        {
            this.fIRSTNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LASTNAME
    {
        get
        {
            return this.lASTNAMEField;
        }
        set
        {
            this.lASTNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EMPLOYEMENTSTART
    {
        get
        {
            return this.eMPLOYEMENTSTARTField;
        }
        set
        {
            this.eMPLOYEMENTSTARTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DEPARTMENT
    {
        get
        {
            return this.dEPARTMENTField;
        }
        set
        {
            this.dEPARTMENTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DEPARTMENTNAME
    {
        get
        {
            return this.dEPARTMENTNAMEField;
        }
        set
        {
            this.dEPARTMENTNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PROFESSION
    {
        get
        {
            return this.pROFESSIONField;
        }
        set
        {
            this.pROFESSIONField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PROFESSIONNAME
    {
        get
        {
            return this.pROFESSIONNAMEField;
        }
        set
        {
            this.pROFESSIONNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string POSITION
    {
        get
        {
            return this.pOSITIONField;
        }
        set
        {
            this.pOSITIONField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string POSITIONNAME
    {
        get
        {
            return this.pOSITIONNAMEField;
        }
        set
        {
            this.pOSITIONNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERUSERID
    {
        get
        {
            return this.mANAGERUSERIDField;
        }
        set
        {
            this.mANAGERUSERIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERNAME
    {
        get
        {
            return this.mANAGERNAMEField;
        }
        set
        {
            this.mANAGERNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERDEPARTMENT
    {
        get
        {
            return this.mANAGERDEPARTMENTField;
        }
        set
        {
            this.mANAGERDEPARTMENTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERDEPARTMENTTXT
    {
        get
        {
            return this.mANAGERDEPARTMENTTXTField;
        }
        set
        {
            this.mANAGERDEPARTMENTTXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERUSERID2
    {
        get
        {
            return this.mANAGERUSERID2Field;
        }
        set
        {
            this.mANAGERUSERID2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERNAME2
    {
        get
        {
            return this.mANAGERNAME2Field;
        }
        set
        {
            this.mANAGERNAME2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERDEPARTMENT2
    {
        get
        {
            return this.mANAGERDEPARTMENT2Field;
        }
        set
        {
            this.mANAGERDEPARTMENT2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MANAGERDEPARTMENT2TXT
    {
        get
        {
            return this.mANAGERDEPARTMENT2TXTField;
        }
        set
        {
            this.mANAGERDEPARTMENT2TXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EMAIL
    {
        get
        {
            return this.eMAILField;
        }
        set
        {
            this.eMAILField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COMPANY
    {
        get
        {
            return this.cOMPANYField;
        }
        set
        {
            this.cOMPANYField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COMPANYNAME
    {
        get
        {
            return this.cOMPANYNAMEField;
        }
        set
        {
            this.cOMPANYNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EMPLOYEMENTEND
    {
        get
        {
            return this.eMPLOYEMENTENDField;
        }
        set
        {
            this.eMPLOYEMENTENDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OSID
    {
        get
        {
            return this.oSIDField;
        }
        set
        {
            this.oSIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PVALUE
    {
        get
        {
            return this.pVALUEField;
        }
        set
        {
            this.pVALUEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PNAME
    {
        get
        {
            return this.pNAMEField;
        }
        set
        {
            this.pNAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CTTYP
    {
        get
        {
            return this.cTTYPField;
        }
        set
        {
            this.cTTYPField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CTTXT
    {
        get
        {
            return this.cTTXTField;
        }
        set
        {
            this.cTTXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CBEGDA
    {
        get
        {
            return this.cBEGDAField;
        }
        set
        {
            this.cBEGDAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CENDDA
    {
        get
        {
            return this.cENDDAField;
        }
        set
        {
            this.cENDDAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FAMST
    {
        get
        {
            return this.fAMSTField;
        }
        set
        {
            this.fAMSTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FTEXT
    {
        get
        {
            return this.fTEXTField;
        }
        set
        {
            this.fTEXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CSAYI
    {
        get
        {
            return this.cSAYIField;
        }
        set
        {
            this.cSAYIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MOBIL1
    {
        get
        {
            return this.mOBIL1Field;
        }
        set
        {
            this.mOBIL1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MOBIL2
    {
        get
        {
            return this.mOBIL2Field;
        }
        set
        {
            this.mOBIL2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MOBIL3
    {
        get
        {
            return this.mOBIL3Field;
        }
        set
        {
            this.mOBIL3Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STRAS
    {
        get
        {
            return this.sTRASField;
        }
        set
        {
            this.sTRASField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LOCAT
    {
        get
        {
            return this.lOCATField;
        }
        set
        {
            this.lOCATField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ORT02
    {
        get
        {
            return this.oRT02Field;
        }
        set
        {
            this.oRT02Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STATE
    {
        get
        {
            return this.sTATEField;
        }
        set
        {
            this.sTATEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STATETXT
    {
        get
        {
            return this.sTATETXTField;
        }
        set
        {
            this.sTATETXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LAND1
    {
        get
        {
            return this.lAND1Field;
        }
        set
        {
            this.lAND1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LAND1TXT
    {
        get
        {
            return this.lAND1TXTField;
        }
        set
        {
            this.lAND1TXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ADRESTYPE
    {
        get
        {
            return this.aDRESTYPEField;
        }
        set
        {
            this.aDRESTYPEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ADRESTYPETXT
    {
        get
        {
            return this.aDRESTYPETXTField;
        }
        set
        {
            this.aDRESTYPETXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BLOOD
    {
        get
        {
            return this.bLOODField;
        }
        set
        {
            this.bLOODField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BLOODTXT
    {
        get
        {
            return this.bLOODTXTField;
        }
        set
        {
            this.bLOODTXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SLART
    {
        get
        {
            return this.sLARTField;
        }
        set
        {
            this.sLARTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STEXT
    {
        get
        {
            return this.sTEXTField;
        }
        set
        {
            this.sTEXTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CATEGORY
    {
        get
        {
            return this.cATEGORYField;
        }
        set
        {
            this.cATEGORYField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sap-com:document:sap:rfc:functions")]
public partial class ZHR_EBA_PERS_INFOResponse
{

    private ZHR_ST_EBA_PERSONEL[] pERS_DATAField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public ZHR_ST_EBA_PERSONEL[] PERS_DATA
    {
        get
        {
            return this.pERS_DATAField;
        }
        set
        {
            this.pERS_DATAField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void ZHR_EBA_PERS_INFOCompletedEventHandler(object sender, ZHR_EBA_PERS_INFOCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ZHR_EBA_PERS_INFOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal ZHR_EBA_PERS_INFOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public ZHR_EBA_PERS_INFOResponse Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((ZHR_EBA_PERS_INFOResponse)(this.results[0]));
        }
    }
}