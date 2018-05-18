using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ShinyStars
{
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        Random random;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            random = new Random();
        }

        public void DrawManyRandomStars(int numberOfStars)
        {
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.StrokeColor(Colors.Black);

            for (int i = 0; i < numberOfStars; i++)
            {
                byte highColor = (byte)random.Next(150, 255);
                byte lowColor = (byte)random.Next(0, 150);

                int randomSize = random.Next(2, 15);

                foxDraw.FillColor(Color.FromRgb(lowColor, highColor, lowColor));
                foxDraw.DrawRectangle(random.Next((int)canvas.Width - randomSize),
                    random.Next((int)canvas.Height - randomSize), randomSize, randomSize);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            canvas.Children.Clear();
            int randomStars = random.Next(100, 300);
            DrawManyRandomStars(randomStars);
        }
    }
}
