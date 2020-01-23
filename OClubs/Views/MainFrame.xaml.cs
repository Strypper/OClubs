using OClubs.Views.Clubs;
using OClubs.Views.IU;
using OClubs.Views.IU.About_Tab;
using OClubs.Views.IU___Store.MainLayout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OClubs.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainFrame : Page
    {
        public MainFrame()
        {
            this.InitializeComponent();
            TheMainFrame.Navigate(typeof(Home));
        }

        private void MainFrameNavigation_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                TheMainFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                NavView_Navigate(item);
            }
        }

        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Name)
            {
                case "OnlineClubs":
                    TheMainFrame.Navigate(typeof(OnlineClubs));
                    TheMainFrame.Translation = new System.Numerics.Vector3(0, 0, 250);
                    break;
                case "Browse":
                    break;
                case "IUServices":
                    TheMainFrame.Navigate(typeof(Home));
                    TheMainFrame.Translation = new System.Numerics.Vector3(0, 0, 250);
                    break;
                case "Shop":
                    TheMainFrame.Navigate(typeof(StoreView));
                    TheMainFrame.Translation = new System.Numerics.Vector3(0, 300, 0);
                    break;
                default:
                    TheMainFrame.Navigate(typeof(Home));
                    break;
            }
        }

        private void ClubManagement_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TheMainFrame.Navigate(typeof(ClubDetail));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RequestedTheme = ElementTheme.Light;
            MainFramePage.Background = new SolidColorBrush(Color.FromArgb(100, 255, 255, 224));
            //BackgroundGridShadow.Receivers.Add(BackgroundGrid);

            //OnlineClubs.IsSelected = true;
        }

        private void NavViewSearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            TheMainFrame.Translation = new System.Numerics.Vector3(0, 200, 0);
        }

        private void Mode_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    RequestedTheme = ElementTheme.Dark;
                    MainFramePage.Background = new SolidColorBrush(Color.FromArgb(100, 62, 62, 66));
                }
                else
                {
                    RequestedTheme = ElementTheme.Light;
                    MainFramePage.Background = new SolidColorBrush(Color.FromArgb(100, 255, 255, 224));
                }
            }
        }
    }
}
