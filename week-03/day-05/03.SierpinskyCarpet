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
        Color[] myColors = new Color[] { Colors.Blue, Colors.Purple, Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green };
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);


            foxDraw.FillColor(Colors.Red);
            LayCarpet(foxDraw, new Point(canvas.Height /3 ,canvas.Height/3), canvas.Height/3);
        }


        private void LayCarpet(FoxDraw foxDraw, Point offset, double h)
        {
            if (h <= 1)
            {
                return;
            }
            else
            {
                int colorNumber = (int)h % myColors.Length;
                foxDraw.FillColor(myColors[colorNumber]);
                foxDraw.DrawRectangle(offset.X, offset.Y, h, h );
            }

            LayCarpet(foxDraw, new Point(offset.X - 2 * h / 3, offset.Y - 2 * h / 3), h / 3);
            LayCarpet(foxDraw, new Point(offset.X - 2 * h / 3, offset.Y + h / 3), h / 3);
            LayCarpet(foxDraw, new Point(offset.X - 2 * h / 3, offset.Y + 4 * h / 3 ), h / 3);

            LayCarpet(foxDraw, new Point(offset.X + h / 3, offset.Y - 2 * h / 3), h / 3);
            //LayCarpet(foxDraw, new Point(offset.X + h / 3, offset.Y + h / 3), h / 3);
            LayCarpet(foxDraw, new Point(offset.X + h / 3, offset.Y + 4 * h / 3), h / 3);

            LayCarpet(foxDraw, new Point(offset.X + 4 * h / 3, offset.Y - 2 * h / 3), h / 3);
            LayCarpet(foxDraw, new Point(offset.X + 4 * h / 3, offset.Y +  h / 3), h / 3);
            LayCarpet(foxDraw, new Point(offset.X + 4 * h / 3, offset.Y + 4 * h / 3), h / 3);
        } 
    }

}