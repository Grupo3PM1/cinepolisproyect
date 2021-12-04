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
    public partial class CardPage : ContentPage
    {
        public Models.ApiUsuario usuariosdata;
        Authentication authentication;
        public string user = "1";
        public CardPage()
        {
            InitializeComponent();
            authentication = DependencyService.Get<Authentication>();

            this.BindingContext = new Models.CardPageViewModel();
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
            while (sent == 1)
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
            user = usuariosdata.us_id;
        }

        //Validar los campos de los formularios
        private async Task<bool> validarFormulario()
        {
            //Valida si el valor en los Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(this.txtncard.Text) || String.IsNullOrWhiteSpace(this.txtexpcard.Text) || String.IsNullOrWhiteSpace(this.txtcvccard.Text))
            {
                await this.DisplayAlert("Advertencia", "Todos los campos son obligatorios.", "OK");
                return false;
            }

            return true;
        }


        private async void btncard_Clicked(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {
                var postcard = new Models.ApiCard
                {
                    trj_ntarjeta = this.txtncard.Text,
                    trj_fchvencimiento = this.txtexpcard.Text,
                    trj_cdgseguridad = this.txtcvccard.Text,
                    us_id = user,
                };

                await Controllers.CardController.CrearTarjeta(postcard); 
                await this.DisplayAlert("Exito", "Datos guardados.", "OK");
            }
            //pasamos a cargarlos valores a la clase para enviarlos al siguiente ContentPage HorariosPage por medio de BindingContext
            Models.pelicula classdata = new Models.pelicula
            {
                IdCine = this.txtidcine.Text,
                IdPelicula = this.txtidpeli.Text,
                IdHorario = this.txtidhorario.Text,
                IdCombo = "1",
                RefrescoExtra = this.txtRefrescoExtra.Text,
                ContButaca = this.txtcontbutaca.Text,
                asientosSelected = this.txtasientosSelected.Text
            };
            //Creamos una variable page para referenciar a HorariosPage
            var page = new Views.TicketPage();
            //Mediante BindingContext enviamos la clase classdata hacia a HorariosPage mediante la variable page
            page.BindingContext = classdata;
            //Por ultimo enviamos la variable Page referenciado a HorariosPage con los datos de la clase mediante un Navigation.PushAsync
            await Navigation.PushAsync(page);


        }
    }
}