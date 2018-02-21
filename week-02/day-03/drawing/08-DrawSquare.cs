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
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.  

            int p1 = 100;
            int p2 = 100;

            DrawSquare(foxDraw, p1, p2);
        }
        private void DrawSquare (FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
            foxDraw.DrawRectangle(x-25, y-25, 50, 50);
                x += 120;
                y += 120;
            }
        }



    }
}
