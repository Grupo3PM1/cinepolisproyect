using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinepolisproyect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.DashboardPage();
            //MainPage = new Views.TiendaPage();
            //MainPage = new Views.ProductosPage();
            //MainPage = new Views.HorariosPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
