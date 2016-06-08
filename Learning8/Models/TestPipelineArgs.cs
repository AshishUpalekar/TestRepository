using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning8.Models
{
    public class TestPipelineArgs : PipelineArgs
    {
        public string testProp1 { get; set; }

        public string testProp2 { get; set; }
    }
}