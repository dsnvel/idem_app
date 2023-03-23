namespace IDEM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ScanerPage), typeof(ScanerPage));
        Routing.RegisterRoute(nameof(de_sterrennacht), typeof(de_sterrennacht));
    }
}
