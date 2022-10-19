using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DataBaseManager;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nota = new Note();
            nota.Text = "buenas tardes";

            DBManager manager = new DBManager();
            manager.requestAllData();
            //DBManager_old db = new DBManager_old();
            //SQLiteConnection conn = db.createConnection();
            //db.insertData(conn, nota);

            Console.ReadKey();
        }
    }
}
