using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Turystyka
{
    public partial class MainPage : ContentPage
    {
        private int likesNumber = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Like_Button_Clicked(object sender, EventArgs e)
        {
            likesNumber++;
            Set_Likes_Label_Text();
        }

        private void Remove_Button_Clicked(object sender, EventArgs s)
        {
            likesNumber = Math.Max(likesNumber-1, 0);
            Set_Likes_Label_Text();
        }

        private void Set_Likes_Label_Text()
        {
            likesLabel.Text = String.Format("{0} polubień", likesNumber);
        }
    }
}
