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

namespace Homework_WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resultDollar = rateDollar * sumDollar;
            result.Text = resultDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(erate.Text);
            double sumEuro = Convert.ToDouble(esum.Text);
            double resultEuro = rateEuro * sumEuro;
            eresult.Text = resultEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(grate.Text);
            double sumGrivn = Convert.ToDouble(gsum.Text);
            double resultGrivn = rateGrivn * sumGrivn;
            gresult.Text = resultGrivn.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(drate.Text);
            double sumDram = Convert.ToDouble(dsum.Text);
            double resultDram = rateDram * sumDram;
            dresult.Text = resultDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double numberIn = Convert.ToDouble(number.Text);
            double distanceIn = numberIn * 0.0254;
            distance.Text = distanceIn.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double numberFoot = Convert.ToDouble(fnumber.Text);
            double distanceFoot = numberFoot * 0.3048;
            fdistance.Text = distanceFoot.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double numberMiles = Convert.ToDouble(mnumber.Text);
            double distanceMiles = numberMiles * 1609.344;
            mdistance.Text = distanceMiles.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double numberVerst = Convert.ToDouble(vnumber.Text);
            double distanceVerst = numberVerst * 1066.8;
            vdistance.Text = distanceVerst.ToString();
        }
    }
}
