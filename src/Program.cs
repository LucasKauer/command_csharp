using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newton = new Mathematical();

            Console.WriteLine("Valor inicial = 0\n");

            newton.ExecuteOperation('+', 1000);
            newton.ExecuteOperation('-', 500);
            newton.ExecuteOperation('*', 2);
            newton.ExecuteOperation('/', 4);
            newton.ExecuteOperation('/', 5);
            newton.ExecuteOperation('/', 10);
            newton.ExecuteOperation('*', 3);
            newton.ExecuteOperation('+', 1);

            newton.BackOperations(5);

            newton.ExecuteOperation('*', 10);
            newton.ExecuteOperation('*', 10);

            newton.BackOperations(5);

            Console.ReadKey();
        }
    }
}
