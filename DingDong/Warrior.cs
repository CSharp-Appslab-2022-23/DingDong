using System;
using System.Collections.Generic;
using DingDong.Weapons;

namespace DingDong
{
    class Warrior
    {
        private readonly int dingEnergy;
        private readonly int dongEnergy;

        private readonly Sword sword;
        private readonly Hammer hammer;

        public Warrior(int dingEnergy, int dongEnergy)
        {
            this.dingEnergy = dingEnergy;
            this.dongEnergy = dongEnergy;

            sword = new Sword();
            hammer = new Hammer();
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

                int swordAttackPrice = sword.Attack(c, monster.Shout) * dingEnergy;
                int hammerAttackPrice = hammer.Attack(c, monster.Shout) * dongEnergy;

                totalEnergyUsed += Math.Min(swordAttackPrice, hammerAttackPrice);
            }

            return totalEnergyUsed;
        }
    }
}
