using System;
using System.Collections.Generic;

namespace Slagsmålsspelet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int maxDmg = 15; int minDMG = 3;
            string champion = "Samuel"; int championHp = 100;
            string contestor = "Caleb"; int contestorHp = 100;

            List<int> championRolls = new List<int>();
            List<int> contestorRolls = new List<int>();


            Console.WriteLine("Welcome to the figther simulator where everything is chance based!");

            while (championHp > 0 && contestorHp > 0)
            {
                int championAttack = generator.Next(minDMG, maxDmg);
                championRolls.Add(championAttack);
                int contestorAttack = generator.Next(minDMG, maxDmg);
                contestorRolls.Add(contestorAttack);

                championHp -= contestorAttack;
                contestorHp -= championAttack;
            }
        }
    }
}
