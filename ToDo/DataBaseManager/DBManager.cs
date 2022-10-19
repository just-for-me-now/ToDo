using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.ExceptionHandling;

namespace ToDo.DataBaseManager
{
    public class DBManager : IDatabaseManager
    {
        SQLiteConnection conn;
        public DBManager()
        {
            try
            {
                conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
                conn.Open();
            }
            catch (Exception)
            {
                throw new DBException();
                //throw new SQLiteException("No se ha podido conectar a la base de datos");
            }
            
        }
        public IList<Note> requestAllData()
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM notes;";
            SQLiteDataReader dr = cmd.ExecuteReader();
            List<Note> notillas = new List<Note>();
            while (dr.Read())
            {
                string line = dr.GetString(3);
                Console.WriteLine(line);
            }
            return notillas;
        }

        void IDatabaseManager.deleteNoteFromDatabase(int id)
        {
            throw new NotImplementedException();
        }

        Note IDatabaseManager.requestNoteFromDatabase(int id)
        {
            throw new NotImplementedException();
        }

        void IDatabaseManager.saveNoteToDatabase(Note nota)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            string mentionsSerialized = "";
            // cmd.CommandText = "SHOW TALBES LIKE '%notes%'";
            //cmd.CommandText = "SHOW TABLES LIKE 'notes'";
            try
            {
                mentionsSerialized = nota.Mentions.Aggregate("", (string a, string b) => { return a + " " + b; });
            }
            catch (Exception)
            {

            }
            cmd.CommandText = $"INSERT INTO notes VALUES({nota.ID},'{nota.Description}','{nota.Text}','{nota.CreatedDate.ToString()}','{nota.EstimatedCompletion.ToString()}','{nota.DateOfCompletion.ToString()}','{nota.Link}','{mentionsSerialized}',{(int)nota.Priority});";
            cmd.ExecuteNonQuery();
        }

        void IDatabaseManager.updateNoteIntoDatabase(int id, Note noteData)
        {
            throw new NotImplementedException();
        }
    }
}
