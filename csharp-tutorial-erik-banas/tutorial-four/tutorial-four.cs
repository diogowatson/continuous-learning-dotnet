using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass by value (not changing the variables outside the method)

            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x = {0}", x);
            //since everything is by default passed by value x remains as 5
                           
            int solution;

            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            //pass by reference (influence the local variable outside the method)

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before Swap: num1 = {0}  num2 = {1}",num1,num2);
            Swap(ref num1, ref num2); //must define that passing by reference
            Console.WriteLine("After Swap: num1 = {0}  num2 = {1}", num1, num2);

            //params
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1,2,3));

            //giving different order of params
            //as long as I define them I can use different orders for the params
            PrintInfo(zipCode: 1223, name: "Diogo Watson");

            //methods overload
            string xs = "5";
            string ys = "4";
            Console.WriteLine("5 + 4 = {0}", GetSum(xs, ys));

            //enums
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            //the only function of this line is to prevent the console from closing
            Console.ReadLine();
            
        }
        //enums
        enum CarColor : byte //default int
        {
            Orage = 1,
            Blue = 2,
            Green = 3,
            Red = 4,
            Yellow =5
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }

        //get sum overload to string
        static double GetSum(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);

            return dblX + dblY;
        }

        //print 2 params inside a pre-defined string
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        //return the sum of all values in the params
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        //swap values method (by reference)
        public static void Swap(ref int num1, ref int num2 )
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        //get a value (15) and put it out in the solution variable 
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        //simple method witch sums two pre-defined values
        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }
    }//end of class Program
}
