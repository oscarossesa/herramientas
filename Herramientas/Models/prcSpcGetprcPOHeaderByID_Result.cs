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
    
    public partial class prcSpcGetprcPOHeaderByID_Result
    {
        public string porCompromiseId { get; set; }
        public Nullable<System.DateTime> porCreationDate { get; set; }
        public string porName { get; set; }
        public string porDescription { get; set; }
        public string porNumber { get; set; }
        public string porState { get; set; }
        public string pssName { get; set; }
        public Nullable<System.DateTime> porSendDate { get; set; }
        public Nullable<int> porShipAddress { get; set; }
        public Nullable<int> porPaymentMethod { get; set; }
        public string porUser { get; set; }
        public Nullable<int> porSourceDocumentNumber { get; set; }
        public Nullable<int> potCode { get; set; }
        public string potAbbreviationCode { get; set; }
        public Nullable<int> porSellerStatus { get; set; }
        public Nullable<double> porTotalCharges { get; set; }
        public Nullable<double> porTotalDiscounts { get; set; }
        public Nullable<double> porTotalTaxes { get; set; }
        public Nullable<double> porTotalAmount { get; set; }
        public Nullable<int> porSourceDocumentNumber1 { get; set; }
        public string porSellerOrganization { get; set; }
        public Nullable<int> porShipmentType { get; set; }
        public string porDiscountsComments { get; set; }
        public string porChargesComments { get; set; }
        public Nullable<int> porTaxCode { get; set; }
        public Nullable<double> porPercentTaxes { get; set; }
        public string porCurrency { get; set; }
        public string porBuyerOrganization { get; set; }
        public Nullable<System.DateTime> porDateDelivery { get; set; }
        public string porFinanciamiento { get; set; }
        public Nullable<int> porBuyerStatus { get; set; }
        public int porOrderType { get; set; }
    }
}