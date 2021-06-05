using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCM.MIT.Web.Host.ViewModels
{
    public class ResponseModel
    {
        public string Message { get; set; }
    }
    public class RspObjModel
    {
        public object Data { get; set; }
    }
    public class RspSuccessfully
    {
        public string RequestId { get; set; }
    }
}
