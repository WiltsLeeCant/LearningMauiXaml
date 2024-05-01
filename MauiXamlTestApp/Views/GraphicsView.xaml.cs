namespace MauiXamlTestApp;

public partial class GraphicsView : ContentPage
{
	public GraphicsView()
	{
		//InitializeComponent();
	}
}

public class GraphicsDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Drawing code goes here
    }
}