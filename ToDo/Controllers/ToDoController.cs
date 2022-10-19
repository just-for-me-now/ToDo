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
            Note note = new Note();
            note.ID = ID;   

            return note;
        }
    }
}
