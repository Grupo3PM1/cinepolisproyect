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
    public partial class HistorialPage : ContentPage
    {
        Authentication authentication;
        public HistorialPage()
        {
            InitializeComponent();
            authentication = DependencyService.Get<Authentication>();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            traerID();

        }
        public async void traerID()
        {
            string userUid = await authentication.Uid();

            await DisplayAlert("Alerta", "Seleccione su cine: "+ userUid, "OK");
        }

    }
}