using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_5
{
    class Animal
    {
        public string name;
        public string sound;

        //contructor
        public Animal()
        {
            name = "no name";
            sound = "no sound";
            numOfAnimals++;//increase number of animals by one at construction
        }

        public Animal(string name = "no name")
        {
            this.name = name;
            this.sound = "no sound";
            numOfAnimals++;//increase number of animals by one at construction
        }

        public Animal(string name = "no name",
            string sound = "no sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;//increase number of animals by one at construction

        }

        //methods (tutorial has not yet introduced getters and setters)

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        //defining a variable to have the number of animals
        static int numOfAnimals = 0;

        public static int GetNumAnimal()
        {
            return numOfAnimals;
        }
    }

}
