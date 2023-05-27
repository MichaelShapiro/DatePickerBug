namespace DatePickerBug;

public partial class MainPage : ContentPage
{
    int k = 0;
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        bigBug.MinimumDate = new DateTime(2023, 2, 13);
        bigBug.MaximumDate = new DateTime(2023, 2, 18);

        bigBug.Date = new DateTime(2023, 2, 15);
    }
}

