using Microsoft.Extensions.DependencyInjection;

namespace MauiHotelApp
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        [Obsolete]
        protected override Window CreateWindow(IActivationState? activationState)
        {
        // Use the already assigned MainPage when creating the native Window so
        // the page set in the App constructor (eg. NavigationPage -> ContratacaoHospedagem)
        // is displayed. Fallback to AppShell if MainPage is null.
        var contentPage = MainPage ?? new AppShell();

        var window = new Window(contentPage)
        {
            Width = 400,
            Height = 700,
            X = 100,
            Y = 50
        };

        return window;
        }
    }
}