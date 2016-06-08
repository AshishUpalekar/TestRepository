using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning8.Models
{
    public class SomeProcessor
    {
        public void Process(TestPipelineArgs args)
        {
            args.testProp1 = "xyz";

            args.testProp2 = GetTestVal();
        }


        public string GetTestVal()
        {
            return "testVal";
        }
    }
}