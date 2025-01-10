using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Czcionka
{
    public partial class MainPage : ContentPage
    {
        int indeks = 0;
        string[] cytaty = new string[3] { "Dzień dobry", "Good morning", "Buenos dias" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider.Value = Math.Round(slider.Value);
            rozmiar.Text = String.Format("Rozmiar: {0}", slider.Value);
            cytat.FontSize = slider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            indeks++;
            if (indeks >= cytaty.Length)
                indeks = 0;
            cytat.Text = cytaty[indeks];
        }
    }
}
