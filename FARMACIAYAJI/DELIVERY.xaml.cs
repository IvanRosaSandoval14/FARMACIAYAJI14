namespace FARMACIAYAJI;

public partial class DELIVERY : ContentPage
{
    public DELIVERY()
    {
        InitializeComponent();
    }

    // Evento del bot�n 'Hacer Pedido'
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
            $"Tel�fono: {telefono}\n" +
            $"Direcci�n: {direccion}\n" +
            $"Correo Electr�nico: {email}\n\n" +
            $"Fecha y Hora del Pedido: {fechaHoraPedido}\n\n" +
            "�Tu pedido llegar� pronto!", "OK");
    }
}