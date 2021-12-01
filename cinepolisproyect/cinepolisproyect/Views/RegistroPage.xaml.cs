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
    public partial class RegistroPage : ContentPage
    {
        Authentication authentication;
        public RegistroPage()
        {
            InitializeComponent();
            authentication = DependencyService.Get<Authentication>();
        }

        private async Task<bool> validarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(ttname.Text) || String.IsNullOrWhiteSpace(ttlastname.Text) || String.IsNullOrWhiteSpace(ttemail.Text) || String.IsNullOrWhiteSpace(ttpassword.Text))
            {
                await this.DisplayAlert("Advertencia", "Todos los campos son obligatorios.", "OK");
                return false;
            }


            bool isEmail = Regex.IsMatch(ttemail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
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


        private void btn_enviologin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private async void btn_registrar_Clicked(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {
              
                try
                {
                    var user = authentication.SignUpWithEmailAndPassword(ttemail.Text, ttpassword.Text);
                    if (user != null)
                    {
                        await DisplayAlert("Exito", "Usuario creado correctamente", "Ok");
                        var signOut = authentication.SignOut();
                        await this.DisplayAlert("Advertencia", "Hemos enviado un enlace a tu direccion de correo electronico para que verificar tu cuenta. ", "OK");

                        if (signOut)
                        {
                           await Navigation.PushAsync(new LoginPage());
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "Error al crear usuario", "Ok");
                    }
                }
                catch(Exception exception)
                {
                    if (exception.Message.Contains("EMAIL_EXISTS"))
                    {
                        await DisplayAlert("Advertencia", "La direccion de correo electronico ya esta siendo usada por otra cuenta. ", "Ok");
                    }
                    else
                    {
                        await DisplayAlert("Error", exception.Message, "Ok");
                    }
                }
               

            }
        }
    }
}