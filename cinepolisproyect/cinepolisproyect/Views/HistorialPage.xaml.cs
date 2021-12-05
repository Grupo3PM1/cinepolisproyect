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
        public List<Models.ApiCard> lsttarjeta = new List<Models.ApiCard>();
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
            while (sent == 1)
            {
                if (listtarjeta[cont].us_id == usuariosdata.us_id)
                {

                    string vartrj_ntarjeta = listtarjeta[cont].trj_ntarjeta;
                    string vartrj_fchvencimiento = listtarjeta[cont].trj_fchvencimiento;
                    string vartrj_cdgseguridad = listtarjeta[cont].trj_cdgseguridad;
                    string varus_id = listtarjeta[cont].us_id;
                    string varIdCine = listtarjeta[cont].IdCine;
                    string varIdPelicula = listtarjeta[cont].IdPelicula;
                    string varIdHorario = listtarjeta[cont].IdHorario;
                    string varIdCombo = listtarjeta[cont].IdCombo;
                    string varRefrescoExtra = listtarjeta[cont].RefrescoExtra;
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
                if (cont >= 3)
                {
                    sent = 0;
                }
                cont += 1;
            }
            await DisplayAlert("Alerta", "Hola: "+ usuariosdata.us_nombre+" "+usuariosdata.us_apellido+"Con ID: "+usuariosdata.us_id, "OK");
        }

    }
}