using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.DataBaseManager
{
    public class DBManager
    {
       
        public SQLiteConnection createConnection()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            try
            {
                conn.Open();
            }
            catch (Exception)
            {

               
            }
            return conn;
        }

        public void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand cmd;
            string tableOne = "CREATE TABLE notes(id INT, description VARCHAR(255), text VARCHAR(255), createdDate VARCHAR(255), " +
                "estimatedCompletion VARCHAR(255), dateOfCompletion VARCHAR(255), link VARCHAR(255), mentions VARCHAR(255), priority INT);";
            cmd = conn.CreateCommand();
            cmd.CommandText = tableOne; 
            cmd.ExecuteNonQuery();
        }
        public void insertData(SQLiteConnection conn)
        {
            SQLiteDataReader reader;
            SQLiteCommand cmd = conn.CreateCommand();
            // cmd.CommandText = "SHOW TALBES LIKE '%notes%'";
            cmd.CommandText = "SHOW TABLES LIKE 'notes'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string myReader = reader.GetString(0);

            }
            conn.Close();
        }
        //public static bool checkTable(SQLiteConnection conn)
        //{
        //    SQLiteCommand cmd;
        //    string check = "SELECT * FROM notes;";
        //    cmd = conn.CreateCommand();
        //    cmd.CommandText = check;
        //    cmd.ExecuteNonQuery();
        //}
    }
}
