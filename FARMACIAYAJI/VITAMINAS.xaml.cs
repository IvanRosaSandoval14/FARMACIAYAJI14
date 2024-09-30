namespace FARMACIAYAJI;

public partial class VITAMINAS : ContentPage
{
	public VITAMINAS()
	{
		InitializeComponent();
	}

    private async void OnAdquirirClicked(object sender, EventArgs e)
    {
        // Obtener el bot�n clicado
        Button button = sender as Button;

        // Obtener el par�metro del producto (nombre del producto)
        string nombreProducto = button?.CommandParameter?.ToString() ?? "Producto Desconocido";

        // Navegar a la p�gina de facturaci�n
        // Aqu� tambi�n puedes pasar "nombreProducto" a la p�gina de facturaci�n si lo necesitas
        await Navigation.PushAsync(new FACTURACION());

        // Si necesitas pasar el nombre del producto a la p�gina de facturaci�n:
        // await Navigation.PushAsync(new FACTURACION(nombreProducto));
    }

}