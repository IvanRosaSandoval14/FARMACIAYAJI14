using System;
using System.Collections.Generic;

namespace FARMACIAYAJI
{
    public partial class FACTURACION : ContentPage
    {
        private List<Producto> _productos = new List<Producto>();
        private decimal _total = 0;
        private DatabaseService _dbService;

        public FACTURACION()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
        }

        // Método para agregar un producto
        private void OnAgregarProductoClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreProductoEntry.Text) ||
                string.IsNullOrWhiteSpace(precioProductoEntry.Text) ||
                string.IsNullOrWhiteSpace(stockProductoEntry.Text))
            {
                DisplayAlert("Error", "Todos los campos del producto deben estar llenos", "OK");
                return;
            }

            try
            {
                // Crear el producto y agregarlo a la lista
                var producto = new Producto
                {
                    Nombre = nombreProductoEntry.Text,
                    Precio = decimal.Parse(precioProductoEntry.Text),
                    Stock = int.Parse(stockProductoEntry.Text)
                };

                _productos.Add(producto);

                // Calcular el nuevo total
                _total += producto.Precio * producto.Stock;

                // Actualizar el total en la interfaz
                totalLabel.Text = $"Total: ${_total}";

                // Limpiar los campos del producto
                nombreProductoEntry.Text = string.Empty;
                precioProductoEntry.Text = string.Empty;
                stockProductoEntry.Text = string.Empty;
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Error al procesar el producto. Verifica los datos.", "OK");
            }
        }

        // Método para finalizar la compra
        private async void OnFinalizarCompraClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(correoClienteEntry.Text))
            {
                await DisplayAlert("Error", "Debes ingresar los datos del cliente", "OK");
                return;
            }

            // Crear una nueva factura
            var factura = new Factura
            {
                NombreCliente = nombreClienteEntry.Text,
                CorreoCliente = correoClienteEntry.Text,
                Total = _total
            };

            // Guardar la factura en la base de datos
            await _dbService.SaveFacturaAsync(factura);

            // Obtener la fecha y hora actual
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Crear una lista con los nombres de los productos comprados
            string productosComprados = string.Join(", ", _productos.ConvertAll(p => $"{p.Nombre} (Cantidad: {p.Stock})"));

            // Mostrar alerta personalizada con los datos del cliente, los productos y la factura
            string mensajeFactura = $"FARMACIA YAJI\n" +
                                    $"FACTURA\n" +
                                    $"Cliente: {factura.NombreCliente}\n" +
                                    $"Correo: {factura.CorreoCliente}\n" +
                                    $"Productos Comprados: {productosComprados}\n" +
                                    $"Total: ${factura.Total}\n" +
                                    $"Fecha y Hora: {fechaHora}\n" +
                                    $"La compra fue un éxito.";

            await DisplayAlert("Compra Exitosa", mensajeFactura, "OK");

            // Limpiar la interfaz
            nombreClienteEntry.Text = string.Empty;
            correoClienteEntry.Text = string.Empty;
            totalLabel.Text = "Total: $0";
            _total = 0;
            _productos.Clear();
        }

        // Método para navegar a la página de Delivery
        private async void OnIrADeliveryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DELIVERY());
        }
    }
}