namespace DingDong.Weapons
{
    class Hammer
    {
        private string name;

        public Hammer()
        {
            name = "kladivo";
        }

        public int Attack(char c, string monsterShout)
        {
            return ((int)c - (int)'A');
        }
    }
}
