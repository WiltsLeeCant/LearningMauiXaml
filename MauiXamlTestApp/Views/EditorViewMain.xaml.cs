namespace MauiXamlTestApp;

public partial class EditorViewMain : ContentPage
{
	public EditorViewMain()
	{
		InitializeComponent();
    }

    void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = editor.Text;
    }

    void OnEditorCompleted(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;
    }
}