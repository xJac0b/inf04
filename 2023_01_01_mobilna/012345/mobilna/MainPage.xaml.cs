using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notatki
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notatki { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Notatki = new ObservableCollection<string> { "Zakupy: chleb, masło, ser", "Do zrobienia: obiad, umyć podłogi", "weekend: kino, spacer z psem"};
            
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Notatki.Add(nowaNotatka.Text);
        }
    }
}
