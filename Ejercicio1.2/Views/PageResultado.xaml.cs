using Ejercicio1_2.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class PageResultado : ContentPage
{
    public PageResultado()
    {
        InitializeComponent();
    }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Obtener el objeto Personas del BindingContext
            Personas persona = (Personas)BindingContext;

            // Configurar el texto del Label con los datos de Personas
            DatosPersona.Text = $"Nombre: {persona.Nombre}\nApellido: {persona.Apellido}\nEdad: {persona.Edad}\nCorreo: {persona.Correo}";
        }
    }
}