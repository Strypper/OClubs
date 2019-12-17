using OClubs.Models.Club;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OClubs.Views.Clubs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OnlineClubs : Page
    {
        public OnlineClubs()
        {
            this.InitializeComponent();
            //this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        private void OClubs_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var club = (TestData)e.ClickedItem;
            Frame.Navigate(typeof(ClubDetail));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OClubs.ItemsSource = App.Clubs;
            Head.Translation = new System.Numerics.Vector3(0, 0, 0);
            OClubs.Translation = new System.Numerics.Vector3(0, 0, 0);
        }
    }
}
