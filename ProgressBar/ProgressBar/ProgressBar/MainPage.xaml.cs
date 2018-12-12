using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProgressBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //initial progress is 20%
            var progressBar = new ProgressBar {
              Progress = .2,
            };

            // animate the progression to 80%, in 250ms
            await progressBar.ProgressTo (.8, 250, Easing.Linear);
        }
    }
}
