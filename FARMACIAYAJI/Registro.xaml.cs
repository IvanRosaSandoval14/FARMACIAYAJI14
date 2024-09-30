using Microsoft.Maui.Controls;
using System;

namespace FARMACIAYAJI
{
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private async void logginBTN_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text; // Obtener el nombre de usuario
            string password = passwordEntry.Text; // Obtener la contraseña

            // Validar que tanto el nombre de usuario como la contraseña no estén vacíos
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Permitir el acceso a cualquier combinación válida de nombre de usuario y contraseña
                await DisplayAlert("Inicio de sesión", "¡Inicio de sesión exitoso!", "OK");

                // Pasar solo el nombre del usuario a la página INGRESAR
                await Navigation.PushAsync(new INGRESAR(username));
            }
            else
            {
                // Si los campos están vacíos, mostrar un mensaje de error
                await DisplayAlert("Error", "Por favor, completa el nombre de usuario y la contraseña.", "OK");
            }
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Registro", "Funcionalidad de registro aún no implementada.", "OK");
        }
    }
}