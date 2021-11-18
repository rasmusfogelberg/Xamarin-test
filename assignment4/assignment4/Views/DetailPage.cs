using Xamarin.Forms;
using ConstConfig;

namespace assignment4
{
    public class DetailPage : ContentPage
    {
        public DetailPage(DetailPageViewModel viewModel)
        {
            BindingContext = viewModel;

            Title = "Note Details";

            BackgroundColor = Color.FromHex(Const.PrimaryColor);

            var textLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.FromHex(Const.TextColor),
                FontSize = 16
            };
            textLabel.SetBinding(Label.TextProperty, nameof(DetailPageViewModel.NoteText));

            var exitButton = new Button
            {
                Text = "Go Back",
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(20),
                BackgroundColor = Color.FromHex(Const.ButtonColor),
                FontSize = 20
            };
            exitButton.SetBinding(Button.CommandProperty, nameof(DetailPageViewModel.ExitCommand));

            var stackLayout = new StackLayout
            {
                Margin = new Thickness(20, 40)
            };
            stackLayout.Children.Add(textLabel);
            stackLayout.Children.Add(exitButton);

            Content = stackLayout;
        }
    }
}
