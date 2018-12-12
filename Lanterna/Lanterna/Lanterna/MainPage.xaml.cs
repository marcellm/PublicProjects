using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
//using Android;
//using Android.Media;

namespace Lanterna
{
    public partial class MainPage : ContentPage
    {
        private bool ligado = false;

        //MediaPlayer player;

        public MainPage()
        {
            InitializeComponent();

            inicializar();
        }

        private void inicializar()
        {
            try
            {
                imgLanterna.Source = "lanternaOff.png";
                ligado = false;

                // INI - TAP EVENT: imgLanterna
                var tgLanterna = new TapGestureRecognizer();
                tgLanterna.Tapped += async (s, e) =>
                {
                    //xPlayAudioFile("switchtone");
                    ligado = !ligado;
                    if (ligado)
                    {                        
                        imgLanterna.Source = "lanternaOn.png";
                        await Flashlight.TurnOnAsync();
                    }
                    else
                    {                        
                        imgLanterna.Source = "lanternaOff.png";
                        await Flashlight.TurnOffAsync();
                    }
                };
                imgLanterna.GestureRecognizers.Add(tgLanterna);
                // FIM - TAP EVENT: imgLanterna
            }
            catch (Exception ex)
            {

            }
        }

        //public void PlayAudioFile(string fileName)
        //{
        //    var player = new MediaPlayer();
        //    var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
        //    player.Prepared += (s, e) =>
        //    {
        //        player.Start();
        //    };
        //    player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
        //    player.Prepare();
        //}
    }
}
