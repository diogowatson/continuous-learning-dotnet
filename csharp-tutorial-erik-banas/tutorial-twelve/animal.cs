using System;

namespace csharp_tutorial_12
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name = "No Name")
        {
            Name = name;
        }

        //generics

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dlbX = Convert.ToDouble(num1);
            double dlbY = Convert.ToDouble(num2);
            Console.WriteLine($"{dlbX} + {dlbY} = {dlbX + dlbY}");

        }

    }//end of class Animal
}
