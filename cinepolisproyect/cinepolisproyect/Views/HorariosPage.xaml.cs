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
    public partial class HorariosPage : ContentPage
    {
        public HorariosPage()
        {
            InitializeComponent();
        }

        private async void btntrespm_Clicked(object sender, EventArgs e)
        {
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = Convert.ToInt32(txtIdPeli.Text),
                IdHorario = 1
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void btncincopm_Clicked(object sender, EventArgs e)
        {
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = Convert.ToInt32(txtIdPeli.Text),
                IdHorario = 2
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void btnsietepm_Clicked(object sender, EventArgs e)
        {
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = Convert.ToInt32(txtIdPeli.Text),
                IdHorario = 3
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }
    }
}