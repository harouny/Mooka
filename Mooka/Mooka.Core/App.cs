using Mooka.Core.Business.Services;
using Mooka.Core.Views.Pages;
using Xamarin.Forms;

namespace Mooka.Core
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            DependencyService.Register<UserProfilesService>();
            MainPage = new NavigationPage(new Profiles());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
