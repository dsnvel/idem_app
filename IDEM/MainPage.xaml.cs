using System.Runtime.CompilerServices;
using ZXing;

namespace IDEM;

// [QueryProperty(nameof(QrCodeResult), "qrCodeResult")]
public partial class MainPage : ContentPage
{
    
    /*public string QrCodeResult
    {
        set
        {
            LoadIdemPageAsync(value);
        }
    }*/

    public MainPage()
	{
		InitializeComponent();
	}

    private void ScanerPageClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ScanerPage));
	}

    /*async void LoadIdemPageAsync(string QrCodeResult)
    {
        if (QrCodeResult == null)
        {
            ScanerPage.Text = "Not";
        }
        else if (QrCodeResult == "Hello world")
        {
            await DisplayAlert("QR-code result", $"Result: {QrCodeResult}", "Ok");
            await Shell.Current.GoToAsync(nameof(de_sterrennacht));
        }
        else
        {
            //ScanerPage.Text = "Not";
        }
    }*/
}

