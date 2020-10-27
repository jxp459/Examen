using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JuniorParragaExamen
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string pago)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtPagoTotal.Text = pago;
        }
    }
}
