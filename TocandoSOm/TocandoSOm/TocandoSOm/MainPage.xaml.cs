using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace TocandoSOm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void tocar_som_clicked(object sender, EventArgs e)
        {
            try
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load(GetStreamFromFile("digital_bell.wav"));
                player.Play();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", ex.Message, "OK");
            }
        }

        private Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream(filename);
            return stream;
        }
    }
}
