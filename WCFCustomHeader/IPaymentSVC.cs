using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFCustomHeader.Models;

namespace WCFCustomHeader
{
    [ServiceContract]
    public interface IPaymentSVC
    {
        [OperationContract]
        PayingResponse GetPayment(PayingTransaction dt);
    }
}
