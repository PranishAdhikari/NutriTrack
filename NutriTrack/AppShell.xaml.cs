using NutriTrack.Views;

namespace NutriTrack;

    public partial class AppShell : Shell
    {
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
    }
}