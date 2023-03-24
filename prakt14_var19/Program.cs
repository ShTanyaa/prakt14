using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace prakt14_var19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Info();
            Console.WriteLine();
            dog.Zanatie();
            Console.WriteLine();
            dog.Inform();
        }
    }
}
