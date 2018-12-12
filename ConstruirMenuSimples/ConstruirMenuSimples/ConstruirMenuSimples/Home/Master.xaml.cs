using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConstruirMenuSimples.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void menu_acessar_cadastro_clicked(object sender, EventArgs e)
        {
            await App.NavigateMasterDetail(new Cadastro.Cadastro());
        }

        private void sair_clicked(object sender, EventArgs e)
        {
            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            //}
            //else if (Device.RuntimePlatform == Device.iOS)
            //{
            //    Thread.CurrentThread.Abort();
            //}
        }
    }
}