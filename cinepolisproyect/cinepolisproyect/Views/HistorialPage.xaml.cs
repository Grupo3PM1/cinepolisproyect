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
        public List<Models.ApiCard> lsttarjeta { get; private set; } = new List<Models.ApiCard>();
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
            List<Models.ApiCard> listtarjeta = await cinepolisproyect.Controllers.CardController.GetListTarjeta();
            sent = 1;
            cont = 0;
            int num = 1;
            int cantlimite = listtarjeta.Count - 1;
            while (sent == 1)
            {
                if (listtarjeta[cont].us_id == usuariosdata.us_id)
                {

                    string vartrj_ntarjeta = num.ToString();
                    num += 1;
                    string vartrj_fchvencimiento = listtarjeta[cont].trj_fchvencimiento;
                    string vartrj_cdgseguridad = listtarjeta[cont].trj_cdgseguridad;
                    string varus_id = listtarjeta[cont].us_id;
                    string varIdCine = listtarjeta[cont].IdCine;
                    string varIdPelicula;
                    if (listtarjeta[cont].IdPelicula == "1"){varIdPelicula = "Eternals";}
                    else if (listtarjeta[cont].IdPelicula == "2"){varIdPelicula = "Venom";}
                    else if (listtarjeta[cont].IdPelicula == "3"){varIdPelicula = "Black Widow";}
                    else {varIdPelicula = "Ninguna";}
                    
                    string varIdHorario;
                    if (listtarjeta[cont].IdHorario == "1") { varIdHorario = "3 00PM"; }
                    else if (listtarjeta[cont].IdHorario == "2") { varIdHorario = "5 00PM"; }
                    else if (listtarjeta[cont].IdHorario == "3") { varIdHorario = "7 00PM"; }
                    else { varIdHorario = "Ninguna"; }

                    string varIdCombo;
                    if (listtarjeta[cont].IdCombo == "1") { varIdCombo = "Combo 1 -> Palomitas de maíz y Dos refrescos"; }
                    else if (listtarjeta[cont].IdCombo == "2") { varIdCombo = "Combo 2 -> Palomitas de maíz y Un refresco"; }
                    else if (listtarjeta[cont].IdCombo == "3") { varIdCombo = "Combo 3 -> Nachos y Un refresco"; }
                    else { varIdCombo = "Ninguna"; }

                    string varRefrescoExtra;
                    if (listtarjeta[cont].RefrescoExtra == "00") { varRefrescoExtra = "Ningun Refresco Extra"; }
                    else { varRefrescoExtra = listtarjeta[cont].RefrescoExtra; }

                    string varContButaca = listtarjeta[cont].ContButaca;
                    string varasientosSelected = listtarjeta[cont].asientosSelected;
                    string vartotalpagar = listtarjeta[cont].totalpagar;


                    lsttarjeta.Add(new Models.ApiCard()
                    {
                        trj_ntarjeta = vartrj_ntarjeta,
                        trj_fchvencimiento = vartrj_fchvencimiento,
                        trj_cdgseguridad = vartrj_cdgseguridad,
                        us_id = varus_id,
                        IdCine = varIdCine,
                        IdPelicula = varIdPelicula,
                        IdHorario = varIdHorario,
                        IdCombo = varIdCombo,
                        RefrescoExtra = varRefrescoExtra,
                        ContButaca = varContButaca,
                        asientosSelected = varasientosSelected,
                        totalpagar = vartotalpagar
                    });
                }
                if (cont >= cantlimite)
                {
                    sent = 0;
                }
                cont += 1;
            }
            BindingContext = this;
            await DisplayAlert("Alerta", "Actualizando...", "OK");
        }

        private async void btn_Refresh_Clicked(object sender, EventArgs e)
        {
            traerID();
        }
    }
}