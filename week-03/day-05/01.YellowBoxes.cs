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
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Yellow);

            foxDraw.DrawRectangle(0, 0, canvas.Height, canvas.Height);
            DrawBoxes(foxDraw, new Point(0,0), canvas.Height/3);
        }

        private void DrawBoxes(FoxDraw foxDraw, Point offset, double h )
        {
            if (h <= 1)
            {
                return;
            }
            else
            {
                foxDraw.DrawRectangle(offset.X + h  , offset.Y     ,  h, h);
                foxDraw.DrawRectangle(offset.X      , offset.Y + h, h, h);
                foxDraw.DrawRectangle(offset.X + h  , offset.Y + 2* h , h, h);
                foxDraw.DrawRectangle(offset.X + 2*h, offset.Y+ h          , h, h);
            }
            DrawBoxes(foxDraw, new Point(offset.X + h, offset.Y), h / 3);
            DrawBoxes(foxDraw, new Point(offset.X,  offset.Y + h), h / 3);
            DrawBoxes(foxDraw, new Point(offset.X + 2 * h , offset.Y + h), h / 3);
            DrawBoxes(foxDraw, new Point(offset.X + h, offset.Y + 2*h), h / 3);
        } 
    }

}