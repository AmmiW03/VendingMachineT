namespace VendingMachineT.Views;

public partial class Machine : ContentPage
{
	public Machine()
	{
		InitializeComponent();
	}

    private async void NewPage(object sender, EventArgs e)
    {
        // Aquí es donde se realiza la navegación a la otra página
        await Navigation.PushAsync(new machineDetails());
    }
}