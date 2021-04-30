using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSem3JYaselga
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentana_Clicked(object sender, EventArgs e)
        {
            try
            {

                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new Ventana2(usuario, clave));
                }
                else
                    await DisplayAlert("Alerta", "Usuario o Contraseña son incorrectos", "OK");

            }
            catch (Exception ex)
            {

                await DisplayAlert("Alerta", ex.Message, "OK");
            }

        }
    }
}
