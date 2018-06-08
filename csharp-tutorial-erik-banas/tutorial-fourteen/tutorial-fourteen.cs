using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_14
{
    class TutorialFourteen
    {
        public static void Main()
        {
            AnimalFarm myanimals = new AnimalFarm();

            myanimals[0] = new Animal("Wilbur");
            myanimals[1] = new Animal("Gegis");
            myanimals[2] = new Animal("Martha");
            myanimals[3] = new Animal("Piglet");

            foreach(Animal i in myanimals)
            {
                Console.WriteLine(i.Name);
            }

            //testing the operator overload
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;

            Console.WriteLine($"Box 3 : {box3}");

            //create an anoymus class
            var shopkins = new
            {
                Name = "shopkins",
                Price = 4.99
            };

            Console.WriteLine("{0} cost ${1}",shopkins.Name, shopkins.Price);

            var productArray = new[] { new
            {
                Name = "CoCa pack", Price = 1.99 },
                new {Name = "Fritas", Price = 7.99}
            };

            //loop throght it

            foreach(var item in productArray)
            {
                Console.WriteLine("{0} costs {1}", item.Name, item.Price);

            }
            //prevent console from closing
            Console.ReadLine();
        }//end of main class
    }//end of tutorial class

    internal class Box
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box() : this(1, 1, 1) { }

        public Box(double l, double w, double b)
        {
            Lenght = l;
            Width = w;
            Breadth = b;
        }

        //operator overloading

        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Lenght = box1.Lenght + box2.Lenght,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };

            return newBox;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Lenght = box1.Lenght - box2.Lenght,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if((box1.Lenght == box2.Lenght)&&
                (box1.Width == box2.Width)&&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Lenght != box2.Lenght) &&
                (box1.Width != box2.Width) &&
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //string overridding (prety much similar as Java toString)
        public override string ToString()
        {
            return String.Format("Box with Height : {0} Width : {1} and Breadth : {2}",
                Lenght, Width, Breadth);
        }

    }//end of class Box
   
}
