using OClubs.Views;
using OClubs.Views.IU.About_Tab;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OClubs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.UI.Composition.Compositor _composition = null;
        public MainPage()
        {
            this.InitializeComponent();
        }
        public void ExecuteAnimation()
        {
            CreateImplicitAnimation();
            Head.Visibility = Visibility.Visible;
            Down.Opacity = 1;
            LoginForm.Translation = new Vector3(0, -300, 0);
            Intro.Translation = new Vector3(0, 100, 0);
            Logo.Scale = new Vector3(1, 1, 0);
        }

        private void SignUp_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            SignUp.Scale = new Vector3(1.2f, 1.2f, 1);
        }

        private void SignUp_PointerExited(object sender, PointerRoutedEventArgs e)
        {
           SignUp.Scale = new Vector3(1, 1, 1);
        }

        private void LogIn_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            LogIn.Scale = new Vector3(1.2f, 1.2f, 1);
        }

        private void LogIn_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            LogIn.Scale = new Vector3(1, 1, 1);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ExecuteAnimation();
        }









        void FetchCompositor()
        {
            if (_composition == null)
                _composition = ElementCompositionPreview.GetElementVisual(this).Compositor;
        }


        void CreateImplicitAnimation()
        {
            FetchCompositor();
            Head.Visibility = Visibility.Collapsed;

            var ScaleHeaderAnimation = _composition.CreateScalarKeyFrameAnimation();

            ScaleHeaderAnimation.InsertKeyFrame(0, 0);
            ScaleHeaderAnimation.InsertKeyFrame(1, 1f);
            ScaleHeaderAnimation.Duration = TimeSpan.FromSeconds(0.5f);
            ScaleHeaderAnimation.Target = "Scale.Y";
            ElementCompositionPreview.SetImplicitShowAnimation(Head, ScaleHeaderAnimation);

            var FadeHeaderAnimation = _composition.CreateScalarKeyFrameAnimation();

            FadeHeaderAnimation.InsertKeyFrame(0, 0);
            FadeHeaderAnimation.InsertKeyFrame(1, 1f);
            FadeHeaderAnimation.Duration = TimeSpan.FromSeconds(1.5f);
            FadeHeaderAnimation.Target = "Opacity";
            ElementCompositionPreview.SetImplicitShowAnimation(Down, FadeHeaderAnimation);
        }

        private async void GuessEnter_Click(object sender, RoutedEventArgs e)
        {
            LoginForm.Translation = new Vector3(0, 0, 0);
            Intro.Translation = new Vector3(0, 0, 0);
            Logo.Scale = new Vector3(0, 0, 0);
            await Task.Delay(500);
            Frame.Navigate(typeof(MainFrame));
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
