namespace FARMACIAYAJI;

public partial class DELIVERY : ContentPage
{
    public DELIVERY()
    {
        InitializeComponent();
    }

    // Evento del botón 'Hacer Pedido'
    private async void OnHacerPedidoClicked(object sender, EventArgs e)
    {
        // Capturar los datos ingresados
        string nombre = nombreEntry.Text;
        string dui = duiEntry.Text;
        string telefono = telefonoEntry.Text;
        string direccion = direccionEntry.Text;
        string email = emailEntry.Text;

        // Obtener fecha y hora actuales
        DateTime fechaHoraPedido = DateTime.Now;

        // Mostrar la alerta con los datos del pedido
        await DisplayAlert("Pedido Realizado",
            $"Nombre: {nombre}\n" +
            $"DUI: {dui}\n" +
            $"Teléfono: {telefono}\n" +
            $"Dirección: {direccion}\n" +
            $"Correo Electrónico: {email}\n\n" +
            $"Fecha y Hora del Pedido: {fechaHoraPedido}\n\n" +
            "¡Tu pedido llegará pronto!", "OK");
    }
}