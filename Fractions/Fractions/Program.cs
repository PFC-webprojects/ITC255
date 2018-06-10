using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction left;
            Fraction right;


            left = new Fraction("0/0");
            right = new Fraction("1/4");
            Console.WriteLine("{0} {1} {2} = {3}", left, "+", right, left + right);

            Console.WriteLine();

            left  = new Fraction("4/0");
            right = new Fraction("1/4");
            Console.WriteLine("{0} {1} {2} = {3}", left, "+", right, left + right);

            Console.ReadKey();
        }
    }
}
