using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace FARMACIAYAJI
{
    public partial class ATENCION : ContentPage
    {
        private readonly LocalDbService _dbService; // Servicio de base de datos
        private int _editEmpleadoId;

        // Constructor que acepta LocalDbService
        public ATENCION(LocalDbService dbService)
        {
            InitializeComponent();
            _dbService = dbService; // Asignar el servicio de base de datos
            LoadEmpleados(); // Cargar empleados
        }

        private async void LoadEmpleados()
        {
            listview.ItemsSource = await _dbService.GetEmpleados();
        }

        // Agregar o editar empleado
        private async void agregarBtn_Clicked(object sender, EventArgs e)
        {
            // Validar edad
            if (int.TryParse(EntryEdad.Text, out int edad) && edad < 18)
            {
                await DisplayAlert("Error", "¡NO TIENES LA EDAD SUFICIENTE PARA SER CONTRATADO!", "OK");
                return;
            }

            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(EntryNombre.Text) || edad < 1 || string.IsNullOrWhiteSpace(EntryDUI.Text) ||
                string.IsNullOrWhiteSpace(EntryTelefono.Text) || string.IsNullOrWhiteSpace(EntryResidencia.Text) ||
                string.IsNullOrWhiteSpace(PickerNivelEstudio.SelectedItem?.ToString()))
            {
                await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            // Crear nuevo empleado
            var empleado = new Empleado
            {
                NombreCompleto = EntryNombre.Text,
                Edad = edad,
                DUI = EntryDUI.Text,
                Telefono = EntryTelefono.Text,
                Residencia = EntryResidencia.Text,
                NivelEstudio = PickerNivelEstudio.SelectedItem.ToString(),
                FechaContratacion = DateTime.Now
            };

            // Si se está creando un nuevo empleado
            if (_editEmpleadoId == 0)
            {
                await _dbService.Create(empleado);
                await DisplayAlert("Bienvenido", "¡FELICIDADES HAS SIDO CONTRATADO!", "OK");
            }
            else // Si se está editando un empleado existente
            {
                empleado.Id = _editEmpleadoId;
                await _dbService.Update(empleado);
                _editEmpleadoId = 0; // Reinicia el ID de edición
            }

            // Limpiar campos y recargar empleados
            ClearEntries();
            LoadEmpleados();
        }

        // Limpiar campos de entrada
        private void ClearEntries()
        {
            EntryNombre.Text = string.Empty;
            EntryEdad.Text = string.Empty;
            EntryDUI.Text = string.Empty;
            EntryTelefono.Text = string.Empty;
            EntryResidencia.Text = string.Empty;
            PickerNivelEstudio.SelectedItem = null; // Limpiar selección del Picker
        }

        // Manejar la acción de selección de un empleado en la lista
        private async void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var empleado = (Empleado)e.Item; // Obtener el empleado seleccionado
            var action = await DisplayActionSheet("Acción", "Cancelar", null, "Editar", "Eliminar");

            switch (action)
            {
                case "Editar":
                    // Rellenar campos con datos del empleado seleccionado
                    _editEmpleadoId = empleado.Id;
                    EntryNombre.Text = empleado.NombreCompleto;
                    EntryEdad.Text = empleado.Edad.ToString();
                    EntryDUI.Text = empleado.DUI;
                    EntryTelefono.Text = empleado.Telefono;
                    EntryResidencia.Text = empleado.Residencia;
                    PickerNivelEstudio.SelectedItem = empleado.NivelEstudio;
                    break;

                case "Eliminar":
                    // Eliminar el empleado seleccionado
                    await _dbService.Delete(empleado);
                    LoadEmpleados(); // Recargar lista de empleados
                    break;
            }
        }
    }
}