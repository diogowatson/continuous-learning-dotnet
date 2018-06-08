using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_7
{
    class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        //set information on animal ID
        public void SetAnimalIDInfo(int idNum,
             string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        //prints inforamation on Animal (name and ID)
        public void GetAnimalIDnfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owened by {animalIDInfo.Owner}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");

        }
        public Animal(string name, string sound)
        {
            Name = sound;
            Sound = sound;
        }
        public Animal() : this("No Name", "No Sound") { }
        public Animal(string name) : this(name, "No Sound") { }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }

        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }

        }
        //inner class wih iner function
        public class AnimalHealth
        {
            public bool HealthWeight(double height, double weight)
            {
                double calc = height / weight;

                if((calc >= .19 && (calc <= .27)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }//end of animal
}
