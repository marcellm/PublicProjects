using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExemploModalPopup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // Plugin: Rg.Plugins.Popup
            // https://www.youtube.com/watch?v=dOU0Qei3Qlk
            // https://github.com/HoussemDellai
            // https://github.com/HoussemDellai/Xamarin-Forms-Popup-Demo
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
