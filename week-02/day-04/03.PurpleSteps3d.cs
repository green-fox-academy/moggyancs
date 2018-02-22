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
            //Purple steps 3d - definable: amount of boxes

            PurpleSteps3d(foxDraw, 6);
        }

        private void PurpleSteps3d(FoxDraw foxDraw, int many)
        {
            double size = 10;
            foxDraw.FillColor(Colors.MediumPurple);
            foxDraw.StrokeColor(Colors.Black);
            for (double i = 0; i < many; i++ )
            {
                foxDraw.DrawRectangle(i * i * size, i * i * size, size + size * i * 2, size + size * i * 2);
            }
        }

       

    }
 }
