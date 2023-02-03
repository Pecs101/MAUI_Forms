
namespace FormDemo;

public partial class MainPage : ContentPage
{ 
	public MainPage(MainViewModel viewmodel)
	{
		InitializeComponent(); 
		BindingContext= viewmodel;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var _value = valueimput.Text;
        await Shell.Current.GoToAsync($"{nameof(BillingDetailPage)}?Value={_value}", true);
    }
}

