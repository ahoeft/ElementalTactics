using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ElementalTactics
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Character1 = LoadImage("Character1.png");
        public readonly static ImageSource Enemy = LoadImage("Enemy.png");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
