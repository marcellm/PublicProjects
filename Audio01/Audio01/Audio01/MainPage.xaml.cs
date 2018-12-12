using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Audio01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void tocarSom(object sender, EventArgs args)
        {
            try
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("guns.mp3");

                player.Play();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", ex.Message, "OK");
            }
        }
    }
}
