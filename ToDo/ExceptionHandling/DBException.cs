using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.ExceptionHandling
{
    public class DBException : Exception
    {
       
        public DBException() : base($"Error al conectar con la Base de datos de SQLite") { }
    }
}
