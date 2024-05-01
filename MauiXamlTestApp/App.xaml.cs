using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp
{
    public partial class App : Application
    {
        public App(TimePickerViewModel timePickerViewModel)
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new NavigationPageMain();                      // Page for navigation areas.
            //MainPage = new NavigationPageMain(new TestPageMain());    // Page for navigation areas programtically, changed by adding/removing from stack.
            //MainPage = new FlyoutPageMain();                          // Used for popout pages on the left.
            //MainPage = new TabbedPageMain();                          // This is used for tabs at the top.

            //MainPage = new AbsoluteLayoutMain();                      // Helps position and size children based on parents. Layout bounds increases based on the ones above.
            //MainPage = new FlexLayoutMain();                          // Children can be stacked when not possible. Also loads of power with how to position items.
            //MainPage = new GridLayoutMain();                          // Grids can have rows and columns to position.
            //MainPage = new StackLayoutMain();                         // Stacks Items vertically on top of each other. Can't scroll though, needs a scroll view.
            //MainPage = new H_V_StackLayoutMain();                     // More performant than usual will stack either vertical or horizontal.

            //MainPage = new ActivityIndicatorMain();                   // Activity Indicator shows a loading icon.
            //MainPage = new BorderMain();                              // Borders live around items.
            //MainPage = new BoxViewMain();                             // A box with rounded edges and shapes, etc. 
            //MainPage = new ButtonViewMain();                          // A button view.
            //MainPage = new CarouselViewMain();                        // A list of items we can alternate through.
            //MainPage = new CheckboxViewMain();                        // A general checkbox.
            //MainPage = new CollectionViewMain();                      // See the learning page for this.
            //MainPage = new DatepickerMain();                          // Datepicker to set the date.
            //MainPage = new EditorViewMain();                          // Used for multiple lines of text.
            //MainPage = new EllipseViewMain();                         // Straight forward ellipse.
            //MainPage = new EntryViewMain();                           // Entry for entering text.
            //MainPage = new GraphicsViewMain();                        // Needs more work but can draw graphics.
            //MainPage = new ImageButtonViewMain();                     // Buttons just for images.
            //MainPage = new IndicatorViewMain();                       // Counts the number of items for the indicators.
            //MainPage = new LineViewMain();                            // A general line.
            //MainPage = new ListViewMain();                            // Shows a basic list.
            //MainPage = new MapViewMain();                             // Third party library needs more work.
            //MainPage = new PathViewMain();                            // Can create a path like with triangles.
            //MainPage = new PickerViewMain();                          // General picker control.
            //MainPage = new PolygonViewMain();                         // Polygons for drawing shapes, etc.
            //MainPage = new PolylineViewMain();                        // Polylines, useful for graphs, etc.
            //MainPage = new ProgressBarViewMain();                     // A view for progress bars. 
            //MainPage = new RadioButtonViewMain();                     // Radio buttons like with HTML.
            //MainPage = new RectangleViewMain();                       // A basic rectangle control.
            //MainPage = new RefreshViewMain();                         // See inside the Learning page, it basically refreshes the page with updated data.
            //MainPage = new RoundRectangleViewMain();                  // Like regular rectangle but round.
            //MainPage = new SliderViewMain();                          // A basic slider control.
            //MainPage = new StepperViewMain();                         // A basic stepper control.
            //MainPage = new SwitchViewMain();                          // A switch control which is like a toggle.
            //MainPage = new TableViewMain();                           // A view for tables.
            //MainPage = new TimePickerViewMain(timePickerViewModel);   // Timer pickers which helps us select time.
            //MainPage = new TwoPaneViewMain();                         // Can't seem to get working, should have foldable content - see: https://learn.microsoft.com/en-gb/dotnet/maui/user-interface/controls/twopaneview?view=net-maui-8.0
            //MainPage = new WebViewMain();                               // A way to display websites if we want to.
        }
    }
}