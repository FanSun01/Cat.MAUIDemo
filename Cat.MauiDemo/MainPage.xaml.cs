namespace Cat.MauiDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    private void ResultButton_OnClicked(object sender, EventArgs e)
    {
        ResultLabel.Text = "Hello World!";
    }
}

