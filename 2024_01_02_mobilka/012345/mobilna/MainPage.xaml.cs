using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Weterynarz
{
    public class Gatunek
    {
        public Gatunek(string nazwa, int wiek)
        {
            Nazwa = nazwa;
            Wiek = wiek;
        }

        public int Wiek { get; set; }
        public string Nazwa { get; set; }
    }
    public partial class MainPage : ContentPage
    {
       public List<Gatunek> Gatunki { get; set; }
       
    public MainPage()
        {
            InitializeComponent();
            Gatunki = new List<Gatunek>{
                new Gatunek("Pies", 18),
                new Gatunek("Kot", 20),
                new Gatunek("Świnka morska", 9)
            };
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            int wiekGatunku = (lista.SelectedItem as Gatunek).Wiek;
            suwak.Maximum = wiekGatunku;
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            wiek.Text = Math.Round(suwak.Value).ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string gatunek;
            if (lista.SelectedItem == null)
                gatunek = "";
            else
                gatunek = (lista.SelectedItem as Gatunek).Nazwa;
            DisplayAlert("Zapisana wizyta", String.Format("{0}, {1}, {2}, {3}, {4}", imieNazwisko.Text, gatunek, wiek.Text, cel.Text, czas.Time), "OK");
        }
    }
}
