
using System.Threading.Tasks;
using System.Windows;
using Squirrel;

namespace SquirrelWPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckForUpdates().ConfigureAwait(true);
        }

        private async Task CheckForUpdates()
        {
            using (var updateManager = new UpdateManager(@"U:\DevDSL\SquirrelAlpha\TestProgram"))
            {
                await updateManager.UpdateApp();
            }
        }

        private void InfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the most useless Program in the whole World");
        }

        private void UploadButton_OnClick(object sender, RoutedEventArgs e)
        {

            string url = "https://pm1.narvii.com/6875/f8dffc2de4ba3ef40f92be1eb6d90cf2ec48e07er1-1080-1080v2_hq.jpg";

            System.Diagnostics.Process.Start(url);
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

