using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using ConstConfig;

namespace assignment4
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            var navigationPage = new Xamarin.Forms.NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex(Const.SecondaryColor),
                BarTextColor = Color.FromHex(Const.TextColor)
            };

            navigationPage.On<iOS>().SetPrefersLargeTitles(true);

            MainPage = navigationPage;
        }
    }
}