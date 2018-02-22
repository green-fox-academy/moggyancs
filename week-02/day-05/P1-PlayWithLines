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
            //Lineplay: set the distance and the color of the lines
            
            double distance = 20;
            List<Color> colours = new List<Color> { Colors.Red, Colors.Blue };

            PlayWithLines(foxDraw, distance, colours);
        }
        private void PlayWithLines (FoxDraw foxDraw, double distance, List<Color> colour)
        {
            for (double i = 0; i < canvas.Width-distance; i += distance)
            {
                foxDraw.StrokeColor(colour[0]);
                foxDraw.DrawLine(i + distance, 0 , canvas.Width, i + distance );
                foxDraw.StrokeColor(colour[1]);
                foxDraw.DrawLine(0, i + distance, i + distance, canvas.Width);
            }


        }





    }
 }
