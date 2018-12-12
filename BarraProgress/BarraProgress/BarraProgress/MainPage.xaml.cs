using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BarraProgress
{
    public class Meta
    {
        public string nome { get; set; }
        public float percentual { get; set; }
        public string cor { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        List<Meta> metaLista = new List<Meta>();
        public MainPage()
        {
            InitializeComponent();

            alimentaLista();
        }

        private void alimentaLista()
        {
            Meta meta1 = new Meta();
            meta1.nome = "Poupança";
            meta1.percentual = 0.3f;
            meta1.cor = "#d9534f";
            metaLista.Add(meta1);

            Meta meta2 = new Meta();
            meta2.nome = "Financiamento";
            meta2.percentual = 0.5f;
            meta2.cor = "#5cb85c";
            metaLista.Add(meta2);

            Meta meta3 = new Meta();
            meta3.nome = "Energia";
            meta3.percentual = 0.7f;
            meta3.cor = "#428bca";
            metaLista.Add(meta3);

            Meta meta4 = new Meta();
            meta4.nome = "Poupança";
            meta4.percentual = 0.3f;
            meta4.cor = "#d9534f";
            metaLista.Add(meta4);

            Meta meta5 = new Meta();
            meta5.nome = "Financiamento";
            meta5.percentual = 0.5f;
            meta5.cor = "#5cb85c";
            metaLista.Add(meta5);

            Meta meta6 = new Meta();
            meta6.nome = "Energia";
            meta6.percentual = 0.7f;
            meta6.cor = "#428bca";
            metaLista.Add(meta6);

            Meta meta7 = new Meta();
            meta7.nome = "Poupança";
            meta7.percentual = 0.3f;
            meta7.cor = "#d9534f";
            metaLista.Add(meta7);

            Meta meta8 = new Meta();
            meta8.nome = "Financiamento";
            meta8.percentual = 0.5f;
            meta8.cor = "#5cb85c";
            metaLista.Add(meta8);

            Meta meta9 = new Meta();
            meta9.nome = "Energia";
            meta9.percentual = 0.7f;
            meta9.cor = "#428bca";
            metaLista.Add(meta9);

            Meta meta10 = new Meta();
            meta10.nome = "Poupança";
            meta10.percentual = 0.3f;
            meta10.cor = "#d9534f";
            metaLista.Add(meta10);

            Meta meta11 = new Meta();
            meta11.nome = "Financiamento";
            meta11.percentual = 0.5f;
            meta11.cor = "#5cb85c";
            metaLista.Add(meta11);

            Meta meta12 = new Meta();
            meta12.nome = "Energia";
            meta12.percentual = 0.7f;
            meta12.cor = "#428bca";
            metaLista.Add(meta12);

            lvMetas.ItemsSource = metaLista;
        }

    }
}
