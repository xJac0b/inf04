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

namespace Pracownik
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
        string password = String.Empty;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int charNumber = int.Parse(charNumberBox.Text);
            password = String.Empty;
            string specialCharsSet = "!@#$%^&*()_+-=";
            string lettersSet = "abcdefghijklmnopqrstuwxyz";
            string upperCaseSet = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            if ((digits.IsChecked ?? false) && password.Length < charNumber)
            {
                password += new Random().Next(0, 10);
            }
            if ((specialChars.IsChecked ?? false) && password.Length < charNumber)
            {
                password += specialCharsSet[new Random().Next(0, specialCharsSet.Length)];
            }
            if ((differentCases.IsChecked ?? false) && password.Length < charNumber)
            {
                password += upperCaseSet[new Random().Next(0, upperCaseSet.Length)];
            }

            while(password.Length < charNumber)
            {
                password += lettersSet[new Random().Next(0, lettersSet.Length)];
            }

            MessageBox.Show(password);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string role = roleComboBox.Text;
            MessageBox.Show(String.Format("Dane pracownika: {0} {1} {2} Hasło: {3}", firstName,
                lastName, role, (password ?? "")));

        }
    }
}