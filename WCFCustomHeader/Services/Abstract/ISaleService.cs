using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFCustomHeader.Models;

namespace WCFCustomHeader.Services.Abstract
{
    [ServiceContract]
    public interface ISaleService
    {
        [OperationContract]
        PaymentDetail GetPayment(PayingTransaction model);
    }
}
