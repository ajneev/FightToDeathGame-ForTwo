using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightToDeathGame
{
    class Warrior
    {
        // Warror will have a Name Health  AttackMaximum BlockMaximum
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;

        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        //Random number for Attack and Block - single instance and reuse it
        Random rnd = new Random();


        //Setting Constructor
        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}