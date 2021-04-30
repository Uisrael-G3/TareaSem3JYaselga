using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSem3JYaselga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2 : ContentPage
    {
        public Ventana2(string usuario, string clave)
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
			try
			{
				//Acciones del programa
				double dato1 = Convert.ToDouble(txtDato1.Text);
				double dato2 = Convert.ToDouble(txtDato2.Text);

				double dato3 = Convert.ToDouble(txtDato3.Text);
				double dato4 = Convert.ToDouble(txtDato4.Text);

				double suma = (dato1 / 10) * 3;
				double suma2 = (dato2 / 10) * 2;
				double notap1 = suma + suma2;

				double suma3 = (dato3 / 10) * 3;
				double suma4 = (dato4 / 10) * 2;
				double notap2 = suma3 + suma4;

				double nfinal = notap1 + notap2;

				txtResultado1.Text = notap1.ToString();
				txtResultado3.Text = notap2.ToString();
				txtNfinal.Text = nfinal.ToString();

				if (nfinal >= 7)
				{

					txtEstado.Text = "Aprobado";
				}
				if (nfinal >= 5 && nfinal <= 6.9)
				{
					txtEstado.Text = "Complementario";
				}

				if (nfinal < 7)
				{

					txtEstado.Text = "Reprobado";
				}

			}
			catch (Exception ex)
			{
				//Excepciones  - Errores del programa
				DisplayAlert("Alerta", ex.Message, "OK");

			}
		}
    }
}