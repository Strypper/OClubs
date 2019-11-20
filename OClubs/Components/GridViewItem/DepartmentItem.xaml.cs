using OClubs.Models.LocalData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas.Effects;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using Windows.UI;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OClubs.Components.GridViewItem
{
    public sealed partial class DepartmentItem : UserControl
    {

        public string DepartmentImageSource
        {
            get { return (string)GetValue(DepartmentImageSourceProperty); }
            set { SetValue(DepartmentImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DepartmentImageSourceProperty =
            DependencyProperty.Register("DepartmentImageSource", typeof(string), typeof(DepartmentItem), null);




        public string DepartmentTitle
        {
            get { return (string)GetValue(DepartmentTitleProperty); }
            set { SetValue(DepartmentTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DepartmentTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DepartmentTitleProperty =
            DependencyProperty.Register("DepartmentTitle", typeof(string), typeof(DepartmentItem), null);

        public string DepartmentLogo
        {
            get { return (string)GetValue(DepartmentLogoProperty); }
            set { SetValue(DepartmentLogoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DepartmentTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DepartmentLogoProperty =
            DependencyProperty.Register("DepartmentLogo", typeof(string), typeof(DepartmentItem), null);




        public string DepartmentDescription
        {
            get { return (string)GetValue(DepartmentDescriptionProperty); }
            set { SetValue(DepartmentDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DepartmentDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DepartmentDescriptionProperty =
            DependencyProperty.Register("DepartmentDescription", typeof(string), typeof(DepartmentItem), null);


        public DepartmentItem()
        {
            this.InitializeComponent();
            InitializeFrostedGlass(Glass);
        }











        private void Border_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Title.Scale = new System.Numerics.Vector3(0.3f, 0.3f, 0);
            BelowGrid.Translation = new System.Numerics.Vector3(0, 0, 0);

            //Blur Animation (Very Buggy)
            //await CoverImage.Blur(value: 10, duration: 1500, delay: 0).StartAsync();
        }

        private void Border_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Title.Scale = new System.Numerics.Vector3(1, 1, 0);
            BelowGrid.Translation = new System.Numerics.Vector3(0, 400, 0);

            //Blur Animation (Very Buggy)
            //await CoverImage.Blur(value: 0, duration: 700, delay: 0).StartAsync();
        }


        private void InitializeFrostedGlass(UIElement glassHost)
        {
            Visual hostVisual = ElementCompositionPreview.GetElementVisual(glassHost);
            Compositor compositor = hostVisual.Compositor;

            // Create a glass effect, requires Win2D NuGet package
            var glassEffect = new GaussianBlurEffect
            {
                BlurAmount = 15.0f,
                BorderMode = EffectBorderMode.Hard,
                Source = new ArithmeticCompositeEffect
                {
                    MultiplyAmount = 0,
                    Source1Amount = 0.5f,
                    Source2Amount = 0.5f,
                    Source1 = new CompositionEffectSourceParameter("backdropBrush"),
                    Source2 = new ColorSourceEffect
                    {
                        Color = Color.FromArgb(255, 245, 245, 245)
                    }
                }
            };

            //  Create an instance of the effect and set its source to a CompositionBackdropBrush
            var effectFactory = compositor.CreateEffectFactory(glassEffect);
            var backdropBrush = compositor.CreateBackdropBrush();
            var effectBrush = effectFactory.CreateBrush();

            effectBrush.SetSourceParameter("backdropBrush", backdropBrush);

            // Create a Visual to contain the frosted glass effect
            var glassVisual = compositor.CreateSpriteVisual();
            glassVisual.Brush = effectBrush;

            // Add the blur as a child of the host in the visual tree
            ElementCompositionPreview.SetElementChildVisual(glassHost, glassVisual);

            // Make sure size of glass host and glass visual always stay in sync
            var bindSizeAnimation = compositor.CreateExpressionAnimation("hostVisual.Size");
            bindSizeAnimation.SetReferenceParameter("hostVisual", hostVisual);

            glassVisual.StartAnimation("Size", bindSizeAnimation);
        }
    }
}
