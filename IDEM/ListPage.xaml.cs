using ZXing.Net.Maui;
namespace IDEM;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }

    public async void DeSterrennachtOnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(de_sterrennacht));
    }
}