
using CommunityToolkit.Mvvm.Input;

namespace FormDemo.ViewModel
{
    [QueryProperty("Value", "Value")]
    public partial class BillingDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        public string value;


    }
}
