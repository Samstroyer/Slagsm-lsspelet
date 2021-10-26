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
            Console.WriteLine($"{champion} in this universe as the master is contested by the {contestor}! It is time to battle!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            while (championHp > 0 && contestorHp > 0)
            {
                int championAttack = generator.Next(minDMG, maxDmg);
                championRolls.Add(championAttack);
                int contestorAttack = generator.Next(minDMG, maxDmg);
                contestorRolls.Add(contestorAttack);

                championHp -= contestorAttack;
                contestorHp -= championAttack;
            }

            Console.WriteLine("These are the Contestors damage rolls:");
            foreach (int roll in contestorRolls)
            {
                Console.WriteLine(roll);
            }
            Console.WriteLine("These are the Champions damage rolls:");
            foreach (int roll in championRolls)
            {
                Console.WriteLine(roll);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine("The fight has ended!");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("And the winner is:");
            if ((championHp < 0) && (contestorHp < 0))
            {
                Console.WriteLine("Actually nobody! It was a draw as both skulls were split on site.");
            }
            else if (contestorHp < 0)
            {
                Console.WriteLine($"Champion {champion} is the winner, {champion} is actually unkillable!");
            }
            else
            {
                Console.WriteLine($"The contestor, {contestor}, was able to slaughter the champion, {champion}.\nThis was a sad day really!");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
