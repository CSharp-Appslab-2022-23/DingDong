using System;
using System.Collections.Generic;

namespace DingDong
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] dingDongEnergies = Console.ReadLine().Split(' ');
            var dingEnergy = int.Parse(dingDongEnergies[0]);
            var dongEnergy = int.Parse(dingDongEnergies[1]);
            string monsterShout = Console.ReadLine().ToUpper();

            var totalEnergyUsed = 0;

            var alreadyProcessedChars = new List<char>();
            foreach (char c in monsterShout)
            {
                if (c == 'A' || alreadyProcessedChars.Contains(c))
                {
                    continue;
                }

                alreadyProcessedChars.Add(c);

                var cCount = 0;
                foreach (char t in monsterShout)
                {
                    if (c == t)
                    {
                        cCount++;
                    }
                }

                int cDingPrice = cCount * dingEnergy;
                int cDongPrice = ((int)c - (int)'A') * dongEnergy;

                totalEnergyUsed += Math.Min(cDingPrice, cDongPrice);
            }

            Console.WriteLine(totalEnergyUsed);
        }
    }
}
