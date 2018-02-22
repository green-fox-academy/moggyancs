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
            // Fill the canvas with a checkerboard pattern. Define how many rows. Also draws a border.

            int many = 8;
            CheckerIt(foxDraw, many);
        }

        private void CheckerIt(FoxDraw foxDraw, int boxes)
        {
            
            foxDraw.FillColor(Colors.Black);
            double size = canvas.Height/ boxes;

            foxDraw.DrawLine(0, 0, 0, size * boxes);
            foxDraw.DrawLine(0, 0, size * boxes, 0);
            foxDraw.DrawLine(size * boxes, 0, size * boxes, size * boxes);
            foxDraw.DrawLine(0, size * boxes, size * boxes, size * boxes);

            for (int i = 0; i < boxes/2; i++ )
            {
                for (int j = 0; j < boxes; j++)
                {
                    if (j % 2 == 1) // odd lines
                    {
                        foxDraw.DrawRectangle(2 * i * size + size, j * size, size, size);
                    }
                    if (j % 2 == 0)// even lines
                    {
                        foxDraw.DrawRectangle(2 * i * size, j * size, size, size);
                    }

                }
            }
        }

       

    }
 }
