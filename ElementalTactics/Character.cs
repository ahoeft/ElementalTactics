using System.Windows.Media;

namespace ElementalTactics
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Mana { get; set; }
        public int Experience { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public Position Position { get; set; }
        public ImageSource ImageSource { get; set; }
    }
}
