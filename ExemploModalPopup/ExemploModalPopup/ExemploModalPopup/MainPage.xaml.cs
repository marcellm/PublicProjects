using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace ExemploModalPopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Exemplo Modal";

            // Plugin: Rg.Plugins.Popup
            // https://www.youtube.com/watch?v=dOU0Qei3Qlk
            // https://github.com/HoussemDellai
            // https://github.com/HoussemDellai/Xamarin-Forms-Popup-Demo
        }

        private void abrir_modal_modelo1_clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupView("marcell", "marcell123"));
        }

        private void abrir_modal_modelo2_clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupViewBottom("marcell", "marcell123"));
        }

        private void abrir_modal_modelo3_clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupViewDownToTop("marcell", "marcell123"));
        }

        private void abrir_modal_modelo4_clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupViewTopToTop("marcell", "marcell123"));
        }

        private void abrir_modal_modelo5_clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupViewLeftToRight("marcell", "marcell123"));
        }
    }
}
