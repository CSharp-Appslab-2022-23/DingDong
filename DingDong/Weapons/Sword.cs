namespace DingDong.Weapons
{
    class Sword : Weapon
    {
        public Sword() : base("meč")
        {
        }

        protected override int Attack(char c, string monsterShout)
        {
            return CountCharOccurrences(c, monsterShout);
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
