namespace FormDemo;

public partial class BillingDetailPage : ContentPage
{
	public BillingDetailPage(BillingDetailsViewModel billingDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = billingDetailsViewModel;
	}

    private async void Goback(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}