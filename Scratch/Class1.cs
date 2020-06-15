using System;
using System.Activities.XamlIntegration;
using System.IO;

namespace Scratch
{
    public class Class1
    {
        public void RunXamlWorkflow()
        {
            var xaml = @"<Activity 
 x:Class=""WorkflowConsoleApplication1.HelloWorld""
 xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities""
 xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
  <Sequence>
    <WriteLine Text=""Hello World!"" />
  </Sequence>
</Activity>";
            var helloWorldActivity = ActivityXamlServices.Load(new StringReader(xaml));
System.Activities.WorkflowInvoker.Invoke(helloWorldActivity);
        }
    }
}
