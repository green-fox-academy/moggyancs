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
        Color[] myColors = new Color[] { Color.FromRgb(255, 0, 0),
                Color.FromRgb(255, 0, 0),
                Color.FromRgb(255, 128, 0),
                Color.FromRgb(255, 255, 0),
                Color.FromRgb(0, 255, 0),
                Color.FromRgb(0, 255, 128),
                Color.FromRgb(0, 255, 255),
                Color.FromRgb(0, 128, 255),
                Color.FromRgb(0, 0, 255),
                Color.FromRgb(0, 0, 255)};
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);


            foxDraw.FillColor(Colors.Red);
            Triangles(foxDraw, new Point(0,0), new Point (canvas.Height,0), new Point (canvas.Height / 2, canvas.Height), canvas.Height);

        }


        private void Triangles(FoxDraw foxDraw, Point a, Point b, Point c, double line)
        {
            if (line <= 1)
            {
                return;
            }
            else
            {
                int colorNumber = (int)line % myColors.Length;
                foxDraw.FillColor(myColors[colorNumber]);
                foxDraw.DrawLine(a, b);
                foxDraw.DrawLine(b, c);
                foxDraw.DrawLine(c, a);

            }

            Triangles(foxDraw, new Point(a.X, a.Y ),
                                new Point (b.X + line / 2, b.Y),
                                new Point (c.X, c.Y),
                                line / 2);



        } 
    }

}