using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFCustomHeader.Context;
using WCFCustomHeader.Models;
using WCFCustomHeader.Services.Abstract;

namespace WCFCustomHeader
{
    public class PaymentSVC : IPaymentSVC
    {
        public PayingResponse GetPayment(PayingTransaction dt)
        {
            PayingResponse response = new PayingResponse();

            response.UserId = dt.UserId;
            response.Success = true;

            return response;
        }
    }
}
