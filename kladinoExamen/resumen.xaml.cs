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
    public partial class resumen : ContentPage
    {
        string usuario;
        public resumen( string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = "" + usuario;
            this.usuario = usuario;
        }

        private void btnsalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());

    
        }
    }
}