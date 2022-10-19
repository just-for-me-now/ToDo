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

        public Note ReadNote(string ID)
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

        //public bool NewNote( string id )
        //{
        //    foreach (Note note in notes)
        //    {
        //        if (note.ID == id)
        //        {
        //            return false;
        //        }
        //    }

        //    notes.Add(new Note() {ID = id});
        //    return true;
        //}
        public void NewNote(Note nota)
        {
            notes.Add(nota);
        }
        public void ModifyDescription(string ID, string description)
        {
            foreach (Note note in notes)
            {
                if (note.ID == ID)
                {
                    note.Description = description;
                }
            }
        }
    }
}
