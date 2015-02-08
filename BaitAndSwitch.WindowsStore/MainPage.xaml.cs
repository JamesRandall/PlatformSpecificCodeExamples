using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using BaitAndSwitch.Domain;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BaitAndSwitch.WindowsStore
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void InitializeStorage(object sender, RoutedEventArgs e)
        {
            Storage storage = new Storage();
            storage.Initialize(ApplicationData.Current.LocalFolder.Path);
        }
    }
}
