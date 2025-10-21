namespace Age12MauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base. CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;

        }
    } // fecha classe 

} // fecha namespace
