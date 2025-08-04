namespace NutriTrack.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void OnTrackMealClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Track Meal", "Navigate to meal tracking page.", "OK");
	}

	private async void OnViewStatsClicked(object sender, EventArgs e)
	{
		await DisplayAlert("View Stats", "Navigate to nutrition stats page", "OK");
	}
}