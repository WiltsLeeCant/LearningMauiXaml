namespace MauiXamlTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new NavigationPageMain();                   // Page for navigation areas.
            //MainPage = new NavigationPageMain(new TestPageMain()); // Page for navigation areas programtically, changed by adding/removing from stack.
            //MainPage = new FlyoutPageMain();                      // Flyout pages from the left.
            //MainPage = new TabbedPageMain();                      // Tabs areas.

            //MainPage = new AbsoluteLayoutMain();               // Sets elements based on parent.
            //MainPage = new FlexLayoutMain();                   // Can dynamically just elements.
            //MainPage = new GridLayoutMain();                   // Like Bootstrap, can set based on Rows/ Cols.
            //MainPage = new StackLayoutMain();                  // The regular layout.
            //MainPage = new H_V_StackLayoutMain();              // Horizontal/Vertical layouts based on horizontal or vertical direction.

            //MainPage = new ActivityIndicatorMain();            // Loading Icon.
            //MainPage = new BorderMain();                       // Borders live around items.
            //MainPage = new BoxViewMain();                      // A general Box. 
            //MainPage = new ButtonViewMain();                   // A button.
            //MainPage = new CarouselViewMain();                 // A list of items we can alternate through.
            //MainPage = new CheckboxViewMain();                 // A Checkbox
            //MainPage = new CollectionViewMain();               // Learning page shows this.
            //MainPage = new DatepickerMain();                   // Datepicker when choosing a date.
            //MainPage = new EditorViewMain();                   // Multiple text lines.
            //MainPage = new EllipseViewMain();                  // Straight forward ellipse.
            //MainPage = new EntryViewMain();                    // Is just a textbox type thing
            //MainPage = new GraphicsViewMain();                 // Can draw Graphics, currently doesn't work though.
            //MainPage = new ImageButtonViewMain();              // Buttons just for images.
            //MainPage = new IndicatorViewMain();                // Counts the number of icons
            //MainPage = new LineViewMain();                     // A general line.
            //MainPage = new ListViewMain();                     // Shows a basic list.
            //MainPage = new MapViewMain();                      // Third party library needs more work.
            //MainPage = new PathViewMain();                     // Can create a path like with triangles.
            //MainPage = new PickerViewMain();                   // A picker to select items.
            //MainPage = new PolygonViewMain();                  // Creates a Polygon
            //MainPage = new PolylineViewMain();                 // A Polyline, good for graphs and whatnot.
            //MainPage = new ProgressBarViewMain();              // A view for progress bars 
            //MainPage = new RadioButtonViewMain();              // Radio buttons like with HTML.
            //MainPage = new RectangleViewMain();                // A basic rectangle control.
            //MainPage = new RefreshViewMain();                  // See the learning page under - when a user refreshes the page it can Update.
            MainPage = new RectangleViewMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
            //MainPage = new ActivityIndicatorMain();            // 
        }
    }
}