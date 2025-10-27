namespace ElementalTactics
{
    public class GameState
    {
        public bool GameOver { get; set; }
        public List<Character> Roster { get; set; }

        public GameState() 
        {
            Roster =
            [
                new Character
                {
                    Name = "Tim",
                    MaxHealth = 10,
                    CurrentHealth = 10,
                    Mana = 5,
                    Experience = 0,
                    Attack = 1,
                    Defense = 0,
                    Level = 1,
                    Position = new Position(1, 1),
                    ImageSource = Images.Character1
                }
            ];
            GameOver = false;
        } 
    }
}
