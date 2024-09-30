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
        DoctorTelefono.Text = "Tel�fono: " + doctor.Telefono;
        DoctorCorreo.Text = "Correo: " + doctor.Correo;
        DoctorLugarAtencion.Text = "Lugar de Atenci�n: " + doctor.LugarAtencion;
        DoctorHorarioAtencion.Text = "Horario de Atenci�n: " + doctor.HorarioAtencion;
    }

    // Evento que se ejecuta cuando se hace clic en el bot�n "Agendar Cita"
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

        // Validar que los campos no est�n vac�os
        if (string.IsNullOrEmpty(nombrePaciente) || string.IsNullOrEmpty(telefonoPaciente))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        // Aqu� puedes a�adir el c�digo para agendar la cita (enviar a un servicio, guardar localmente, etc.)
        await DisplayAlert("Cita Confirmada", $"La cita ha sido agendada para {nombrePaciente}  a las {horaCita}.", "OK");

        // Limpiar formulario despu�s de confirmar
        PacienteNombre.Text = string.Empty;
        PacienteTelefono.Text = string.Empty;
       
        HoraCita.Time = new TimeSpan(0, 0, 0);
    }
}