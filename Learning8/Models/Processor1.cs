using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning8.Models
{
    public class Processor1 : ICustomPipelineProcessor
    {
        public void Process(CustomPipelineArgs args)
        {
            if (args.CurrItem["date"] == string.Empty)
            {
                args.IsValid = false;
                args.Message = "Date has not been set";
            }
        }
    }
}