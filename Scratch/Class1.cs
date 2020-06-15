using System;

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
            Console.WriteLine(xaml);
        }
    }
}
