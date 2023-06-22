using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kladinoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario;
        public registro(string usuario)
        {
         
            InitializeComponent();
            lbUsuario.Text = "" + usuario;
            this.usuario = usuario;
        }

        private void btnPagoM_Clicked(object sender, EventArgs e)
        {
            double costoTotal = 1800;
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);

            if (double.TryParse(txtMontoInicial.Text, out double valorIngresado))
            {
                double montoRestante = costoTotal - montoInicial;
                double montoPorCuota = montoRestante / 3;
                double porcentajeIncremento = montoPorCuota * 0.05;
                double mensualidad = montoPorCuota + porcentajeIncremento;


                txtePagoMensual.Text = mensualidad.ToString("C");
            }
            else
            {
                DisplayAlert("Error", "Ingresa un valor válido.", "Aceptar");
            }
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
           
           

            Navigation.PushAsync(new resumen(usuario));
            
        }

        private void dpPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMontoInicial_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}