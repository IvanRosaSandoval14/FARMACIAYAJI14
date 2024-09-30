using System;
using Microsoft.Maui.Controls;

namespace FARMACIAYAJI
{
    public partial class INGRESAR : ContentPage
    {
        public INGRESAR(string nombre)
        {
            InitializeComponent();
            // Mostrar el nombre del usuario en el label
            UsuarioNombreLabel.Text = $"USUARIO: {nombre}";
        }

        // Métodos para manejar los clics en los botones
        private async void OnMedicinasClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MEDICINAS());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnFacturacionClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new FACTURACION());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnAtencionClicked(object sender, EventArgs e)
        {
            try
            {
                var dbService = new LocalDbService();
                await Navigation.PushAsync(new ATENCION(dbService));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnDeliveryClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DELIVERY());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnMarketClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Marketing());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnEquipoClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Equipo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

     
    }
}