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
        public ButacaPage(/*Ticket ticket*/)
        {
            InitializeComponent();
            /*SelectedTicket = ticket;
            Init();
            this.BindingContext = this;*/

        }

        private async void btncomprar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.TicketPage());
        }
    }
}