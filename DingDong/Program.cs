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

            Warrior merlin = new Warrior(dingEnergy, dongEnergy);
            Monster godzilla = new Monster(monsterShout);
            int totalEnergyUsed = merlin.Kill(godzilla);

            Console.WriteLine(totalEnergyUsed);
        }
    }
}
