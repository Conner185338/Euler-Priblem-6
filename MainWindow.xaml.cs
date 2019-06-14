/*
 * Conner Warboys
 * Project Euler Problem 6
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338SumSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double SumSquare = 0;
            double SumAdd = 0;
            double FinalSum = 0;

            for(int i = 1; i < 101; i++)
            {
                SumSquare -= i * i;
            }
            for(int j = 1; j < 101; j++)
            {
                SumAdd += j;
            }
            SumAdd = SumAdd * SumAdd;
            FinalSum = SumAdd + SumSquare;
            lblOuput.Content = FinalSum;
        }
    }
}
