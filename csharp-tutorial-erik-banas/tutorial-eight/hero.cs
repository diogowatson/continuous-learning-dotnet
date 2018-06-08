using System;

namespace csharp_tutorial_8
{
    //GAME RULE: Heroes have more attack and defense number than warriors
    //GAME RULE: Heroes attacks and defense start with bigger numbers
    
    class Hero:Caracter
    {
        //setting up the basic constructor. not public as is a base for the default constructor
        Hero(string name, int health, int attackPower, int defense) : base(name, health, attackPower, defense) { }
        
        //default constructor
        //GAME RULE: every Warrior has the same attack and defense
        public Hero(string name, int health) : this(name, health, 15, 8) { }

        //methods
        //randomly picks a number as the Warrior attack (damage on the enemy)
        override public int Attack()
        {
            Random random = new Random();
            return random.Next(5, 15);
        }

        override public int Defense()
        {
            Random random = new Random();
            return random.Next(3, 8);
        }
    }//end of caracter class
}//end of namespace

