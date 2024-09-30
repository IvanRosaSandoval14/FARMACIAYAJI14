namespace FARMACIAYAJI;

public partial class DoctorDetailPage : ContentPage
{
    private Doctor doctor;

    public DoctorDetailPage(Doctor selectedDoctor)
    {
        InitializeComponent();
        doctor = selectedDoctor;
        LoadDoctorData();
    }

    private void LoadDoctorData()
    {
        // Cargar los datos del doctor en los controles de la vista
        DoctorFoto.Source = doctor.Foto; // Asumiendo que Foto es el nombre de un recurso de imagen
        DoctorNombre.Text = doctor.NombreCompleto;
        DoctorEspecialidad.Text = "Especialidad: " + doctor.Especialidad;
        DoctorEdad.Text = "Edad: " + doctor.Edad.ToString();
        DoctorTelefono.Text = "Teléfono: " + doctor.Telefono;
        DoctorCorreo.Text = "Correo: " + doctor.Correo;
        DoctorLugarAtencion.Text = "Lugar de Atención: " + doctor.LugarAtencion;
        DoctorHorarioAtencion.Text = "Horario de Atención: " + doctor.HorarioAtencion;
    }

    // Evento que se ejecuta cuando se hace clic en el botón "Agendar Cita"
    private async void OnAgendarCitaClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Cita Agendada", "Su cita ha sido agendada con el " + doctor.NombreCompleto, "OK");
    }


    private async void OnConfirmarCitaClicked(object sender, EventArgs e)
    {
        // Obtener datos del formulario
        string nombrePaciente = PacienteNombre.Text;
        string telefonoPaciente = PacienteTelefono.Text;
       
        TimeSpan horaCita = HoraCita.Time;

        // Validar que los campos no estén vacíos
        if (string.IsNullOrEmpty(nombrePaciente) || string.IsNullOrEmpty(telefonoPaciente))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        // Aquí puedes añadir el código para agendar la cita (enviar a un servicio, guardar localmente, etc.)
        await DisplayAlert("Cita Confirmada", $"La cita ha sido agendada para {nombrePaciente}  a las {horaCita}.", "OK");

        // Limpiar formulario después de confirmar
        PacienteNombre.Text = string.Empty;
        PacienteTelefono.Text = string.Empty;
       
        HoraCita.Time = new TimeSpan(0, 0, 0);
    }
}