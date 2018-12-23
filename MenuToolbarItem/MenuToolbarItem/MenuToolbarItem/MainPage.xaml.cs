using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuToolbarItem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
        }

        private void PesquisarClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alerta", "Pesquisando...", "OK");
        }

        private void BaixarClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alerta", "Baixando...", "OK");
        }

        private void EstornarClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alerta", "Estornando...", "OK");
        }

        private void ExcluirClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alerta", "Excluindo...", "OK");
        }
    }
}
