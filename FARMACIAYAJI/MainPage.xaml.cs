using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace FARMACIAYAJI
{
    public partial class MainPage : ContentPage
    {
        private DatabaseService _databaseService;

        public MainPage()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
        }

        private async void OnIngresarClicked(object sender, EventArgs e)
        {
            // Verifica si el usuario ya está registrado
            var users = await _databaseService.GetUsersAsync();
            if (users.Any())
            {
                // Si hay usuarios registrados, navega a la página de ingreso
                await Navigation.PushAsync(new ());
            }
            else
            {
                await DisplayAlert("Aviso", "No hay usuarios registrados. Por favor, regístrate primero.", "OK");
            }
        }

        private async void OnREGISTRARClicked(object sender, EventArgs e)
        {
            // Navegar a la página de Registro
            await Navigation.PushAsync(new Registro());
        }
    }
}