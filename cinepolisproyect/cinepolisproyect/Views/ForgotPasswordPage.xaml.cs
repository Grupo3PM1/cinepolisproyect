using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinepolisproyect.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        Authentication authentication;
        public ForgotPasswordPage()
        {
            InitializeComponent();
            authentication = DependencyService.Get<Authentication>();
        }

        private async Task<bool> validarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(ttemail_user_recu.Text))
            {
                await this.DisplayAlert("Advertencia", "El campos es obligatorio.", "OK");
                return false;
            }


            bool isEmail = Regex.IsMatch(ttemail_user_recu.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                await this.DisplayAlert("Advertencia", "El formato del correo electrónico es incorrecto, revíselo e intente de nuevo.", "OK");
                return false;
            }



            return true;
        }

        private async void btn_restablecer_Clicked(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {
                await authentication.ResetPassword(ttemail_user_recu.Text);
                await this.DisplayAlert("Advertencia", "Hemos enviado un enlace a tu direccion de correo electronico para que puedas restablecer tu contraseña", "OK");
                await Navigation.PushAsync(new LoginPage());

            }
        }
    }
}