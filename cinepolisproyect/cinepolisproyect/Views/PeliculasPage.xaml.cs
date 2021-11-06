using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinepolisproyect.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeliculasPage : ContentPage
    {
        public PeliculasPage()
        {
            InitializeComponent();
        }

        private async void StackPeli1_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono pelicula 1", "OK");
        }

        private async void StackPeli2_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono pelicula 2", "OK");
        }

        private async void StackPeli3_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono pelicula 3", "OK");
        }
    }
}