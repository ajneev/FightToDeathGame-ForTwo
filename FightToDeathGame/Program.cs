using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightToDeathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Warrior maximus = new Warrior("Maximus Prime", 1000, 180, 140);

            Warrior scorpion = new Warrior("Scorpion", 1000, 180, 140);

            Battle.StartFight(maximus, scorpion);


            Console.ReadKey();
        }
    }
}
