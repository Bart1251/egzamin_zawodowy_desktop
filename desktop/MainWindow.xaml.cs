using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace desktop
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

        private void CheckPrice(object sender, RoutedEventArgs e)
        {
            if (PocztowkaRadio.IsChecked == true)
            {
                Image.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
                Price.Content = "Cena: 1 zł";
                return;
            }
            if (ListRadio.IsChecked == true)
            {
                Image.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
                Price.Content = "Cena: 1,5 zł";
                return;
            }
            if (PaczkaRadio.IsChecked == true)
            {
                Image.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
                Price.Content = "Cena: 10 zł";
                return;
            }
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            if(PostalCode.Text.Length == 5)
            {
                if(new Regex("^[0-9]{5}$").IsMatch(PostalCode.Text))
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
        }
    }
}
