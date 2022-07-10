using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;
            double num7;
            double num8;
            Console.WriteLine("Enter 2 numbers to get the result of multiplication");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            Calc c1 = new Calc(num1, num2);
            c1.printMulti();
            Console.WriteLine("Enter 2 numbers to get the result of Subtract");
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());
            Calc c2 = new Calc(num3, num4);
            c2.printsub();
            Console.WriteLine("Enter 2 numbers to get the result of summation ");
            num5 = double.Parse(Console.ReadLine());
            num6 = double.Parse(Console.ReadLine());
            Calc c3 = new Calc(num5, num6);
            c3.printadd();
            num7 = double.Parse(Console.ReadLine());
            num8 = double.Parse(Console.ReadLine());
            Calc c4 = new Calc(num7, num8);
            c4.printdiv();

        }
    }
}
