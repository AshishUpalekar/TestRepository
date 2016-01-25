using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learning8.Models;
using Sitecore.Pipelines;

namespace Learning8.Controllers
{
    public class PipelineController : Controller
    {
        // GET: Default
        public void Index()
        {
            CustomPipelineArgs pipelineArgs = new CustomPipelineArgs(Sitecore.Context.Item);
            CorePipeline.Run("CustomPipeline", pipelineArgs);
            if (!pipelineArgs.IsValid && !string.IsNullOrEmpty(pipelineArgs.Message))
            {
                // Execute code here to deal with failed validation
            } 
        }
    }
}