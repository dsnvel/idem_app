using ZXing.Net.Maui;

namespace IDEM;

public partial class ScanerPage : ContentPage
{
	public ScanerPage()
	{
		InitializeComponent();
		qrReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
		{
			Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
            AutoRotate = true,
            Multiple = true
        };
	}

    private void qrReader_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
	{
		qrReader.IsDetecting = false;
		if (e.Results.Any())
		{
			var result = e.Results.FirstOrDefault();

			Dispatcher.Dispatch(async () =>
			{
				// await DisplayAlert("QR-code result", $"Result: {result.Value}", "Ok");
				var navigationParam = new Dictionary<string, object>()
				{
					{"qrCodeResult", result.Value }
				};

                if (result.Value == "http://idem-shop.ru/gallery/1b3120fd-2c58-429e-92e8-0855f69c917c")
				{
                    // await DisplayAlert("QR-code result", $"Result: {QrCodeResult}", "Ok");
                    await Shell.Current.GoToAsync("..");
                    await Shell.Current.GoToAsync(nameof(de_sterrennacht));
                }
                // await Shell.Current.GoToAsync(nameof(de_sterrennacht), navigationParam);
			});
		}
	}
}
