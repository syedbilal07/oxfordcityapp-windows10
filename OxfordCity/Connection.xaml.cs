using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace OxfordCity
{
    public sealed partial class Connection : Page
    {
        public Connection()
        {
            this.InitializeComponent();
        }
        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ContentPage));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StaticContentPage));
        }
    }
}
