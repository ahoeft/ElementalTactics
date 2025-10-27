using System.Windows;
using System.Windows.Input;

namespace ElementalTactics
{
    public partial class MainWindow : Window
    {
        public bool gameRunning { get; set; }
        public GameState gameState { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (Overlay.Visibility == Visibility.Visible)
            {
                e.Handled = true;
            }
            if (!gameRunning)
            {
                gameRunning = true;
                Overlay.Visibility = Visibility.Hidden;
                await RunGame();
                gameRunning = false;
            }
        }
        private async Task RunGame()
        {
            gameState = new GameState();
            await GameLoop();
        }
        private async Task GameLoop()
        {
            while (!gameState.GameOver)
            {
                await Task.Delay(100);
            }
        }
    }
}