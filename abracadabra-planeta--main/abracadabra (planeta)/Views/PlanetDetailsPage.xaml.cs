namespace Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(PlanetDetailsPage planet)
	{
		InitializeComponent();

        this.BindingContext = planet;
	}
}