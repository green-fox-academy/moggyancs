using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Drawings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //enter your code here

            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            double size = 40;
            Color[] rainbow = new Color[] { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green , Colors.Blue, Colors.Indigo, Colors.Violet };

            for (int i = 7; i > 0; i--)
            {
                foxDraw.FillColor(rainbow[i-1]);
                DrawSquare(foxDraw, i * size );

            }
            
        }

        private void DrawSquare (FoxDraw foxDraw, double size)
        {
            
            foxDraw.DrawRectangle(canvas.Width / 2 - size/2, canvas.Height / 2 - size/2, size, size);
        }

    }
 }
