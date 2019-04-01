using Windows.UI.Xaml.Controls;

namespace OxfordCity
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void Get_Start(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Connection));
        }
    }
}
