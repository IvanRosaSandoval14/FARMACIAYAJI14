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
            // Cast del bot�n que fue clicado
            Button button = sender as Button;

            // Aqu� podr�as determinar qu� producto fue seleccionado, por ejemplo:
            // Si los botones tienen identificadores �nicos o nombres asociados, los recuperas:
            string nombreProducto = ""; // Puedes obtener el nombre del producto seg�n el bot�n clicado.

            // Navegaci�n a la p�gina de facturaci�n
            await Navigation.PushAsync(new FACTURACION());
        }
    }
}