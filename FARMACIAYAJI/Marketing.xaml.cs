namespace FARMACIAYAJI;

public partial class Marketing : ContentPage
{
	public Marketing()
	{
		InitializeComponent();
	}


    private async void OnCommentButtonClicked(object sender, EventArgs e)
    {
        string comentario = commentEditor.Text;

        if (!string.IsNullOrWhiteSpace(comentario))
        {
            // Muestra la alerta de agradecimiento
            await DisplayAlert("Gracias por tu comentario", "Gracias por tu comentario, lo tomaremos en cuenta para seguir mejorando.", "OK");

            // Limpia el campo de texto después de enviar el comentario
            commentEditor.Text = string.Empty;
        }
        else
        {
            await DisplayAlert("Error", "Por favor, escribe un comentario antes de enviar.", "OK");
        }
    }
}