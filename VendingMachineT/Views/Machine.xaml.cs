namespace VendingMachineT.Views;

public partial class Machine : ContentPage
{
	public Machine()
	{
		InitializeComponent();
	}

    private async void NewPage(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new machineDetails());
    }
}