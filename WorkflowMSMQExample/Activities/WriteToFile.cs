using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.IO;

namespace WorkflowMSMQExample.Activities
{

    public sealed class WriteToFile : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<LogRequest> LogRequest { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            LogRequest logRequest = context.GetValue(this.LogRequest);

            using (StreamWriter w = File.AppendText("c:\\temp\\WorkflowMSMQExample.log"))
            {
                w.WriteLine("{0}:{1} - {2}", logRequest.DateTime, logRequest.Title, logRequest.Message);
           }
        }
    }
}
