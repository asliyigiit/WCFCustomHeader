using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using WCFCustomHeader.Models;
using WCFCustomHeader.Services.Abstract;

namespace WCFCustomHeader.Services.Concrete
{
    public class SaleService : ISaleService
    {
        public PaymentDetail GetPayment(PayingTransaction model)
        {
            return model.paymentDetail;
        }

    }
}