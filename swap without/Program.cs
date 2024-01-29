using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_without
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            a = a * b; 
            b = a / b; 
            a = a / b; 
            Console.WriteLine(a); 
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
