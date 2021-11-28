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
                a2 = "0",
                a3 = "0",
                a4 = "0",
                a5 = "0",
                a6 = "0",
                a7 = "0",
                b1 = "0",
                b2 = "1",
                b3 = "0",
                b4 = "0",
                b5 = "0",
                b6 = "0",
                b7 = "0",
                c1 = "0",
                c2 = "0",
                c3 = "1",
                c4 = "0",
                c5 = "0",
                c6 = "0",
                c7 = "1",
                d1 = "0",
                d2 = "0",
                d3 = "0",
                d4 = "1",
                d5 = "0",
                d6 = "1",
                d7 = "0",
                e1 = "0",
                e2 = "0",
                e3 = "0",
                e4 = "0",
                e5 = "1",
                e6 = "0",
                e7 = "0",
                f1 = "1",
                f2 = "0",
                f3 = "1",
                f4 = "0",
                f5 = "1",
            };

            #region Fila A
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
            #endregion
            #region Fila B
            if (butacadata.b1 == "1")
                this.seat8.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat8.BackgroundColor = Color.Transparent;

            if (butacadata.b2 == "1")
                this.seat9.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat9.BackgroundColor = Color.Transparent;

            if (butacadata.b3 == "1")
                this.seat10.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat10.BackgroundColor = Color.Transparent;

            if (butacadata.b4 == "1")
                this.seat11.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat11.BackgroundColor = Color.Transparent;

            if (butacadata.b5 == "1")
                this.seat12.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat12.BackgroundColor = Color.Transparent;

            if (butacadata.b6 == "1")
                this.seat13.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat13.BackgroundColor = Color.Transparent;

            if (butacadata.b7 == "1")
                this.seat14.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat14.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila C
            if (butacadata.c1 == "1")
                this.seat15.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat15.BackgroundColor = Color.Transparent;

            if (butacadata.c2 == "1")
                this.seat16.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat16.BackgroundColor = Color.Transparent;

            if (butacadata.c3 == "1")
                this.seat17.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat17.BackgroundColor = Color.Transparent;

            if (butacadata.c4 == "1")
                this.seat18.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat18.BackgroundColor = Color.Transparent;

            if (butacadata.c5 == "1")
                this.seat19.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat19.BackgroundColor = Color.Transparent;

            if (butacadata.c6 == "1")
                this.seat20.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat20.BackgroundColor = Color.Transparent;

            if (butacadata.c7 == "1")
                this.seat21.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat21.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila D
            if (butacadata.d1 == "1")
                this.seat22.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat22.BackgroundColor = Color.Transparent;

            if (butacadata.d2 == "1")
                this.seat23.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat23.BackgroundColor = Color.Transparent;

            if (butacadata.d3 == "1")
                this.seat24.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat24.BackgroundColor = Color.Transparent;

            if (butacadata.d4 == "1")
                this.seat25.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat25.BackgroundColor = Color.Transparent;

            if (butacadata.d5 == "1")
                this.seat26.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat26.BackgroundColor = Color.Transparent;

            if (butacadata.d6 == "1")
                this.seat27.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat27.BackgroundColor = Color.Transparent;

            if (butacadata.d7 == "1")
                this.seat28.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat28.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila E
            if (butacadata.e1 == "1")
                this.seat29.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat29.BackgroundColor = Color.Transparent;

            if (butacadata.e2 == "1")
                this.seat30.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat30.BackgroundColor = Color.Transparent;

            if (butacadata.e3 == "1")
                this.seat31.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat31.BackgroundColor = Color.Transparent;

            if (butacadata.e4 == "1")
                this.seat32.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat32.BackgroundColor = Color.Transparent;

            if (butacadata.e5 == "1")
                this.seat33.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat33.BackgroundColor = Color.Transparent;

            if (butacadata.e6 == "1")
                this.seat34.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat34.BackgroundColor = Color.Transparent;

            if (butacadata.e7 == "1")
                this.seat35.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat35.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila F
            if (butacadata.f1 == "1")
                this.seat36.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat36.BackgroundColor = Color.Transparent;

            if (butacadata.f2 == "1")
                this.seat37.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat37.BackgroundColor = Color.Transparent;

            if (butacadata.f3 == "1")
                this.seat38.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat38.BackgroundColor = Color.Transparent;

            if (butacadata.f4 == "1")
                this.seat39.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat39.BackgroundColor = Color.Transparent;

            if (butacadata.f5 == "1")
                this.seat40.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat40.BackgroundColor = Color.Transparent;
            #endregion
            
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

        private void seat8_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat9_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat10_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat11_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat12_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat13_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat14_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat15_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat16_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat17_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat18_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat19_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat20_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat21_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat22_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat23_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat24_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat25_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat26_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat27_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat28_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat29_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat30_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat31_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat32_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat33_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat34_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat35_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat36_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat37_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat38_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat39_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }

        private void seat40_Clicked(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Transparent))
                btn.BackgroundColor = Color.FromHex("#FFFF00");
            else
                btn.BackgroundColor = Color.Transparent;
        }
    }
}