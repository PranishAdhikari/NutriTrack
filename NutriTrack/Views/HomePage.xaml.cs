using Microsoft.Maui.Controls;

namespace NutriTrack.Views
{

    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnJourneyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JourneyPage());
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

        private async void OnFoodInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodInfoPage());
        }
    }
}
