using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using System.Numerics;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OClubs.Components.Buttons
{
    public sealed partial class OClubsAction : UserControl
    {
        public OClubsAction()
        {
            this.InitializeComponent();
        }


        public string IconLogo
        {
            get { return (string)GetValue(IconLogoProperty); }
            set { SetValue(IconLogoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconLogo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconLogoProperty =
            DependencyProperty.Register("IconLogo", typeof(string), typeof(OClubsAction), null);



        public string AName
        {
            get { return (string)GetValue(ANameProperty); }
            set { SetValue(ANameProperty, value); }
        }



        public string AColor
        {
            get { return (string)GetValue(AColorProperty); }
            set { SetValue(AColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AColorProperty =
            DependencyProperty.Register("AColor", typeof(string), typeof(OClubsAction), null);




        // Using a DependencyProperty as the backing store for AName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ANameProperty =
            DependencyProperty.Register("AName", typeof(string), typeof(OClubsAction), null);




        public string AFontFamily
        {
            get { return (string)GetValue(AFontFamilyProperty); }
            set { SetValue(AFontFamilyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AFontFamily.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AFontFamilyProperty =
            DependencyProperty.Register("AFontFamily", typeof(string), typeof(OClubsAction), null);





        private void ActionButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Icon.Translation = new Vector3(0, -20, 0);
        }

        private void ActionButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Icon.Translation = new Vector3(0, 0, 0);
        }
    }
}
