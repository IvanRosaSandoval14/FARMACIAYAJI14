namespace FARMACIAYAJI;

public partial class VITAMINAS : ContentPage
{
	public VITAMINAS()
	{
		InitializeComponent();
	}

    private async void OnAdquirirClicked(object sender, EventArgs e)
    {
        // Obtener el botón clicado
        Button button = sender as Button;

        // Obtener el parámetro del producto (nombre del producto)
        string nombreProducto = button?.CommandParameter?.ToString() ?? "Producto Desconocido";

        // Navegar a la página de facturación
        // Aquí también puedes pasar "nombreProducto" a la página de facturación si lo necesitas
        await Navigation.PushAsync(new FACTURACION());

        // Si necesitas pasar el nombre del producto a la página de facturación:
        // await Navigation.PushAsync(new FACTURACION(nombreProducto));
    }

}