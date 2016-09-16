namespace XamarinApp
{
    using Classes;
    using Views;
    using Views.Master;
    using Xamarin.Forms;
    public class App : Application
    {
        public App()
        {
            MainPage = new Master(new MasterNavigation(new MenuItems()) { Title = "Welcome" }, new Home());
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
