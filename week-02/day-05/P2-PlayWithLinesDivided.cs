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

            int many = 3;
            FillWithBoxes(foxDraw, many);
        }

        private void FillWithBoxes(FoxDraw foxDraw, int boxes)
        {

            foxDraw.FillColor(Colors.Black);
            double size = canvas.Height / boxes;

            for (int i = 0; i < boxes; i++)
            {
                for (int j = 0; j < boxes; j++)
                {
                    PlayWithLines(foxDraw, canvas.Width / boxes, size / 12, boxes);
                }
            }
        }
        private void PlayWithLines(FoxDraw foxDraw, double sizeMini, double distance, int boxes)
        {
            for (int k = 0; k < boxes; k++)
            {
                for (int j = 0; j < boxes; j++)
                {
                    for (double i = 0; i < sizeMini - distance; i += distance)
                    {
                        foxDraw.StrokeColor(Colors.Purple);
                        foxDraw.DrawLine(j * sizeMini + i + distance,k * sizeMini + 0, j * sizeMini + sizeMini, k * sizeMini + i + distance);
                        foxDraw.StrokeColor(Colors.Green);
                        foxDraw.DrawLine(j * sizeMini + 0, k * sizeMini + i + distance, j * sizeMini + i + distance, k * sizeMini + sizeMini);

                    }
                
                }

            }

        }




    }
}
