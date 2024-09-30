namespace FARMACIAYAJI
{
    public partial class JARABES : ContentPage
    {
        public JARABES()
        {
            InitializeComponent();
        }

        private async void OnAdquirirClicked(object sender, EventArgs e)
        {
            // Cast del botón que fue clicado
            Button button = sender as Button;

            // Aquí podrías determinar qué producto fue seleccionado, por ejemplo:
            // Si los botones tienen identificadores únicos o nombres asociados, los recuperas:
            string nombreProducto = ""; // Puedes obtener el nombre del producto según el botón clicado.

            // Navegación a la página de facturación
            await Navigation.PushAsync(new FACTURACION());
        }
    }
}