using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace ExemploModalPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView
    {
        public PopupView(string usuario, string senha)
        {
            InitializeComponent();

            // Plugin: Rg.Plugins.Popup
            // https://www.youtube.com/watch?v=dOU0Qei3Qlk
            // https://github.com/HoussemDellai
            // https://github.com/HoussemDellai/Xamarin-Forms-Popup-Demo

            editUsuario.Text = usuario;
            editSenha.Text = senha;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}