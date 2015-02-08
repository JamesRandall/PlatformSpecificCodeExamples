using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DependencyInjection.Domain;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DependencyInjection.WindowsStore
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

        private async void WriteSomeBytes(object sender, RoutedEventArgs e)
        {
            IFileWriter fileWriter = new FileWriterImpl();
            BasicDomainImplementation domainImplementation = new BasicDomainImplementation(fileWriter);
            await domainImplementation.WriteBytes();
        }
    }
}
