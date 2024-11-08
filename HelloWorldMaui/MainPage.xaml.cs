using ClassLibraryToHandle;

namespace HelloWorldMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void ButtonClicked(object sender, EventArgs e)
        {
            HelloWorldManager helloWorldManager = new HelloWorldManager();

            if (!string.IsNullOrEmpty(lblName.Text))
            {
                var message = $"Hello, {lblName.Text}";

                await DisplayAlert("Message", message, "OK");

                var handledMessage = helloWorldManager.GetHelloMessage(lblName.Text);
                await DisplayAlert("Message", $"{handledMessage}", "OK");

            }
            else
            {
                await DisplayAlert("Message", "Please write your name to the text box", "OK");
            }
        }
    }

}
