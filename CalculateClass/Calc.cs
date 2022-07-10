using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateClass
{

   

    internal class Calc
    {
        double number1 = 0;
        double number2 = 0;

        public Calc(double number1 = 0, double number2 =0)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public double add()
        {
            return number1 + number2;

        }
        public void printadd()
        {
            Console.WriteLine("Your Resualt");
            Console.WriteLine("============================");
            Console.WriteLine(add());
            Console.WriteLine("============================");
        }

        public double sub()
        {
            return (number1 - number2);
        }

        public void printsub()
        {
            Console.WriteLine("Your Resualt");
            Console.WriteLine("============================");
            Console.WriteLine(sub());
            Console.WriteLine("============================");
        }

        public double div()
        {

            if (number2 == 0)
                number2 = 1;
            return (number1 / number2);
        }

        public void printdiv()
        {
            Console.WriteLine("Your Resualt");
            Console.WriteLine("============================");
            Console.WriteLine(div());
            Console.WriteLine("============================");
        }

        public double Multi()
        {

            return (number1 * number2);
        }
        public void printMulti()
        {
            Console.WriteLine("Your Resualt");
            Console.WriteLine("============================");
            Console.WriteLine(Multi());
            Console.WriteLine("============================");
        }

        public int SumIntArray(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public void PrintSumIntArray(int[] numbers)
        {
            Console.WriteLine(SumIntArray(numbers));
        }
        /* ========Use it =========
       int[] nums1 = { 10, 20, 30, 40, 50 };
       int[] nums2 = { 60, 70, 80, 100 };
       Calc cSum = new Calc(0, 0);
       cSum.PrintSumIntArray(nums1);
       Console.WriteLine(cSum.SumIntArray(nums2));
       */

        public double[] GetCalcTwoArray(double[]Arr1,double[]arr2, char ope)
            {


            /*
            double[] i1 = { 10,6,8};
            double[] i2 = { 4, 5, 6 };
            Calc cCalc1 = new Calc();
            cCalc1.PrintCalcTwoArrays(i1 ,i2, '+' );
            cCalc1.PrintCalcTwoArrays(i1 ,i2, '-' );
            cCalc1.PrintCalcTwoArrays(i1 ,i2, '*' );
            cCalc1.PrintCalcTwoArrays(i1 ,i2, '/' );
            */



            if (Arr1.Count() != arr2.Count()) 
            {
                Console.WriteLine("Error: Array1 count not equal array2 count2!");
                return new double[] { 0 };
            }
            else
            {
                double[]arr3 = new double[Arr1.Count()];
                for (int i = 0; i < arr3.Count(); i++)
                {
                    if (ope== '+')
                    {
                        arr3[i] = Arr1[i] + arr2[i];
                    }
                    else if (ope== '-')
                        arr3[i] = Arr1[i] - arr2[i];
                    else if (ope== '*')
                        arr3[i] = Arr1[i] * arr2[i];
                    else if (ope== '/')
                    {
                        if(arr2[i] == 0 )
                            arr2[i] = 1;
                        arr3[i] = Arr1[i] / arr2[i];
                    }
                     
                }

            return arr3;
            }
          
        }
        public void PrintCalcTwoArrays(double[] arr1, double[] arr2, char ope)
        {
            double[] arr3 = GetCalcTwoArray(arr1, arr2, ope);
            foreach (double i in arr3)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
