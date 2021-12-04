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
        public Models.ApiUsuario usuariosdata;
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
            List<Models.ApiUsuario> listclientes = await cinepolisproyect.Controllers.UsuariosController.GetListUsuarios();
            int sent = 1;
            int cont = 0;
            while (sent==1)
            {
                if (listclientes[cont].us_uid == userUid)
                {
                    usuariosdata = listclientes[cont];
                    sent = 0;
                }
                else
                {
                    cont += 1;
                }

            }
            await DisplayAlert("Alerta", "Hola: "+ usuariosdata.us_nombre+" "+usuariosdata.us_apellido+"Con ID: "+usuariosdata.us_id, "OK");
        }

    }
}