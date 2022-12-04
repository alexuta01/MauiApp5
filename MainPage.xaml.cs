namespace MauiApp5;

public partial class MainPage : ContentPage
{
	string text;

	public MainPage()
	{
		InitializeComponent();
	}
	void EntryNumber(object sender, EventArgs e)
	{
		text = ((Entry)sender).Text;
	}
	void EntryChanged(object sender ,TextChangedEventArgs e)
	{
			text = e.NewTextValue;

	}
	private void OnCounterClicked(object sender, EventArgs e)
	{
		float val = float.Parse(text);
		float Euro = 4.94F;
		val= val * Euro;
		ConverterPlace.Text = $" {val.ToString("0.00")}lei";

		SemanticScreenReader.Announce(ConverterPlace.Text);

	}


}

	

 
