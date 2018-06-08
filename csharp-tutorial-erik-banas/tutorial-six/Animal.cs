using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_6
{
    //this class is used in tutorial 6
    //since already have an animal class 
    //is called Animal
    class Animal
    {
        private string name;
        private string sound;
        private int idNUm;// set in the last minute

        public void MakeSound()
        {
            Console.WriteLine("{0} says { 1}", name, sound);
        }

        public Animal(string name, string sound)
        {
            setName(name);
            Sound = sound;//using properties

            NumofAnimals = 1;

            //setting an random id number
            Random rnd = new Random();
            Id = rnd.Next(1, 1223123123);
        }

        public Animal():this("No name", "No Sound"){}

        public Animal(string name):this(name,"No Sound"){}

        //setters and getters

        public void setName(string name)
        {
            //better ways to check it further ahead in the tutorial
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("name can't contain numbers");
            }
        }

        public string getName() { return this.name; }
        //different methods to the same solution
        
            //setting properties
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }

        public int Id
        {
            get { return idNUm; }
            set { idNUm = value; }
        }
        //define setters and getters
        public string Owner { get; set; } = "No owner";

        public static int numOfAnimals = 0;

        public static int NumofAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }//end of Animal
}
