using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public enum Priority
    {
        High,
        Medium,
        Low
    }
    public class Note
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Created { get; set; }
        public string EstimatedCompletion { get; set; }
        public string DateOfCompletion { get; set; }
        public string Link { get; set; }
        public List<string> Mentions { get; set; }
        public Priority Priority { get; set; }
        


        //ID = "123",
        //        Description = "Money expenses",
        //        Text = "To be paid to Kentucky Chicken Wings: 2000€",
        //        Created = "2020-01-01",
        //        EstimatedCompletion = "2023-01-01",
        //        DateOfCompletion = "",
        //        Link = "",
        //        Mentions = null,
        //        Priority = NotePriorities.High

    }

}
