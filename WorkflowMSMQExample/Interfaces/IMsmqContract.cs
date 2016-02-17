using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowMSMQExample.Interfaces
{
    [ServiceContract]
    public interface IMsmqContract
    {
        [OperationContract(IsOneWay = true)]
        void Log(LogRequest logRequest);
    }
}
