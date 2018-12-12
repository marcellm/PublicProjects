using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoMenu01.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void GoPaginaClientes(object sender, EventArgs args)
        {
            //Detail = new NavigationPage(new Cliente.Cliente());
            Navigation.PushAsync(new Cliente.Cliente());
            IsPresented = false;
        }
    }
}