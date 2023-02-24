using Ejercicio1_2.Configuracion;
using Ejercicio1_2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            Personas persona = new Personas();
            persona.Nombre = nombres.Text;
            persona.Apellido = apellidos.Text;
            persona.Edad = Convert.ToInt32(edad.Text);
            persona.Correo = correo.Text;
            await Navigation.PushAsync(new PageResultado { BindingContext = persona });
        }
    }
}
