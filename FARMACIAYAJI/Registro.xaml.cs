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
            string password = passwordEntry.Text; // Obtener la contrase�a

            // Validar que tanto el nombre de usuario como la contrase�a no est�n vac�os
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Permitir el acceso a cualquier combinaci�n v�lida de nombre de usuario y contrase�a
                await DisplayAlert("Inicio de sesi�n", "�Inicio de sesi�n exitoso!", "OK");

                // Pasar solo el nombre del usuario a la p�gina INGRESAR
                await Navigation.PushAsync(new INGRESAR(username));
            }
            else
            {
                // Si los campos est�n vac�os, mostrar un mensaje de error
                await DisplayAlert("Error", "Por favor, completa el nombre de usuario y la contrase�a.", "OK");
            }
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Registro", "Funcionalidad de registro a�n no implementada.", "OK");
        }
    }
}