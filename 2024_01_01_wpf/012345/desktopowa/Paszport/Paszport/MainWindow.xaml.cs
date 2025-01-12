using System.Diagnostics;
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

namespace Paszport
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = poleImie.Text;
            string nazwisko = poleNazwisko.Text;
            if (imie == String.Empty || nazwisko == String.Empty)
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            string kolorOczu = String.Empty;
            if (niebieskie.IsChecked == true)
            {
                kolorOczu = "niebieskie";
            }
            else if (zielone.IsChecked == true)
            {
                kolorOczu = "zielone";
            }
            else
            {
                kolorOczu = "piwne";
            }
            MessageBox.Show(String.Format("{0} {1} kolor oczu {2}", imie, nazwisko, kolorOczu));

        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            string sciezkaDoZdjecia = String.Format("{0}-zdjecie.jpg", poleNumer.Text);
            Trace.WriteLine(sciezkaDoZdjecia);
            string sciezkaDoOdcisku = String.Format("{0}-odcisk.jpg", poleNumer.Text);
            zdjecie.Source = new BitmapImage(new Uri(sciezkaDoZdjecia, UriKind.Relative));
            odcisk.Source = new BitmapImage(new Uri(sciezkaDoOdcisku, UriKind.Relative));
        }
    }
}