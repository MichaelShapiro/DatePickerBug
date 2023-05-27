namespace DatePickerBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    private void Button_Clicked(object sender, EventArgs e)
    {
        bigBug.MinimumDate = DateTime.MinValue;
        bigBug.MaximumDate = DateTime.MaxValue;

        bigBug.MinimumDate = new DateTime(2023, 4, 20);
        bigBug.MaximumDate = new DateTime(2023, 4, 29);
        bigBug.Date = new DateTime(2023, 5, 30);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        bigBug.MinimumDate = DateTime.MinValue;
        bigBug.MaximumDate = DateTime.MaxValue;

        bigBug.MinimumDate = new DateTime(2023, 2, 13);
        bigBug.MaximumDate = new DateTime(2023, 2, 18);
        bigBug.Date = new DateTime(2023, 2, 15);
    }


}

