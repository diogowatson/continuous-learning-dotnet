using System;

namespace csharp_tutorial_7
{
    class Tutorial_seven
    {
        static void Main(string[] argv)
        {
            Animal Gegis = new Animal()
            {
                Name = "Gegis",
                Sound = "Meow"
            };

            Dog Brownie = new Dog()
            {
                Name = "Brownie",
                Sound = "Barf",
                Sound2 = "WOOf"
            };

            Brownie.Sound = "Wooooooof";//assign a protected 

            Gegis.MakeSound();
            Brownie.MakeSound();

            //test Animal Info
            Gegis.SetAnimalIDInfo(123323, "Diogo Watson");
            Brownie.SetAnimalIDInfo(34343323, "Ygor");

            Gegis.GetAnimalIDnfo();
            Brownie.GetAnimalIDnfo();

            //testing inner class
            Animal.AnimalHealth getHeath = new Animal.AnimalHealth();

            Console.WriteLine("is my animal healthy : {0}",
                getHeath.HealthWeight(11, 46));

            //Polymorfism

            Animal monkey = new Animal()
            {
                Name = "happy",
                Sound = "EEE"
            };

            Animal spark = new Dog()
            {
                Name = "spark",
                Sound = "URF",
                Sound2 = "hooof"
            };
            
            //stop the console to close
            Console.ReadLine();
        }
    }//end of class
}//end of namespace
