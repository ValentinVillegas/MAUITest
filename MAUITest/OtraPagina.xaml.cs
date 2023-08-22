namespace MAUITest;

public partial class OtraPagina : ContentPage
{
	public OtraPagina()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}