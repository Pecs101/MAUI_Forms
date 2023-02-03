namespace FormDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BillingDetailPage), typeof(BillingDetailPage));
	}
}
