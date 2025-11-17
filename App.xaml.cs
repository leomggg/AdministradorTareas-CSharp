using AdministradorTareas.MVVM.Views;

namespace AdministradorTareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new PagPrincView()));
        }
    }
}