namespace ElementalTactics
{
    class Character
    {
        public Character(int health, int mana, int experience)
        {
            Health = health;
            Mana = mana;
            Experience = experience;
        }

        private int Health { get; set; }
        private int Mana { get; set; }
        private int Experience { get; set; }

    }
}
