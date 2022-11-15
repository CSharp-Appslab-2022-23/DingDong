using System;
using System.Collections.Generic;
using System.Text;

namespace DingDong
{
    class Warrior
    {
        private readonly int dingEnergy;
        private readonly int dongEnergy;

        public Warrior(int dingEnergy, int dongEnergy)
        {
            this.dingEnergy = dingEnergy;
            this.dongEnergy = dongEnergy;
        }

        internal int Kill(Monster monster)
        {
            var totalEnergyUsed = 0;

            var alreadyProcessedChars = new List<char>();
            foreach (char c in monster.Shout)
            {
                if (c == 'A' || alreadyProcessedChars.Contains(c))
                {
                    continue;
                }

                alreadyProcessedChars.Add(c);

                var cCount = CountCharOccurrences(c, monster.Shout);

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
