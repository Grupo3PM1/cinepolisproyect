using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace cinepolisproyect.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicketPage : ContentPage
    {
        //Declaracion de variable qr
        ZXingBarcodeImageView qr;
        public TicketPage()
        {
            InitializeComponent();
        }

        private async void btngenerarcodigo_Clicked(object sender, EventArgs e)
        {
            qr = new ZXingBarcodeImageView
            {
                //Propiedad para generar codigo QR
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            String IdCine = txtidcine.Text;
            String IdPelicula = txtidpeli.Text;
            String IdHorario = txtidhorario.Text;
            String IdCombo = txtIdCombo.Text;
            String RefrescoExtra = txtRefrescoExtra.Text;
            String ContButaca = txtcontbutaca.Text;
    
            //generar tipo de codigo que sera el QR_CODE 
            qr.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            //propiedad de ancho del QR
            qr.BarcodeOptions.Width = 300;
            //propiedad de alto del QR
            qr.BarcodeOptions.Height = 300;
            //valor que va recibir el codigo QR para direccionar
            qr.BarcodeValue = "https://cinepolishn.000webhostapp.com/Cinepolis/Ticket.php/?IdCine=" + IdCine + "&IdPelicula=" + IdPelicula + "&IdHorario=" + IdHorario + "&ContButaca=" + ContButaca + "&IdCombo=" + IdCombo + "&RefrescoExtra=" + RefrescoExtra;
          
            //colocamos el nombre al StackLayout y le damos el valor
            //qr del objeto creado que es
            stkQR.Children.Add(qr);

        }
    }
}