using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WCFCustomHeader.Models
{
    [MessageContract]
    public class PayingResponse
    {
        [MessageHeader(Name = "UserId")]
        public Guid UserId;

        [MessageBodyMember(Name = "Success")]
        public bool Success;

    }
}