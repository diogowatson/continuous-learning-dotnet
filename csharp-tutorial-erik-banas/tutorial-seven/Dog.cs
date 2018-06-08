using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_7
{
    class Dog : Animal
    {
        //automatic set Grr as default sound
        public string Sound2 { get; set; } = "Grr";

        public Dog(string name = "No Name",
                   string sound = "No Sound",
                   string sound2 = "No Sound 2")
                   :base(name,sound)//inerith methods from base class
        {
            Sound2 = sound2;//assign sound2 created in Dog class
        }

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
    }//end of class Dog
}//end of namespace
