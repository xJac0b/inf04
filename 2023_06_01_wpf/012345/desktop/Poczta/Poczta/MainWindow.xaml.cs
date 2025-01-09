using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Poczta
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(pocztowka.IsChecked == true)
            {
                obraz.Source = new BitmapImage(new Uri("./pocztowka.png", UriKind.Relative));
                cena.Content = "Cena: 1 zł";
            }
            else if(list.IsChecked == true)
            {
                obraz.Source = new BitmapImage(new Uri("./list.png", UriKind.Relative));
                cena.Content = "Cena: 1,5 zł";
            }
            else if (paczka.IsChecked == true)
            {
                obraz.Source = new BitmapImage(new Uri("./paczka.png", UriKind.Relative));
                cena.Content = "Cena: 10 zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int kod;
            if (!int.TryParse(kodPocztowy.Text, out kod))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else if (kodPocztowy.Text.Length == 5)
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            else
            {
                MessageBox.Show("Kod pocztowy jest niepoprawny");
            }
        }
    }
}