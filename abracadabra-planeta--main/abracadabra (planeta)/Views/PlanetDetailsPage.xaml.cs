namespace Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(PlanetDetailsPage planet)
	{
		InitializeComponent();

        this.BindingContext = planet;
	}

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}