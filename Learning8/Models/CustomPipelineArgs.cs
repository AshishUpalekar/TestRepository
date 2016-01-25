using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Pipelines;

namespace Learning8.Models
{
    public class CustomPipelineArgs : PipelineArgs
    {
        private bool valid = false;
        private string message = string.Empty;
        private Item Item;


        public bool IsValid
        {
            get
            {
                return valid;
            }

            set
            {
                valid = value;
            }
        }


        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }


        public Item CurrItem
        {
            get
            {
                return Item;
            }

            set
            {
                Item = value;
            }
        }

        public CustomPipelineArgs(Item item)
        {
            Item = item;
        }
    }
}