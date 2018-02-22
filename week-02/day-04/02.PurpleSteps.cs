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
            //Purple steps - definable: size and amount of boxes

            PurpleSteps(foxDraw, 35, 10);
        }

        private void PurpleSteps(FoxDraw foxDraw, double size, int many)
        {
            foxDraw.FillColor(Colors.Purple);
            for (int i = 0; i < many; i++)
            {
                foxDraw.DrawRectangle(i * size, i * size, size, size);
            }
        }

       

    }
 }
