namespace FARMACIAYAJI;

public partial class MEDICINAS : ContentPage
{
	public MEDICINAS()
	{
		InitializeComponent();
	}

    private async void OnVitaminasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VITAMINAS());
    }

    // Evento para el botón de Jarabes
    private async void OnJarabesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JARABES());
    }

    // Evento para el botón de Pastillas
    private async void OnPastillasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PASTILLAS());
    }

    // Evento para el botón de Inyecciones
    private async void OnInyeccionesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new INYECCIONES());
    }


}