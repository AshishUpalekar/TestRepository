using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning8.Models
{
    public class EventDemo2
    {
        public void OnMyCustomSaveEventAction(Object sender, EventArgs e)
        {
            var pipelineArgs = new TestPipelineArgs();
            CorePipeline.Run("somePipeline", pipelineArgs);
            
        }
    }
}