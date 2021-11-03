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
    public partial class TiendaPage : ContentPage
    {
        public TiendaPage()
        {
            InitializeComponent();
        }

        private async void StackCombo1_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono Combo 1", "OK");
        }

        private async void StackCombo2_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono Combo 2", "OK");
        }

        private async void StackCombo3_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Selecciono Combo 3", "OK");
        }
    }
}