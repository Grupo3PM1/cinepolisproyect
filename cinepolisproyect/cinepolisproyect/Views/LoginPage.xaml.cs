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
    public partial class LoginPage : ContentPage
    {
        Authentication authentication;
        public LoginPage()
        {
            InitializeComponent();
            authentication = DependencyService.Get<Authentication>();
        }

        private async Task<bool> validarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(ttemail_user.Text) || String.IsNullOrWhiteSpace(ttpassword.Text))
            {
                await this.DisplayAlert("Advertencia", "Todos los campos son obligatorios.", "OK");
                return false;
            }


            bool isEmail = Regex.IsMatch(ttemail_user.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                await this.DisplayAlert("Advertencia", "El formato del correo electrónico es incorrecto, revíselo e intente de nuevo.", "OK");
                return false;
            }


            if (ttpassword.Text.Length < 8)
            {
                await this.DisplayAlert("Advertencia", "La contraseña debe ser mayor o igual a 8 dígitos. ", "OK");
                return false;
            }


            return true;
        }

        private void btn_contraseña_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void btn_registrate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroPage());
        }

        private async void btn_signIn_Clicked(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {

                    string token = await authentication.LoginWithEmailAndPassword(ttemail_user.Text, ttpassword.Text);
                    if (token != string.Empty)
                    {
                        Application.Current.MainPage = new HomePage();
                    }
                    else
                    {
                        await DisplayAlert("Error de Autenticacion", "Contraseña o correo invalido", "Ok");
                    }
               
            }
        }
    }
}