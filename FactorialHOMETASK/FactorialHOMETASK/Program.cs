using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactorialHOMETASK
{
    class Program
    {
        static void Main()
        {
            int a = 4;
            int factorial = 1;
            for (int x = 1; x <= a; x++)
            {
                factorial *= x;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}

