namespace KosovMAUI3;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    
    private void Click_Clinker(object sender, TextChangedEventArgs e)
    {
        if (entLogin.Text == "User")
        {
            if (entPassword.Text == "321")
            {
                AppShell.Current.CurrentItem = new MainPage();
            }
        }
    }
}