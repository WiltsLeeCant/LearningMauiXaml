namespace MauiXamlTestApp;

public partial class GraphicsViewMain : ContentPage
{
	public GraphicsViewMain()
	{
		//InitializeComponent();
	}
}

public class GraphicsDrawableMain : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Drawing code goes here
    }
}