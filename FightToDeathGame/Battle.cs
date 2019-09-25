using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightToDeathGame
{
    class Battle
    {

        // Start Fight Warrior1, Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        //GetAttackResult WarriorA WarriorB
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttackAmt = warriorA.Attack();
            double warriorBBlockAmt = warriorB.Block();

            double dmgToWarriorB = warriorAAttackAmt - warriorBBlockAmt;

            if (dmgToWarriorB > 0)
            {
                warriorB.Health = warriorB.Health - dmgToWarriorB;
            }
            else dmgToWarriorB = 0;

            Console.WriteLine("{0} attacks {1} and deals with {2} damage", warriorA.Name, warriorB.Name, dmgToWarriorB);

            Console.WriteLine("{0} has {1} health left", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {

                Console.WriteLine("{0} has died and {1} wins!!", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else
            {
                Console.WriteLine("{0} Attacks now\n", warriorB.Name);
                return "Fight Again";
            }
        }
    }
}
