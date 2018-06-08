using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_6
{
    class TutorialSix
    {
        static void Main()
        {
            //create object Animal
            Animal cat = new Animal();

            ///setting properties to the object
            cat.setName("Hannah");
            cat.Sound = "Meow";//properties made it more readble

            //printing contents of the object to check if everything is righht
            Console.WriteLine("the cat is named {0} and says {1}", cat.getName(), cat.Sound);

            //testing owner property
            cat.Owner = "Diogo";
            Console.WriteLine("{0} owner is {1}", cat.getName(), cat.Owner);

            //testing static 
            Console.WriteLine("{0} shelter id is {1}", cat.getName(), cat.Id);
            //testing counting
            Animal fox = new Animal("charlie");
            Console.WriteLine("Number of animals : {0}", Animal.NumofAnimals);

            //to prevent console to close
            Console.ReadLine();
        }
    }
}
