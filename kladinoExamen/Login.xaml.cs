﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kladinoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contraseña = "uisrael2023";

            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario/Contraseña incorrecta", "Cerrar");
            }
        }
    }
}