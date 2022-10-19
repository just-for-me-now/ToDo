using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Controllers
{
    public class ToDoController
    {
        IList<Note> notes;

        public ToDoController()
        {
            notes = new List<Note>();
        }

        public Note ReadNote(int ID)
        {
            foreach(Note note in notes)
            {
                if(note.ID == ID)
                {
                    return note;
                }
            }
            return null;
        }

        public void NewNote(Note nota)
        {
            notes.Add(nota);
        }

        public void ModifyDescription(int ID, string newDescription)
        {
            foreach (Note note in notes)
            {
                if (note.ID == ID)
                {
                    note.Description = newDescription;
                }
            }
        }

        public void ModifyText(int ID, string newText)
        {
            foreach (Note note in notes)
            {
                if (note.ID == ID)
                {
                    note.Text = newText;
                }
            }
        }
    }
}
