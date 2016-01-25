using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning8.Models
{
    public class Entity
    {
        public int StepNo { get; set; }
        public string Title { get; set; }
        public bool Success { get; set; }
        public string data1 { get; set; }
        public string data2 { get; set; }

        List<Entity> entityList = null;


        public Entity(int stepNo, string title,bool success)
        {
            this.StepNo = stepNo;
            this.Title = title;
            this.Success = success;
        }


        public Entity()
        {
            entityList = new List<Entity>() {new Entity(StepNo=1,Title="a",Success=false), new Entity(StepNo = 2, Title = "b", Success = false) };
        }

        public List<Entity> GetEntityList()
        {
            return entityList;
        }

        public Entity GetEntity(int index)
        {
            return entityList[index];
        }

    }
}