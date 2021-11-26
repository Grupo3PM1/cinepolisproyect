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
                Pelicula = this.txtpeli.Text,
                Imagepeli = this.txtimage.Text,
                Fechapeli = this.txtdate.Text,
                Horario = this.lblhorap1.Text,
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void btncincopm_Clicked(object sender, EventArgs e)
        {
            Models.pelicula classdata = new Models.pelicula
            {
                Pelicula = this.txtpeli.Text,
                Imagepeli = this.txtimage.Text,
                Fechapeli = this.txtdate.Text,
                Horario = this.lblhorap2.Text,
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void btnsietepm_Clicked(object sender, EventArgs e)
        {
            Models.pelicula classdata = new Models.pelicula
            {
                Pelicula = this.txtpeli.Text,
                Imagepeli = this.txtimage.Text,
                Fechapeli = this.txtdate.Text,
                Horario = this.lblhorap3.Text,
            };
            var page = new Views.ButacaPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }
    }
}