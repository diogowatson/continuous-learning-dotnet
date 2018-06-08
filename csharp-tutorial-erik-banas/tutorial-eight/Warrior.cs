using System;

namespace csharp_tutorial_8
{
    class Warrior:Caracter
    {
        //setting up the basic constructor. Is public because is a base for the default constructor
        Warrior (string name, int health, int attackPower, int defense):base(name, health, attackPower, defense) { }
        
        //default constructor
        //GAME RULE: every Waarior has the same health and defense
        public Warrior(string name, int health) : this(name, health, 10, 5) {}

        //methods
        //randomly picks a number as the Warrior attack (damage on the enemy)
        override public int Attack()
        {
            Random random = new Random();
            return random.Next(3, 10);
        }

        override public int Defense()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }
    }//end of class Warrior
}//end of namespace
