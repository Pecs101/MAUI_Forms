
namespace FormDemo;

public partial class MainPage : ContentPage
{ 
	public MainPage(MainViewModel viewmodel)
	{
		InitializeComponent(); 
		BindingContext= viewmodel;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        bool answer = DisplayAlert("Question?", "Would you like to play a game", "Yes", "No").GetAwaiter().GetResult();
    }
}

