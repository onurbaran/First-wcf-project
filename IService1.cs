using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IVRDataService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetUserLogData(string tel_no);
    }
}
