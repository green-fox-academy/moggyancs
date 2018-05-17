using GreenFox;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Drawing
{
    public partial class MainWindow : Window
    {
        static public FoxDraw foxDraw;
        public Random random;
        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);

            foxDraw.BackgroundColor(Colors.Black);
        }

        public void DrawStars(int many)
        {
            random = new Random();

            for (int i = 0; i < many; i++)
            {
                byte a = (byte)random.Next(0, 230);
                foxDraw.FillColor(Color.FromRgb(a, a, a));

                foxDraw.DrawRectangle(random.Next(0, (int)canvas.Width - 5),
                    random.Next(0, (int)canvas.Height - 5), 5, 5);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            random = new Random();
           // canvas.Children.Clear();
            
            DrawStars(random.Next(50, 300));
        }
    }
}
