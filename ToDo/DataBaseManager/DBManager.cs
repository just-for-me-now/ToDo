using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.DataBaseManager
{
    public class DBManager : IDatabaseManager
    {
        void IDatabaseManager.deleteNoteFromDatabase(int id)
        {
            throw new NotImplementedException();
        }

        Note IDatabaseManager.requestNoteFromDatabase(int id)
        {
            throw new NotImplementedException();
        }

        void IDatabaseManager.saveNoteToDatabase(Note note)
        {
            throw new NotImplementedException();
        }

        void IDatabaseManager.updateNoteIntoDatabase(int id, Note noteData)
        {
            throw new NotImplementedException();
        }
    }
}
