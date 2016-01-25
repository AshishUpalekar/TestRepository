using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning8.Models
{
    interface ICustomPipelineProcessor
    {

        void Process(CustomPipelineArgs args);
    }
}
