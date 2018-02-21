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
            // draw four different size and color rectangles.
            // avoid code duplication.


            int[] p1 = new int[] { 20, 40, 60, 80 };
            int[] p2 = new int[] { 40, 60, 80, 100 };
            int[] height = new int[] { 10, 20, 30, 40 };
            int[] width = new int[] { 40, 30, 20, 10 };
            Color[] colorSet = new Color[] { Colors.Red, Colors.Yellow, Colors.Green, Colors.Blue};

            FourRectangles(foxDraw, p1, p2, height, width, colorSet);

        }

        private void FourRectangles(FoxDraw foxDraw, int[] p1, int[] p2, int[] height, int[] width, Color[] colorSet)
        { 
            for (int i = 0; i < p1.Length; i++)
            {
               foxDraw.FillColor(colorSet[i]);
               foxDraw.DrawRectangle(p1[i], p2[i], height[i], width[i]);
               
            }
        }




    }
}
