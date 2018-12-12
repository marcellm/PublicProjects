using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploGraficos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // https://julianocustodio.com/2017/09/14/graficos-xamarin-forms/
            // Digite “Microcharts.Forms” e selecione o plugin.

            List<Microcharts.Entry> entries = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Janeiro",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Microcharts.Entry(250)
                {
                    Label = "Fevereiro",
                    ValueLabel = "250",
                    Color = SKColor.Parse("#68B9C0")
                },
                new Microcharts.Entry(100)
                {
                    Label = "Março",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#90D585")
                },
                new Microcharts.Entry(150)
                {
                    Label = "Abril",
                    ValueLabel = "150",
                    Color = SKColor.Parse("#e77e23")
                }
            };

            //Microcharts.Entry cont1 = new Microcharts.Entry(50);
            //cont1.Label = "Dezembro";
            //cont1.ValueLabel = "50";
            //cont1.Color = SKColor.Parse("#000000");              
            //entries.Add(cont1);

            float tamanhoFonte = 0;
            if (Device.Idiom == TargetIdiom.Phone)
                tamanhoFonte = 35;
            else if (Device.Idiom == TargetIdiom.Tablet)
                tamanhoFonte = 15;

                GraficoBar.Chart = new Microcharts.BarChart() { Entries = entries };            
            GraficoBar.Chart.LabelTextSize = tamanhoFonte;            

            GraficoDonut.Chart = new Microcharts.DonutChart() { Entries = entries };
            GraficoDonut.Chart.LabelTextSize = tamanhoFonte;

            GraficoLine.Chart = new Microcharts.LineChart() { Entries = entries };
            GraficoLine.Chart.LabelTextSize = tamanhoFonte;

            GraficoPoint.Chart = new Microcharts.PointChart() { Entries = entries };
            GraficoPoint.Chart.LabelTextSize = tamanhoFonte;

            GraficoGauge.Chart = new Microcharts.RadialGaugeChart() { Entries = entries };
            GraficoGauge.Chart.LabelTextSize = tamanhoFonte;

            GraficoPie.Chart = new Microcharts.PieChart() { Entries = entries };
            GraficoPie.Chart.LabelTextSize = tamanhoFonte;

            GraficoRadar.Chart = new Microcharts.RadarChart() { Entries = entries };
            GraficoRadar.Chart.LabelTextSize = tamanhoFonte;
        }
    }
}
