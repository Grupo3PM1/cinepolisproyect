using SkiaSharp;
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
    public partial class ButacaPage : ContentPage
    {
        Button btn;
        public Models.butaca butacadata;
        public ButacaPage(/*Ticket ticket*/)
        {
            
            InitializeComponent();
            butacadata = new Models.butaca 
            {
                a1 = "1",
                a2 = "1",
                a3 = "1",
                a4 = "0",
                a5 = "1",
                a6 = "0",
                a7 = "0",
            };

            if (butacadata.a1 == "1")
                this.seat1.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat1.BackgroundColor = Color.Transparent;

            if (butacadata.a2 == "1")
                this.seat2.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat2.BackgroundColor = Color.Transparent;

            if (butacadata.a3 == "1")
                this.seat3.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat3.BackgroundColor = Color.Transparent;

            if (butacadata.a4 == "1")
                this.seat4.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat4.BackgroundColor = Color.Transparent;

            if (butacadata.a5 == "1")
                this.seat5.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat5.BackgroundColor = Color.Transparent;

            if (butacadata.a6 == "1")
                this.seat6.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat6.BackgroundColor = Color.Transparent;

            if (butacadata.a7 == "1")
                this.seat7.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat7.BackgroundColor = Color.Transparent;
            /*SelectedTicket = ticket;
            Init();
            this.BindingContext = this;*/

        }



        private async void btncomprar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.TiendaPage());
        } 

        private void seat1_Clicked(object sender, EventArgs e)
        {
            if (butacadata.a1 == "1")
                DisplayAlert("Advertencia", "El asiento ya esta ocupado", "Ok");
            else
            {
                btn = (Button)sender;
                if (btn.BackgroundColor.Equals(Color.Transparent))
                { 
                    btn.BackgroundColor = Color.FromHex("#FFFF00");
                    butacadata.a1 = "1";
                }
                else
                    btn.BackgroundColor = Color.Transparent;
            }
        }

        private void seat2_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;

        }

        private void seat3_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat4_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat5_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat6_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;

        }

        private void seat7_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;

        }

      
    }
}