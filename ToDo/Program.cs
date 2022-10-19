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
            Console.ReadKey();
            DBManager db = new DBManager();
            SQLiteConnection conn = db.createConnection();
            db.CreateTable(conn);
            Console.ReadKey();
        }
    }
}
