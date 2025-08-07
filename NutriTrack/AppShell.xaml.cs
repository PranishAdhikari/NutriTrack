using NutriTrack.Views;

namespace NutriTrack
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigation
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
            Routing.RegisterRoute(nameof(FoodInfoPage), typeof(FoodInfoPage));
        }
    }
}
