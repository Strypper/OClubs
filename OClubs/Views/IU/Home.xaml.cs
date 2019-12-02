using OClubs.Views.IU.About_Tab;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OClubs.Views.IU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }

        private void Sound_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Sound_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }

        private void HomePivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (HomePivot.SelectedIndex)
            {
                case 0:
                    DepartmentFrame.Navigate(typeof(ParentPage));
                    break;
                case 1:
                    AboutFrame.Navigate(typeof(AboutParentPage));
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
