using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation x = new Equation();
            x.k = -10;
            x.b = 30;
            x.Root();
            Console.ReadKey();
        }
        struct Equation
        {
            public double k;
            public double b;
            public void Root()
            {
                Console.WriteLine(-(b / k));
            }
        }
    }
}
