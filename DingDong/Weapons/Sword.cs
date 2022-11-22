namespace DingDong.Weapons
{
    class Sword
    {
        private string name;

        public Sword()
        {
            name = "meč";
        }

        public int Attack(char c, string monsterShout)
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
