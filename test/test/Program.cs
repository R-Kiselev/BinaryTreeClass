using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new object[] { 1, 2, "3", 4, 5 };
            var tmpValue = values.Cast<int>();
            foreach (var str in tmpValue)
            { Console.Write(str); }
        }
       
    }
}
