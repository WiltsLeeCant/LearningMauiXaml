using Microsoft.Maui.Maps;

namespace MauiXamlTestApp.Views;

public partial class MapView : ContentPage
{
	public MapView()
	{
		InitializeComponent();

        Location location = new(36.9628066, -122.0194722);
        MapSpan mapSpan = new(location, 0.01, 0.01);

		//map.MoveToRegion(mapSpan);
	}
}