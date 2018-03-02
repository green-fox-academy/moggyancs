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

//foxdrow needs to be modified, add thickness to rectangles!

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
            
            foxDraw.FillColor(Colors.Transparent);
            

            SquareGrid(foxDraw, new Point(canvas.Height /4 ,canvas.Height/4), canvas.Height/2, 20);
        }

        private void SquareGrid(FoxDraw foxDraw, Point offset, double h, double thick )
        {
            if (h <= 10)
            {
                return;
            }
            else
            {
                foxDraw.DrawRectangle(offset.X, offset.Y, h, h, thick );
            }

            SquareGrid(foxDraw, new Point(offset.X - h/4, offset.Y - h/4), h / 2, thick / 2);
            SquareGrid(foxDraw, new Point(offset.X + 3 * h / 4,  offset.Y - h/4), h / 2, thick / 2);
            SquareGrid(foxDraw, new Point(offset.X -  h / 4 , offset.Y + 3 * h / 4), h / 2, thick / 2);
            SquareGrid(foxDraw, new Point(offset.X + 3 * h / 4, offset.Y + 3* h / 4), h / 2, thick / 2);

        } 
    }

}