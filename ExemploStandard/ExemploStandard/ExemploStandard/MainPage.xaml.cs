﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploStandard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void acessar_cadastro_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Cadastro();
        }        
    }
}
