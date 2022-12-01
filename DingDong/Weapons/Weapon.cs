using System;
using System.Collections.Generic;
using System.Text;

namespace DingDong.Weapons
{
    class Weapon
    {
        string name;
        double weight;
        double length;

        protected Weapon(string name)
        {
            this.name = name;
        }

        protected virtual int Attack(char c, string monsterShout)
        {
            return 0;
        }
    }
}
