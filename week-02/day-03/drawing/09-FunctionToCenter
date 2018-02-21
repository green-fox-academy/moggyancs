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
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            double a = 100;
            double b = 100;
            double cWidth = canvas.Width;
            double cHeight = canvas.Height;

            DrawSides(foxDraw, a, b, cWidth, cHeight);
        }
        private void DrawSides(FoxDraw foxDraw, double x, double y, double cW, double cH)
        {
            DrawSide(foxDraw, 0, cW, 0, 0, x, y); // top
            DrawSide(foxDraw, cW, cW, 0, cH, x, y); // right
            DrawSide(foxDraw, 0, cW, cH, cH, x, y); // bottom
            DrawSide(foxDraw, 0, 0, 0, cH, x, y); // left
        }

        private void DrawSide(FoxDraw foxDraw, double iSt, double iEn, double jSt, double jEn, double x, double y)
        {
            if (jSt == jEn) // case 1 & 3 aka top & bottom
            {
                for (double iter = iSt; iter < iEn; iter += 43)
                {
                    foxDraw.DrawLine(iter, jEn, x, y);
                }

            }

            else if (iSt == iEn) //case 2 & 4 aka sides
            {
                for (double iter = jSt; iter <= jEn; iter += 43)
                {
                    foxDraw.DrawLine(iSt, iter, x, y);
                }
            }
        }



    }
 }
