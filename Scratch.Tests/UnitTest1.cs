using System;
using Xunit;
using Scratch;

namespace Scratch.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            class1.RunXamlWorkflow();
        }
    }
}
