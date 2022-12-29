using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Web;
using System.Web.Services.Description;

namespace WCFCustomHeader.Models
{
    [MessageContract]
    public class PayingTransaction
    {
        [MessageHeader(Name = "UserId")]
        public Guid UserId;

        [MessageHeader(Name = "Password")]
        public String Password;

        [MessageHeader(Name = "Version")]
        public String Version;
        [MessageHeader]
        public DateTime transactionDate;
        [MessageBodyMember] public PaymentDetail paymentDetail;
    }
    [DataContract]
    public class PaymentDetail
    {
        [DataMember]
        public int PaymentType { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string CardMumber { get; set; }        
    }

    public enum PaymentType
    {
        Cash=1,
        CreditCard=2
    }
}