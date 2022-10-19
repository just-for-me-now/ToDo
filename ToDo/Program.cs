using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenos días");

            Note nota = new Note() { ID = "123" };

            Console.ReadKey();
        }
    }
}
