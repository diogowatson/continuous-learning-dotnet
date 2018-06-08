using System;

namespace csharp_tutorial_8
{
    //test class for Warrior class
    //tested and workig as expected

    class TestWarrior
    {
        public static void Main()
        {
            Warrior warrior = new Warrior("Hagar", 34);
            Hero hero = new Hero("Conan", 45);
            Monster monster = new Monster("Sauron", 40, "Mage");

            //hold the atacks in variables
            int warriorAttack = warrior.Attack();
            int warriorDefense = warrior.Defense();
            int heroAttack = hero.Attack();
            int herodefense = hero.Defense();
            int monsterAttack = monster.Attack();
            int monsterDefense = monster.Defense();

            Console.Write($"the name of the Warrior is {warrior.Name}. His health is {warrior.Health}. \n" +
                          "Attack = {0} \n" +
                          "defense = {1}\n", warriorAttack, warriorDefense);

            Console.Write($"the name of the hero is {hero.Name}. His health is {hero.Health}. \n" +
                          "Attack = {0} \n" +
                          "defense = {1}\n", heroAttack, herodefense);

            Console.Write($"the name of the Warrior is {monster.Name}. His health is {monster.Health}. \n" +
                          "Attack = {0} \n" +
                          "defense = {1}\n", monsterAttack, monsterDefense);


            //the only function of this line is to prevent the console from closing
            Console.ReadLine();
        }
    }
}
