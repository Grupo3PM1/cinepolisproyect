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
        public string user_email = "1";
        int totalpago = 0;
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
            user_email = usuariosdata.us_email;


            //Sacar Total a Pagar
            //precio por asiento L.70.00
            int cantbutaca = Convert.ToInt32(txtcontbutaca.Text);
            int refrescoextra = Convert.ToInt32(txtRefrescoExtra.Text);
            int combo = 0;

            if (txtIdCombo.Text == "1")
            {
                combo = 120;
            }
            else if (txtIdCombo.Text == "2")
            {
                combo = 95;
            }
            else if (txtIdCombo.Text == "3")
            {
                combo = 100;
            }
            else
            {
                combo = 0;
            }
            totalpago = (cantbutaca * 70) + combo + (refrescoextra * 35);

            await DisplayAlert("Alerta", "Su Pago total seria: "+ totalpago.ToString(), "OK");
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
                    IdCine = this.txtidcine.Text,
                    IdPelicula = this.txtidpeli.Text,
                    IdHorario = this.txtidhorario.Text,
                    IdCombo = txtIdCombo.Text,
                    RefrescoExtra = this.txtRefrescoExtra.Text,
                    ContButaca = this.txtcontbutaca.Text,
                    asientosSelected = this.txtasientosSelected.Text,
                    totalpagar = totalpago.ToString()
                };



                //---------  ENVIO DE CORREO ELECTRONICO CON PELICULA Y PRODUCTOS  --------//


                //Instanciamos System utilizando la variable mmsg
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                //Agregamos cada uno de los compones para el envio del correo
                mmsg.To.Add(user_email);//campo de correo electronico de usuario
                mmsg.Subject = "El cine que te entiende";//campo de asunto
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;//encondiar el asunto en formato UTF8
                mmsg.Bcc.Add("cinepolis504@gmail.com");//enviar una copia del correo enviado al usuario


                String pelicula, combostr;
                //Desicion de peliculas a mostrar en el correo
                if (txtidpeli.Text == "1")
                {
                    pelicula = "Eternals";
                }
                else if (txtidpeli.Text == "2")
                {
                    pelicula = "Venom";
                }
                else
                {
                    pelicula = "Black Widow";
                }

                //Desicion de los combos a mostrar en el correo
                if (txtIdCombo.Text == "1")
                {
                    combostr = "Palomitas de maíz + dos refrescos";
                }
                else if (txtIdCombo.Text == "2")
                {
                    combostr = "palomitas de maíz + un regreso";
                }
                else if(txtIdCombo.Text == "3")
                {
                    combostr = "nachos + un refresco";
                }
                else
                {
                    combostr = "Ninguno";
                }

                //Declaramos una variable string la cual se utilizara para igualar la pelicula y el combo
                //seleccionado
                string BodyEmail;

                //En caso de que se adiciono refrescos extras se realiza una decision para poder mostrarlos
                if (txtRefrescoExtra.Text == "00")
                {
                    BodyEmail = "Su pelicula es: " + pelicula + ", Su producto es:" + combostr;

                }
                else
                {
                    BodyEmail = "Su pelicula es: " + pelicula + ", Su producto es:" + combostr + " con " + txtRefrescoExtra.Text + " Refrescos extras";
                }

                // se coloca la variable BodyEmail la cual hace referencia al cuerpo del mensaje
                mmsg.Body = BodyEmail;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;//encodiamos el cuerpo del mensaje con UTF8
                mmsg.IsBodyHtml = true;//se le indica que lo que se envia es html
                mmsg.From = new System.Net.Mail.MailAddress("cinepolis504@gmail.com");// Correo que envia el correo al usuario

                //Creacion del cliente correo 
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                //Asignamos las credenciales del correo emisor 
                cliente.Credentials = new System.Net.NetworkCredential("cinepolis504@gmail.com", "CinepolisHN504");
                cliente.Port = 587;//Puerto utilizado por gmail
                cliente.EnableSsl = true;//La seguridad
                cliente.Host = "smtp.gmail.com";//dominio

                try
                {
                    //Metodo para enviar la informacion hacia el correo del usuario
                    cliente.Send(mmsg);

                }
                catch (Exception)
                {

                    await DisplayAlert("Error", "Error al eviar", "OK");
                }


                //--------- FIN ENVIO DE CORREO ELECTRONICO CON PELICULA Y PRODUCTOS  --------//


                await Controllers.CardController.CrearTarjeta(postcard); 
                await this.DisplayAlert("Exito", "Datos guardados, revise su correo electronico", "OK");
            
                //pasamos a cargarlos valores a la clase para enviarlos al siguiente ContentPage HorariosPage por medio de BindingContext
                Models.pelicula classdata = new Models.pelicula
                {
                    IdCine = this.txtidcine.Text,
                    IdPelicula = this.txtidpeli.Text,
                    IdHorario = this.txtidhorario.Text,
                    IdCombo = txtIdCombo.Text,
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
}