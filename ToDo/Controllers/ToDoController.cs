using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Controllers
{
    public class ToDoController
    {
        public Note ReadNote(string ID)
        {
            return new Note() { ID = ID};
        }
    }
}
