using System;
using System.Threading;

namespace csharp_tutorial_8
{
    //like the name says is were the fights happen!!
    class Arena
    {
        public Arena() { }

        //4 types of fight (Heroes can't fight Heroes and monsters can't fight monsters)
        //Warrior vs Warrior
        //Warrior vs monster
        //Hero vs Warrior
        //Hero vs monster

        public void Fight(ref CaracterInterface playerOne, ref CaracterInterface playerTwo )
        {
            do
            {
                if(playerOne is Warrior && playerTwo is Warrior)
                {
                    Warrior1AtackWarrior2First(ref playerOne, ref playerTwo);

                }else if(playerOne is Hero && playerTwo is Warrior)
                {
                    HeroAttackWarriorFirst(ref playerOne, ref playerTwo);
                    
                }else if(playerOne is Warrior && playerTwo is Monster)
                {
                    WarriorAttackMonsterFirst(ref playerOne, ref playerTwo);

                }else if(playerOne is Hero && playerTwo is Monster)
                {
                    HeroAttackMonsterFirst(ref playerOne, ref playerTwo);

                }

            } while (Winner(playerOne, playerTwo) == 0);

            if(Winner(playerOne, playerTwo) == 1)
            {
                Console.WriteLine("{0} won the fight against {1}!!!", playerOne.GetName(), playerTwo.GetName());
            }
            else
            {
                Console.WriteLine("{0} won the fight against {1}!!!", playerTwo.GetName(), playerOne.GetName());
            }

        }
         
        public void Warrior1AtackWarrior2First(ref CaracterInterface warrior1, ref CaracterInterface warrior2)
        {
            //warrior 1 attack
            warrior1.Attack(ref warrior2);
            //warrior 2 attack
            warrior2.Attack(ref warrior1);

            //if anyone isn't dead show Health
            AliveOrDead(warrior1, warrior2);
        }

        public void WarriorAttackMonsterFirst(ref CaracterInterface warrior, ref CaracterInterface monster)
        {
            warrior.Attack(ref monster);
            monster.Attack(ref warrior);

            AliveOrDead(warrior, monster);
        }    

        public void HeroAttackWarriorFirst(ref CaracterInterface hero, ref CaracterInterface warrior)
        {
            hero.Attack(ref warrior);
            hero.Attack(ref hero);

            AliveOrDead(hero, warrior);
        }

        public void HeroAttackMonsterFirst(ref CaracterInterface hero, ref CaracterInterface monster)
        {
            hero.Attack(ref monster);
            monster.Attack(ref hero);

            AliveOrDead(hero, monster);
        }
        
        public void AliveOrDead(CaracterInterface caracterOne, CaracterInterface caracterTwo)
        {
            if (caracterOne.GetHealth() > 0 && caracterTwo.GetHealth() > 0)
            {
                Console.WriteLine("{0} Health : {1}",caracterOne.GetName(), caracterOne.GetHealth());
                Console.WriteLine("{0} Health : {1}", caracterTwo.GetName(), caracterTwo.GetHealth());
                Thread.Sleep(1000);
            }
            else if (caracterOne.GetHealth() <= 0)
            {
                Console.WriteLine("{0} is dead!!", caracterOne.GetName());
            }
            else if (caracterTwo.GetHealth() <= 0)
            {
                Console.WriteLine("{0} is dead!!", caracterTwo.GetName());
            }
        }

        public int Winner(CaracterInterface playerOne, CaracterInterface playerTwo)
        {
            //return 1 if player one is the winerif returns zero both players are alive
            if(playerTwo.GetHealth() <=0)         {
                return 1;
            }
            else if (playerOne.GetHealth() <= 0)
            {
                //return 2 if player2 is the winner
                return 2;
            }
            //return 1 if both players are alive
            return 0;
        }

    }//end of class

}//end of Namespace
