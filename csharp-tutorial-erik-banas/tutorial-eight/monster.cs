using System;

namespace csharp_tutorial_8
{
    class Monster:Caracter
    {
        //GAME RULE: monsters have a difference : type
        private string type;

        //setting up the basic constructor. Is not public because is a base for the default constructor
        Monster(string name, int health,string type, int attackPower, int defense) : base(name, health, attackPower, defense) { Type = type; }
        
        //default constructor
        //GAME RULE: every Warior has the same health and defense
        public Monster(string name, int health, string type) : this(name, health,type, 10, 5) { }

        //getter and setter for type
        public string Type
        {
            get { return type; }
            set {  type = value; }
        }
        //methods
        //randomly picks a number as the Warrior attack (damage on the enemy)
        override public int Attack()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }

        override public int Defense()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }
    }//end of class Monster
}//end of namespace

