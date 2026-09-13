namespace CeramicManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(
            IActivationState? activationState)
        {
            Window window =
                new Window(
                    new AppShell());

#if WINDOWS

            window.Title =
                "CeramicManager";

            window.TitleBar =
                new TitleBar
                {
                    Title =
                        "",

                    Content =
                        new Label
                        {
                            Text =
                                "CeramicManager",

                            FontSize =
                                14,

                            FontAttributes =
                                FontAttributes.Bold,

                            HorizontalTextAlignment =
                                TextAlignment.Center,

                            HorizontalOptions =
                                LayoutOptions.Fill,

                            VerticalTextAlignment =
                                TextAlignment.Center,

                            VerticalOptions =
                                LayoutOptions.Center
                        }
                };

#endif

            return window;
        }
    }
}