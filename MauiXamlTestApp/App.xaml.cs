using MauiXamlTestApp.ViewModels;
using MauiXamlTestApp.Views;

namespace MauiXamlTestApp
{
    public partial class App : Application
    {
        public App(ClothViewModel clothViewModel)
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new NavigationPageMain();           // Page for navigation areas.
            //MainPage = new NavigationPage(new TestPage()); // Page for navigation areas programtically, changed by adding/removing from stack.
            //MainPage = new FlyoutPageMain();               // Flyout pages from the left.
            //MainPage = new TabbedPageMain();               // Tabs areas.

            //MainPage = new AbsoluteLayoutMain();           // Sets elements based on parent.
            //MainPage = new FlexLayoutMain();               // Can dynamically just elements.
            //MainPage = new GridLayoutMain();               // Like Bootstrap, can set based on Rows/ Cols.
            //MainPage = new StackLayoutMain();              // The regular layout.
            //MainPage = new H_V_StackLayout();              // Horizontal/Vertical layouts based on horizontal or vertical direction.

            //MainPage = new ActivityIndicator();            // Loading Icon.
            //MainPage = new Border();                       // Borders live around items.
            //MainPage = new BoxView();                      // A general Box. 
            //MainPage = new ButtonView();                   // A button.
            //MainPage = new CarouselView();                 // A list of items we can alternate through.
            //MainPage = new CheckboxView();                 // A Checkbox
            //MainPage = new CollectionView();               // Learning page shows this.
            //MainPage = new Datepicker();                   // Datepicker when choosing a date.
            //MainPage = new EditorView();                   // Multiple text lines.
            //MainPage = new EllipseView();                  // Straight forward ellipse.
            //MainPage = new EntryView();                    // Is just a textbox type thing
            //MainPage = new GraphicsView();                 // Can draw Graphics, currently doesn't work though.
            //MainPage = new ImageButtonView();              // Buttons just for images.
            //MainPage = new IndicatorViewMain();            // Counts the number of icons
            //MainPage = new LineView();                     // A general line.
            //MainPage = new ListViewMain();                 // Shows a basic list.
            //MainPage = new MapView();                      // Third party library needs more work.
            //MainPage = new PathView();                     // Can create a path like with triangles.
            //MainPage = new PickerView();                   // A picker to select items.
            //MainPage = new PolygonView();                  // Creates a Polygon
            //MainPage = new PolylineView();                 // A Polyline, good for graphs and whatnot.
            //MainPage = new ProgressBarView();              // A view for progress bars 
            //MainPage = new RadioButtonView();              // Radio buttons like with HTML.
            //MainPage = new RectangleView();                  // A basic rectangle control.
            MainPage = new RefreshViewMain(clothViewModel);            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
            //MainPage = new ActivityIndicator();            // 
        }
    }
}