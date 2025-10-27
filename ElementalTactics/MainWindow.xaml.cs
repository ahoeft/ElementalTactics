using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ElementalTactics
{
    public partial class MainWindow : Window
    {
        private readonly int rows = 15, cols = 15;

        private bool gameRunning { get; set; }
        private GameState gameState { get; set; }
        private Image[,] GridImages { get; set; }

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
            DrawGrid();
            await GameLoop();
        }

        private void DrawGrid()
        {
            GridImages = SetupGrid();
        }

        private async Task GameLoop()
        {
            while (!gameState.GameOver)
            {
                await Task.Delay(100);
            }
        }

        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;
            GameGrid.Width = GameGrid.Height * (cols / (double)rows);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var source = gameState.Roster.FirstOrDefault(x => x.Position.Row == r && x.Position.Col == c)?.ImageSource;
                    Image image = new Image
                    {
                        Source = (source != null) ? source : Images.Empty,
                        RenderTransformOrigin = new Point(0.5, 0.5)
                    };

                    images[r, c] = image;
                    GameGrid.Children.Add(image);
                }
            }
            return images;
        }
    }
}