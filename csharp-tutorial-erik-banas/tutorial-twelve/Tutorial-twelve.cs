using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace csharp_tutorial_12//changed the namespace so it won't conflict with previous classes
{
    //tutorial 12 - Generics

    class TutorialTwelve
    { 
    
    static void Main()
        {
            List<Animal> animalList = new List<Animal>();

            //list of statandard type
            List<int> numList = new List<int>();
            numList.Add(24);//add int to list

            //add animals
            animalList.Add(new Animal() { Name = "DoDo" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "George" });

            //inser in the first index
            animalList.Insert(1, new Animal() { Name = "Joe" });

            //remove item at index 1
            animalList.RemoveAt(1);

            //get number of itens in list (in this case animals)
            Console.WriteLine("Num of animals : {0}", animalList.Count());

            //loop the list
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            int x = 4, y = 7;
            Animal.GetSum<int>(ref x, ref y);//passinga as referen as I want the original to be changed

            //as String!!
            string stringX = "5", stringY = "47";
            Animal.GetSum<string>(ref stringX, ref stringY);

            //using the generic struct (declared at the end of file)

            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.Getarea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.Getarea());

            //calling dellegates

            Arithimetic add, sub, addSub;//create objects


            add = new Arithimetic(Add);
            sub = new Arithimetic(Subtract);
            addSub = add + sub;

            Console.WriteLine($"Add 6 & 10");
            add(6, 10);

            Console.WriteLine($"Add and & Subtract {10} & {4}");
            addSub(10, 4);

            //prevent from close
            Console.ReadLine();

        }//end of Main

        //delagates 
        public delegate void Arithimetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

    }//end of class
   
    //generic struct

    public struct Rectangle<T>
    {
        private T width;
        private T lenght;

        public T Width
        {
            get { return width; }
            set { width = value; }
        }

        public T Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public Rectangle(T w, T l)
        {
            width = w;
            lenght = l;
        }

        public string Getarea()
        {
            double dblWidth = Convert.ToDouble(Width);
            double dbllenght = Convert.ToDouble(Lenght);
            return string.Format($"{Width} * {Lenght} = {dblWidth * dbllenght}");
        }

    }//end of Rectangle struct
  
}//end of namespace