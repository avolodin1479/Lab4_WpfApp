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

namespace Lab4_WpfApp
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
            double rateDollar = Convert.ToDouble(rateDol.Text);
            double sumDollar = Convert.ToDouble(sumDol.Text);
            double resDouble = rateDollar * sumDollar;
            resSumDol.Text = resDouble.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEur.Text);
            double sumEuro = Convert.ToDouble(sumEur.Text);
            double resDouble = rateEuro * sumEuro;
            resSumEur.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGbp = Convert.ToDouble(rateGBP.Text);
            double sumGbp = Convert.ToDouble(sumGBP.Text);
            double resDouble = rateGbp * sumGbp;
            resSumGBP.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateChf = Convert.ToDouble(rateCHF.Text);
            double sumChf = Convert.ToDouble(sumCHF.Text);
            double resDouble = rateChf * sumChf;
            resSumEur.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double Ft = Convert.ToDouble(rateFt.Text);
            double resDouble = Ft * 0.3048;
            resFtToM.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double Yd = Convert.ToDouble(rateYd.Text);
            double resDouble = Yd * 0.9144;
            resYdToM.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double In = Convert.ToDouble(rateIn.Text);
            double resDouble = In * 25.4;
            resInToMm.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double Mil = Convert.ToDouble(rateMil.Text);
            double resDouble = Mil * 1.6093439;
            resMilToKm.Text = resDouble.ToString();
        }
    }
}
