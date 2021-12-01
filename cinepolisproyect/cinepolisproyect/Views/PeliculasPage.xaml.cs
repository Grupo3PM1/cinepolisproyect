﻿using System;
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
            //await DisplayAlert("Alerta", "Selecciono pelicula 1", "OK");
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = "1",
                Pelicula = this.lblpeli1.Text,
                Imagepeli = "cartelera1.jpg",
                Fechapeli = this.lbldate1.Text,
            };
            var page = new Views.HorariosPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void StackPeli2_Tapped(object sender, EventArgs e)
        {
            //await DisplayAlert("Alerta", "Selecciono pelicula 2", "OK");
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = "2",
                Pelicula = this.lblpeli2.Text,
                Imagepeli = "cartelera2.jpg",
                Fechapeli = this.lbldate2.Text,
            };
            var page = new Views.HorariosPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }

        private async void StackPeli3_Tapped(object sender, EventArgs e)
        {
            //await DisplayAlert("Alerta", "Selecciono pelicula 3", "OK");
            Models.pelicula classdata = new Models.pelicula
            {
                IdPelicula = "3",
                Pelicula = this.lblpeli3.Text,
                Imagepeli = "cartelera3.jpg",
                Fechapeli = this.lbldate3.Text,
            };
            var page = new Views.HorariosPage();
            page.BindingContext = classdata;
            await Navigation.PushAsync(new NavigationPage(page));
        }
    }
}