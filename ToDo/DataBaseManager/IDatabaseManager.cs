using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.DataBaseManager
{
    public interface IDatabaseManager
    {
        Note requestNoteFromDatabase(int id);
        IList<Note> requestAllData();
        void saveNoteToDatabase(Note note);
        void updateNoteIntoDatabase(int id, Note noteData);
        void deleteNoteFromDatabase(int id);
    }
}
