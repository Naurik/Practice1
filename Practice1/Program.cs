using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mashimov Nauryzbai");
            Console.WriteLine("Введите числа A,B:");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("A + B = " + (numberOne+numberTwo));
            Console.ReadLine();
        }
    }
}
