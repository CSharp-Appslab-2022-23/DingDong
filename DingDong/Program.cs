using System;
using System.Collections.Generic;

namespace DingDong
{
    class Program
    {
        private static void Main(string[] args)
        {
            //string[] dingDongEnergies = Console.ReadLine().Split(' ');
            //var dingEnergy = int.Parse(dingDongEnergies[0]);
            //var dongEnergy = int.Parse(dingDongEnergies[1]);
            //string monsterShout = Console.ReadLine().ToUpper();

            Warrior merlin = new Warrior();
            Monster godzilla = new Monster();
            int totalEnergyUsed = merlin.Kill(godzilla);

            Console.WriteLine(totalEnergyUsed);
        }

        private static int DingDong(int dingEnergy, int dongEnergy, string monsterShout)
        {
            var totalEnergyUsed = 0;

            var alreadyProcessedChars = new List<char>();
            foreach (char c in monsterShout)
            {
                if (c == 'A' || alreadyProcessedChars.Contains(c))
                {
                    continue;
                }

                alreadyProcessedChars.Add(c);

                var cCount = CountCharOccurrences(c, monsterShout);

                int cDingPrice = cCount * dingEnergy;
                int cDongPrice = ((int)c - (int)'A') * dongEnergy;

                totalEnergyUsed += Math.Min(cDingPrice, cDongPrice);
            }

            return totalEnergyUsed;
        }

        private static int CountCharOccurrences(char c, string monsterShout)
        {
            var cCount = 0;
            foreach (char t in monsterShout)
            {
                if (c == t)
                {
                    cCount++;
                }
            }

            return cCount;
        }
    }
}
