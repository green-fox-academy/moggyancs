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
            TicTac(foxDraw, new Point(0, 0), canvas.Height / 3);
        }


        private void TicTac(FoxDraw foxDraw, Point offset, double h)
        {
            if (h <= 1)
            {
                return;
            }
            else
            {
               foxDraw.DrawLine(offset.X + h  , offset.Y, offset.X + h , offset.Y + h * 3);
               foxDraw.DrawLine(offset.X + 2 * h, offset.Y, offset.X + 2 * h , offset.Y + h * 3);
               foxDraw.DrawLine(offset.X, offset.Y + h, offset.X + h * 3 , offset.Y + h );
               foxDraw.DrawLine(offset.X, offset.Y + 2 * h, offset.X + h * 3, offset.Y + 2 * h);
            }
            TicTac(foxDraw, new Point(offset.X + h, offset.Y), h / 3);
            TicTac(foxDraw, new Point(offset.X, offset.Y + h), h / 3);
            TicTac(foxDraw, new Point(offset.X + 2 * h, offset.Y + h), h / 3);
            TicTac(foxDraw, new Point(offset.X + h, offset.Y + 2 * h), h / 3);
            
        }
    }

}