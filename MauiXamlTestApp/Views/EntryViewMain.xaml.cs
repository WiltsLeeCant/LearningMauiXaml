namespace MauiXamlTestApp;

public partial class EntryViewMain : ContentPage
{
	public EntryViewMain()
	{
		InitializeComponent();
	}

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
}