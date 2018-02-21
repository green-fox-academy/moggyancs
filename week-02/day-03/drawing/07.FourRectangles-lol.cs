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
            // draw four different size and color rectangles.
            // avoid code duplication.

            foxDraw.FillColor(Colors.Blue);
            foxDraw.DrawRectangle(250, 250, 50, 80);

            var points = new List<Point>();
            points.Add(new Point(650, 10));
            points.Add(new Point(750, 10));
            points.Add(new Point(750, 100));
            points.Add(new Point(650, 100));
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(50, 50, 160, 50);
            foxDraw.DrawLine(160, 50, 160, 75);
            foxDraw.DrawLine(160, 75, 50, 75);
            foxDraw.DrawLine(50, 75, 50, 50);

            //foxDraw.AddImage(, 450, 450);






        }

       


    }
}
