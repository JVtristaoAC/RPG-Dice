using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPG.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dices : ContentPage
    {
        public Dices()
        {
            InitializeComponent();
        }

        private void d4_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 5).ToString(), "", "OK");
        }

        private void d6_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 7).ToString(), "", "OK");
        }

        private void d8_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 9).ToString(), "", "OK");
        }

        private void d10_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 11).ToString(), "", "OK");
        }

        private void d12_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 13).ToString(), "", "OK");
        }

        private void d20_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DisplayAlert(random.Next(1, 21).ToString(), "", "OK");
        }
    }
}