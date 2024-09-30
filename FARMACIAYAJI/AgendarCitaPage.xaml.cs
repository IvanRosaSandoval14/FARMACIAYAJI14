namespace FARMACIAYAJI;

public partial class AgendarCitaPage : ContentPage
{
    private Doctor _doctor;
    public AgendarCitaPage(Doctor doctor)
    {
        InitializeComponent();
        _doctor = doctor;
    }


    async void OnAgendarClicked(object sender, EventArgs e)
    {
        // Aquí puedes guardar la cita en una base de datos o enviarla a un servicio

        // Mostrar alerta de que la cita ha sido agendada
        await DisplayAlert("Cita Agendada", "Su cita ha sido agendada.", "OK");

        // Regresar a la página principal o donde desees
        await Navigation.PopToRootAsync();
    }
}