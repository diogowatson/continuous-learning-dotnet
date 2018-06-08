using System;

namespace csharp_tutorial_8
{
    class Tutorial_eight
    {
        public static void Main()
        {
            ///now is time to fight!!

            //creating caracters
            CaracterInterface hero1 = new Hero("Aragorn", 45);
            CaracterInterface warrior1 = new Warrior("Mike the guy", 34);
            CaracterInterface warrior2 = new Warrior("Frank the guy", 34);
            CaracterInterface warrior3 = new Warrior("John the guy", 34);
            CaracterInterface monster1 = new Monster("Blargh", 45, "Orc");

            Arena arena = new Arena();
            //Console.WriteLine($"health: {warrior2.Health}");
            //warrior2.Health -= warrior1.Attack - warrior2.Defense;
            //Console.WriteLine($"health: {warrior2.Health}");
            //Console.ReadLine();

            arena.Fight(ref warrior1, ref warrior2);
            arena.Fight(ref hero1, ref warrior3);
            arena.Fight(ref hero1, ref monster1);

            Console.ReadLine();
        }
    }
}
