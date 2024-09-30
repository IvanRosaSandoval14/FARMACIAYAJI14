namespace FARMACIAYAJI;

public partial class Equipo : ContentPage
{
	public Equipo()
	{
		InitializeComponent();

        List<Doctor> doctores = new List<Doctor>
            {
                new Doctor { NombreCompleto = "Dr. Juan Pérez", Especialidad = "Terapeuta", Edad = 45, Telefono = "555-1234", Correo = "juan.perez@correo.com", LugarAtencion = "Clínica Central", HorarioAtencion = "Lunes a Viernes 8am-5pm", Foto = "doctor.png" },
                new Doctor { NombreCompleto = "Dra. Ana López", Especialidad = "Pediatría", Edad = 38, Telefono = "555-5678", Correo = "ana.lopez@correo.com", LugarAtencion = "Hospital Infantil", HorarioAtencion = "Lunes a Viernes 10am-4pm", Foto = "doctorana.png" },
                new Doctor { NombreCompleto = "Dr. Pedro Martinez", Especialidad = "Cardiologia", Edad = 40, Telefono = "5778-9978", Correo = "pedro.martinez@correo.com", LugarAtencion = "Hospital Fosalud", HorarioAtencion = "Lunes a Viernes 9am-6pm", Foto = "medicoped.png" },
                 new Doctor { NombreCompleto = "Dr. Miguel Gonzales", Especialidad = "Cirujano General", Edad = 42, Telefono = "2345-9854", Correo = "miguel.gonzales@correo.com", LugarAtencion = "Hospital Rosales", HorarioAtencion = "Lunes a Viernes 11am-5pm", Foto = "cirujano.png" },
                  new Doctor { NombreCompleto = "Dra. Maria Olmedo ", Especialidad = "Ginecologa", Edad = 35, Telefono = "8445-9423", Correo = "maria.olmedo@correo.com", LugarAtencion = "Hospital de Maternidad", HorarioAtencion = "Lunes a Viernes 7am-3pm", Foto = "ginecologo.png" },
                 new Doctor { NombreCompleto = "Dra. Gabriela Sanchez ", Especialidad = "Dermatologa", Edad = 33, Telefono = "1587-4492", Correo = "gaby.sanchez@correo.com", LugarAtencion = "Hospital San Rafael", HorarioAtencion = "Lunes a Viernes 10am-8pm", Foto = "dermatologo.png" },
                 new Doctor { NombreCompleto = "Dr. Mario Garcia ", Especialidad = "Dentista", Edad = 27, Telefono = "4598-3415", Correo = "mario.garcia@correo.com", LugarAtencion = "Hospital Bloom", HorarioAtencion = "Lunes a Viernes 8am-5pm", Foto = "dentista.png" },
                   new Doctor { NombreCompleto = "Dr. Fernando Gomez ", Especialidad = "Ortopeda", Edad = 36, Telefono = "7834-9203", Correo = "fernando.gomez@correo.com", LugarAtencion = "Hospital Zacamil", HorarioAtencion = "Lunes a Viernes 2pm- 9pm", Foto = "ortopedista.png" },
                    new Doctor { NombreCompleto = "Dr. Luis Orellana ", Especialidad = "Anestiosologo", Edad = 24, Telefono = "7456-2055", Correo = "luis.orellana@correo.com", LugarAtencion = "Hospital Primero de Mayo", HorarioAtencion = "Lunes a Viernes 9am- 7pm", Foto = "anestesiologo.png" },
                     new Doctor { NombreCompleto = "Dra. Pamela Carballo ", Especialidad = "psiquiatra", Edad = 40, Telefono = "7654-9284", Correo = "pamela.orellana@correo.com", LugarAtencion = "Hospital de Lourdes", HorarioAtencion = "Lunes a Viernes 8am- 4pm", Foto = "psiquiatra.png" },
                // Agrega más doctores aquí...
            };

        // Asignar la lista de doctores al ListView
        DoctoresListView.ItemsSource = doctores;
    }


    async void OnDoctorSelected(object sender, ItemTappedEventArgs e)
    {
        if (e.Item == null) return;

        var doctorSeleccionado = e.Item as Doctor;
        if (doctorSeleccionado != null)
        {
            // Navegar a la página de detalles pasando el doctor seleccionado
            await Navigation.PushAsync(new DoctorDetailPage(doctorSeleccionado));
        }

           // Desmarcar el item seleccionado
           ((ListView)sender).SelectedItem = null;
    }

}