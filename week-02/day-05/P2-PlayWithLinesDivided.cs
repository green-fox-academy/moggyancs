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

            int many = 4;
            CheckerIt(foxDraw, many);
        }

        private void CheckerIt(FoxDraw foxDraw, int boxes)
        {

            foxDraw.FillColor(Colors.Black);
            double size = canvas.Height / boxes;

            //foxDraw.DrawLine(0, 0, 0, size * boxes);
            //foxDraw.DrawLine(0, 0, size * boxes, 0);
            //foxDraw.DrawLine(size * boxes, 0, size * boxes, size * boxes);
            //foxDraw.DrawLine(0, size * boxes, size * boxes, size * boxes);

            for (int i = 0; i < boxes; i++)
            {
                for (int j = 0; j < boxes; j++)
                {
                    foxDraw.DrawRectangle(i * size, j * size, size, size);
                    PlayWithLines(foxDraw, canvas.Width / boxes, size / 12 );

                }
            }
        }
        private void PlayWithLines(FoxDraw foxDraw, double sizeMini, double distance)
        {
            for (double i = 0; i < sizeMini - distance; i += distance)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(i + distance, 0, sizeMini, i + distance);
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0, i + distance, i + distance, sizeMini);
            }


        }




    }
}
