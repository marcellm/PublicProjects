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
    public partial class PopupViewBottom
    {
        public PopupViewBottom(string usuario, string senha)
        {
            InitializeComponent();

            editUsuario.Text = usuario;
            editSenha.Text = senha;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}