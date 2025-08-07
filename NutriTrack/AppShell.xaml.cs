using NutriTrack.Views;

namespace NutriTrack;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Optional if you're already declaring them in XAML, but useful for deep links or non-tab navigation
        Routing.RegisterRoute("HomePage", typeof(HomePage));
        Routing.RegisterRoute("SearchPage", typeof(SearchPage));
        Routing.RegisterRoute("FoodInfoPage", typeof(FoodInfoPage));
    }
}
