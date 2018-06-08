using csharp_tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_5
{
    class TutorialFive
    {
       static void Main(string[] argv)
        {   
            //structs
            //create the object, assign values, print it
            Rectangle rect1;
            rect1.lenght = 200;
            rect1.width = 50;
            Console.WriteLine("Area of react 1 : {0}",
                rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);

            rect2 = rect1;
            rect1.lenght = 33;

            Console.WriteLine("Area of rectan 2 : {0}",
                rect2.lenght);

            //classes - teh main diference between structs is that 
            //classes has inerithence
            //this exist only for stopping the console from opening

            Animal fox = new Animal()
            {
                name = "red",
                sound = "raww"
            };

            Animal cat = new Animal("Hannah", "meow");

            fox.MakeSound();
            cat.MakeSound();

            Console.WriteLine("# of animals : {0}", Animal.GetNumAnimal());
            
            //using shapeMath class

            Console.WriteLine("area of rectangle  {0}",
                ShapeMath.GetArea("rectangle", 5, 5));
            //null
            int? randNum = null; //need ? to be assigned 
            //check if is null
            if(randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            Console.ReadLine();
        }
    }
    
    
    
   
}
