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
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.


            double a = 0;
            double b = 0;
            int manylines = 100;
            var cWidht = canvas.Width;
            var cHeight = canvas.Height;

            ToTheCenter(foxDraw, a, b, manylines, cHeight, cWidht);

        }

        private void ToTheCenter(FoxDraw foxDraw, double x, double y, int lines, double canvasW, double canvasH)
        { 
            for (int i = 0; i < lines; i++)
            {
                foxDraw.DrawLine(x, y, canvasW / 2, canvasH / 2);
                x += 10;
            }
        }




    }
}
