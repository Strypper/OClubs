using OClubs.Helpers.Animations;
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
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OClubs.Views.IU___Store.MainLayout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StoreView : Page
    {
        bool carefulPlz = false;
        bool stopDisposing = false;
        PropertySet _colorsByPivotItem;
        ColorBloomTransitionHelper transition, buttonTransition, surroundButtonTransition;
        Queue<PivotItem> pendingTransitions = new Queue<PivotItem>();
        Queue<Rectangle> pendingPageTransitions = new Queue<Rectangle>();
        public StoreView()
        {
            this.InitializeComponent();


            if (carefulPlz == false)
            {


                this.InitializeColors();
                this.InitializeTransitionHelper();
                this.Unloaded += ColorBloomTransition_Unloaded;
            }
            else
            {
                this.InitializeColors();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            //If something is carried over when coming to this page
            //The following code will run
            //Note: This is so that the code will never run when the program starts since
            //this fix for the bug (when navigating to this page) would make the app crash at launch
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            if (!(e.Parameter == null) && e.Parameter.ToString() != "")
            {

                carefulPlz = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
<<<<<<< HEAD
=======

            //this also helps combat the bug that occurs when navigated to this page
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======

            //this also helps combat the bug that occurs when navigated to this page
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            if (carefulPlz == true)
            {
                this.InitializeTransitionHelper();
                this.Unloaded += ColorBloomTransition_Unloaded;
            }


        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1




        /// Assign a key and a colour to each pivot item. I made the key the same as the name of the 
        /// items themeselves to make it easier for myself.
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
        private void InitializeColors()
        {
            _colorsByPivotItem = new PropertySet();
            _colorsByPivotItem.Add("firstPivot", Windows.UI.Color.FromArgb( 200, 137, 137, 137));
            _colorsByPivotItem.Add("secondPivot", Windows.UI.Color.FromArgb( 200, 46, 49, 145));
            _colorsByPivotItem.Add("thirdPivot", Windows.UI.Color.FromArgb( 150, 255, 185, 0));

        }



        /// All of the Color Bloom transition functionality is encapsulated in this handy helper
        /// which we will init once

        private void InitializeTransitionHelper()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            transition = new ColorBloomTransitionHelper(hostForVisual);

            surroundButtonTransition = new ColorBloomTransitionHelper(anotherHost);

=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            // we pass in the UIElement that will host our Visuals
            transition = new ColorBloomTransitionHelper(hostForVisual);
            //buttonTransition = new ColorBloomTransitionHelper(hostForButtonVisual);
            surroundButtonTransition = new ColorBloomTransitionHelper(anotherHost);

            // when the transition completes, we need to know so we can update other property values
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            transition.ColorBloomTransitionCompleted += ColorBloomTransitionCompleted;
            surroundButtonTransition.ColorBloomTransitionCompleted += SurroundButtonTransition_ColorBloomTransitionCompleted;
        }












        /// Updates the background of the layout panel to the same color whose transition animation just completed.

        private void ColorBloomTransitionCompleted(object sender, EventArgs e)
        {


            var item = pendingTransitions.Dequeue();

<<<<<<< HEAD
<<<<<<< HEAD
            var header = (StackPanel)item.Header;
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            // now remember, that bloom animation was just transitional

            // so we need to explicitly set the correct color as background of the layout panel

            var header = (AppBarButton)item.Header;
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1

            UICanvas.Background = new SolidColorBrush((Windows.UI.Color)_colorsByPivotItem[header.Name]);

        }


<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1

        /// In response to a XAML layout event on the Grid (named UICanvas) we will keep the animation
        /// inside UICanvas.


<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
        private void UICanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var uiCanvasLocation = UICanvas.TransformToVisual(UICanvas).TransformPoint(new Windows.Foundation.Point(0d, 0d));
            var clip = new RectangleGeometry()
            {
                Rect = new Windows.Foundation.Rect(uiCanvasLocation, e.NewSize)
            };
            UICanvas.Clip = clip;
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            //Line underneath reinitialises the transition helpers 
            //because the area that the animation will occur
            //and the area that the animation will be drawn (e.g host for visual)
            //has changed.
            //This way, no matter what the size of the window is
            //The animation fills the Grid
            //at the same speed even after you resize the window
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            InitializeTransitionHelper();
        }


        /// Cleans up remaining surfaces when the page is unloaded.
        private void ColorBloomTransition_Unloaded(object sender, RoutedEventArgs e)
        {
            if (stopDisposing == false)
            {
                transition.Dispose();
<<<<<<< HEAD
<<<<<<< HEAD
=======
                buttonTransition.Dispose();
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
                buttonTransition.Dispose();
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
                surroundButtonTransition.Dispose();
                stopDisposing = true;
            }

        }




        private void treePivot_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            var beforeheader = sender as Pivot;
            var rightBeforeHeader = beforeheader.SelectedItem as PivotItem;
<<<<<<< HEAD
<<<<<<< HEAD
            var header = rightBeforeHeader.Header as StackPanel;
=======
            var header = rightBeforeHeader.Header as AppBarButton;
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
            var header = rightBeforeHeader.Header as AppBarButton;
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            var headerPosition = header.TransformToVisual(UICanvas).TransformPoint(new Windows.Foundation.Point(0d, 0d));


            var initialBounds = new Windows.Foundation.Rect()
            {
                Width = header.RenderSize.Width,
                Height = header.RenderSize.Height,
                X = headerPosition.X,
                Y = headerPosition.Y
            };

            var finalBounds = Window.Current.Bounds;  // maps to the bounds of the current window

            //The code is super easy to understand if you set a break point here and 
            //check to see what happens step by step ;)
            transition.Start((Windows.UI.Color)_colorsByPivotItem[header.Name],  // the color for the circlular bloom
                                 initialBounds,                                  // the initial size and position
                                       finalBounds);                             // the area to fill over the animation duration

            // Add item to queue of transitions
<<<<<<< HEAD
<<<<<<< HEAD
            var pivotItem = (PivotItem)mainPivot.Items.Single(i => ((StackPanel)((PivotItem)i).Header).Name.Equals(header.Name));
=======
            var pivotItem = (PivotItem)mainPivot.Items.Single(i => ((AppBarButton)((PivotItem)i).Header).Name.Equals(header.Name));
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
            var pivotItem = (PivotItem)mainPivot.Items.Single(i => ((AppBarButton)((PivotItem)i).Header).Name.Equals(header.Name));
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
            pendingTransitions.Enqueue(pivotItem);

            //This code deals with a bug that occurs when you go navigate to a new page then come back to this one.
            if (carefulPlz == true)
            {
                var item = pendingTransitions.Dequeue();
                var headerFinish = item;
                UICanvas.Background = new SolidColorBrush((Windows.UI.Color)_colorsByPivotItem[headerFinish.Name]);
                carefulPlz = false;
            }
            // Make the content visible immediately, when first clicked. Subsequent clicks will be handled by Pivot Control
            var content = (FrameworkElement)pivotItem.Content;
            if (content.Visibility == Visibility.Collapsed)
            {
                content.Visibility = Visibility.Visible;
            }



        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void SurroundButtonTransition_ColorBloomTransitionCompleted(object sender, EventArgs e)
        {
            UICanvas.Background = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
        }
=======
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
        //private void limitOfAnimation_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    //This method is extremly vital. This creates the clipping which stops the 
        //    //animation from occuring outside of the button.
        //    var colourBloomCanvasLocation = limitOfAnimation.TransformToVisual(limitOfAnimation).TransformPoint(new Windows.Foundation.Point(0d, 0d));

        //    var clip = new RectangleGeometry()

        //    {

        //        Rect = new Windows.Foundation.Rect(colourBloomCanvasLocation, e.NewSize)

        //    };

        //    limitOfAnimation.Clip = clip;
        //    //Note: This line isn't really needed as the button never resizes 
        //    //in this app but it may come in handy later...

        //    //Line underneath reinitialises the transition helpers 
        //    //because the area that the animation will occur
        //    //and the area that the animation will be drawn (e.g host for visual)
        //    //has changed.
        //    //This way, no matter what the size of the window is
        //    //The animation fills the Grid
        //    //at the same speed even after you resize the window
        //    InitializeTransitionHelper();
        //}

        private void SurroundButtonTransition_ColorBloomTransitionCompleted(object sender, EventArgs e)
        {
            //Changes colour of background to "White Smoke " when 
            //the animations have finished.
            UICanvas.Background = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
        }

        private void toNextPage_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(bloomPage));
        }

        private void header_Click(object sender, RoutedEventArgs e)
        {
            var header = sender as AppBarButton;

            var headerPosition = header.TransformToVisual(UICanvas).TransformPoint(new Windows.Foundation.Point(0d, 0d));


            //Uses values of the rectangle size as the size of the "header" (Initially
            //I wanted it to use the pivot's size but I couldn't get it to work. 
            //Would be awesome if someonebody found a way to make it work...
            //UPDATE: I Made it Work!
            var initialBounds = new Windows.Foundation.Rect()
            {
                Width = header.RenderSize.Width,
                Height = header.RenderSize.Height,
                X = headerPosition.X,
                Y = headerPosition.Y
            };

            var finalBounds = Window.Current.Bounds;  // maps to the bounds of the current window

            //The code is super easy to understand if you set a break point here and 
            //check to see what happens step by step ;)
            transition.Start((Windows.UI.Color)_colorsByPivotItem[header.Name],  // the color for the circlular bloom
                                 initialBounds,                                  // the initial size and position
                                       finalBounds);                             // the area to fill over the animation duration

            // Add item to queue of transitions
            var pivotItem = (PivotItem)mainPivot.Items.Single(i => ((AppBarButton)((PivotItem)i).Header).Name.Equals(header.Name));
            pendingTransitions.Enqueue(pivotItem);

            //This code deals with a bug that occurs when you go navigate to a new page then come back to this one.
            if (carefulPlz == true)
            {
                var item = pendingTransitions.Dequeue();
                var headerFinish = item;
                UICanvas.Background = new SolidColorBrush((Windows.UI.Color)_colorsByPivotItem[headerFinish.Name]);
                carefulPlz = false;
            }
            // Make the content visible immediately, when first clicked. Subsequent clicks will be handled by Pivot Control
            var content = (FrameworkElement)pivotItem.Content;
            if (content.Visibility == Visibility.Collapsed)
            {
                content.Visibility = Visibility.Visible;
            }
        }
<<<<<<< HEAD
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
=======
>>>>>>> 4f9fb8e39a120cbc8b52dc551eb0edeb0ca4a9d1
    }
}
