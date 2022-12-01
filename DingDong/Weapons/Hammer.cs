namespace DingDong.Weapons
{
    class Hammer : Weapon
    {
        public Hammer() : base("kladivo")
        {
        }

        protected override int Attack(char c, string monsterShout)
        {
            return ((int)c - (int)'A');
        }
    }
}
