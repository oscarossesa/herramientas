//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Herramientas.Models
{
    using System;
    
    public partial class prcSpcGetEvaluatePOInformationBuyer_Result
    {
        public int porID { get; set; }
        public Nullable<int> porOrderType { get; set; }
        public string porCode { get; set; }
        public string porName { get; set; }
        public Nullable<System.DateTime> porCreationDate { get; set; }
        public string porBuyerNotes { get; set; }
        public Nullable<double> porTotalDiscounts { get; set; }
        public Nullable<double> porTotalTaxes { get; set; }
        public Nullable<double> porTotalCharges { get; set; }
        public string crcName { get; set; }
        public Nullable<int> pbsCode { get; set; }
        public string pbsName { get; set; }
        public string rbhExternalCode { get; set; }
        public Nullable<int> attachments { get; set; }
        public Nullable<double> TotalNet { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<double> TotalOC { get; set; }
        public string crcCode { get; set; }
    }
}