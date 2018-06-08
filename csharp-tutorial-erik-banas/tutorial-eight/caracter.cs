using System;
using System.Linq;
using System.Threading;

namespace csharp_tutorial_8
{
    //Is not supposed to be initialize, so is abstract
    //caracters
    //caracter-->Warrior (normal health and defense)
    //caracter-->Hero (greater attack and defense)
    //caracter-->Monster (greater attack)

    abstract class Caracter : CaracterInterface
    {
        private string name;
        private int health;
        private int attackPower;
        private int defense;

        //contructors

        //base constructor ->no argument
        Caracter() { }

        //2 parameters base constructor
        Caracter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        //4 paramters constructor
        public Caracter(string name, int health, int attackP, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackP;
            DefensePower = defense;
        }

        //getters and setters
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "no name";
                }
                else
                {
                    name = value;
                }
            }
        }//end of Name set and get

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }//end of health seth and get

        public int AttackPower
        {
            get { return attackPower; }
            set
            {
                //GAME RULE: a caracter can't have an attack power superior to 30
                if (value > 30)
                {
                    throw new attackPowerException("Attack Power cant be superior to 30 for any caracter");
                }
                else
                {
                    attackPower = value;
                }

            }
        }//end of Attack property

        public int DefensePower
        {
            get { return defense; }
            set
            {
                //GAME RULE: can't be lesser than five and bigger than 15
                if (value >= 5 && value <= 15)
                {
                    defense = value;
                }
                else
                {
                    throw new defensePowerException("Any caracter can receive a defense lesser that 5 or bigger that 15");
                }
            }
        }//end of defense property

        //methods
        public abstract int Attack();
        public abstract int Defense();

        public void Attack(ref CaracterInterface enemy)
        {
            //define attack power
            int attack = attackPower - enemy.GetDefensePower();
            //subtract enemy health 
            enemy.SetHealth(enemy.GetHealth() - attack);

            Console.WriteLine($"{Name} attacked {enemy.GetName()}");
            Thread.Sleep(1000);
        }

        public void Defense(ref CaracterInterface enemy)
        {
            throw new NotImplementedException();
        }

        public int GetHealth()
        {
            return Health;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public int GetDefensePower()
        {
            return DefensePower;
        }

        public void setHealth(int health)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return Name;
        }
    }//end of class Caracter
}//end of namespace
