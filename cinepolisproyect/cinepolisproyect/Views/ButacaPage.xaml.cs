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
        public Models.pelihorario butacadata;
        public Models.Butaca listabutaca;
        public ButacaPage(/*Ticket ticket*/)
        {
            
            InitializeComponent();
            
            


            /*SelectedTicket = ticket;
            Init();
            this.BindingContext = this;*/

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            refresh();

        }
        public async void refresh()
        {
            butacadata = new Models.pelihorario
            {
                idpeli = this.txtidpeli.Text,
                idhorario = this.txtidhorario.Text
            };
            List<Models.Butaca> listbutacas = await cinepolisproyect.Controllers.ButacasController.GetListButaca();
            ListView lstbtc = new ListView();
            lstbtc.ItemsSource = listbutacas;
            Models.Butaca btc;
            if (txtidpeli.Text == "1")
            {
                //peli 1
                if(txtidhorario.Text == "1")
                {
                    //horario 1
                    btc = listbutacas[0];
                }
                else if(txtidhorario.Text == "2")
                {
                    //horario 2
                    btc = listbutacas[1];
                }
                else
                {
                    //horario 3
                    btc = listbutacas[2];
                }
            }
            else if(txtidpeli.Text == "2")
            {
                //peli 2
                if (txtidhorario.Text == "1")
                {
                    //horario 1
                    btc = listbutacas[3];
                }
                else if (txtidhorario.Text == "2")
                {
                    //horario 2
                    btc = listbutacas[4];
                }
                else
                {
                    //horario 3
                    btc = listbutacas[5];
                }
            }
            else
            {
                //peli 3
                if (txtidhorario.Text == "1")
                {
                    //horario 1
                    btc = listbutacas[6];
                }
                else if (txtidhorario.Text == "2")
                {
                    //horario 2
                    btc = listbutacas[7];
                }
                else
                {
                    //horario 3
                    btc = listbutacas[8];
                }
            }
            
            listabutaca = new Models.Butaca
            {
                a1 = btc.a1,
                a2 = btc.a2,
                a3 = btc.a3,
                a4 = btc.a4,
                a5 = btc.a5,
                a6 = btc.a6,
                a7 = btc.a7,
                b1 = btc.b1,
                b2 = btc.b2,
                b3 = btc.b3,
                b4 = btc.b4,
                b5 = btc.b5,
                b6 = btc.b6,
                b7 = btc.b7,
                c1 = btc.c1,
                c2 = btc.c2,
                c3 = btc.c3,
                c4 = btc.c4,
                c5 = btc.c5,
                c6 = btc.c6,
                c7 = btc.c7,
                d1 = btc.d1,
                d2 = btc.d2,
                d3 = btc.d3,
                d4 = btc.d4,
                d5 = btc.d5,
                d6 = btc.d6,
                d7 = btc.d7,
                e1 = btc.e1,
                e2 = btc.e2,
                e3 = btc.e3,
                e4 = btc.e4,
                e5 = btc.e5,
                e6 = btc.e6,
                e7 = btc.e7,
                f1 = btc.f1,
                f2 = btc.f2,
                f3 = btc.f3,
                f4 = btc.f4,
                f5 = btc.f5,
            };

            #region Fila A
            if (listabutaca.a1 == "1")
                this.seat1.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat1.BackgroundColor = Color.Transparent;

            if (listabutaca.a2 == "1")
                this.seat2.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat2.BackgroundColor = Color.Transparent;

            if (listabutaca.a3 == "1")
                this.seat3.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat3.BackgroundColor = Color.Transparent;

            if (listabutaca.a4 == "1")
                this.seat4.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat4.BackgroundColor = Color.Transparent;

            if (listabutaca.a5 == "1")
                this.seat5.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat5.BackgroundColor = Color.Transparent;

            if (listabutaca.a6 == "1")
                this.seat6.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat6.BackgroundColor = Color.Transparent;

            if (listabutaca.a7 == "1")
                this.seat7.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat7.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila B
            if (listabutaca.b1 == "1")
                this.seat8.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat8.BackgroundColor = Color.Transparent;

            if (listabutaca.b2 == "1")
                this.seat9.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat9.BackgroundColor = Color.Transparent;

            if (listabutaca.b3 == "1")
                this.seat10.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat10.BackgroundColor = Color.Transparent;

            if (listabutaca.b4 == "1")
                this.seat11.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat11.BackgroundColor = Color.Transparent;

            if (listabutaca.b5 == "1")
                this.seat12.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat12.BackgroundColor = Color.Transparent;

            if (listabutaca.b6 == "1")
                this.seat13.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat13.BackgroundColor = Color.Transparent;

            if (listabutaca.b7 == "1")
                this.seat14.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat14.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila C
            if (listabutaca.c1 == "1")
                this.seat15.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat15.BackgroundColor = Color.Transparent;

            if (listabutaca.c2 == "1")
                this.seat16.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat16.BackgroundColor = Color.Transparent;

            if (listabutaca.c3 == "1")
                this.seat17.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat17.BackgroundColor = Color.Transparent;

            if (listabutaca.c4 == "1")
                this.seat18.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat18.BackgroundColor = Color.Transparent;

            if (listabutaca.c5 == "1")
                this.seat19.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat19.BackgroundColor = Color.Transparent;

            if (listabutaca.c6 == "1")
                this.seat20.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat20.BackgroundColor = Color.Transparent;

            if (listabutaca.c7 == "1")
                this.seat21.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat21.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila D
            if (listabutaca.d1 == "1")
                this.seat22.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat22.BackgroundColor = Color.Transparent;

            if (listabutaca.d2 == "1")
                this.seat23.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat23.BackgroundColor = Color.Transparent;

            if (listabutaca.d3 == "1")
                this.seat24.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat24.BackgroundColor = Color.Transparent;

            if (listabutaca.d4 == "1")
                this.seat25.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat25.BackgroundColor = Color.Transparent;

            if (listabutaca.d5 == "1")
                this.seat26.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat26.BackgroundColor = Color.Transparent;

            if (listabutaca.d6 == "1")
                this.seat27.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat27.BackgroundColor = Color.Transparent;

            if (listabutaca.d7 == "1")
                this.seat28.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat28.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila E
            if (listabutaca.e1 == "1")
                this.seat29.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat29.BackgroundColor = Color.Transparent;

            if (listabutaca.e2 == "1")
                this.seat30.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat30.BackgroundColor = Color.Transparent;

            if (listabutaca.e3 == "1")
                this.seat31.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat31.BackgroundColor = Color.Transparent;

            if (listabutaca.e4 == "1")
                this.seat32.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat32.BackgroundColor = Color.Transparent;

            if (listabutaca.e5 == "1")
                this.seat33.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat33.BackgroundColor = Color.Transparent;

            if (listabutaca.e6 == "1")
                this.seat34.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat34.BackgroundColor = Color.Transparent;

            if (listabutaca.e7 == "1")
                this.seat35.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat35.BackgroundColor = Color.Transparent;
            #endregion
            #region Fila F
            if (listabutaca.f1 == "1")
                this.seat36.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat36.BackgroundColor = Color.Transparent;

            if (listabutaca.f2 == "1")
                this.seat37.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat37.BackgroundColor = Color.Transparent;

            if (listabutaca.f3 == "1")
                this.seat38.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat38.BackgroundColor = Color.Transparent;

            if (listabutaca.f4 == "1")
                this.seat39.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat39.BackgroundColor = Color.Transparent;

            if (listabutaca.f5 == "1")
                this.seat40.BackgroundColor = Color.FromHex("#FFA500");
            else
                this.seat40.BackgroundColor = Color.Transparent;
            #endregion
        }


        private async void btncomprar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.TiendaPage());
        } 

        private void seat1_Clicked(object sender, EventArgs e)
        {
            if (listabutaca.a1 == "1")
                DisplayAlert("Advertencia", "El asiento ya esta ocupado", "Ok");
            else
            {
                btn = (Button)sender;
                if (btn.BackgroundColor.Equals(Color.Transparent))
                { 
                    btn.BackgroundColor = Color.FromHex("#FFFF00");
                    listabutaca.a1 = "1";
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