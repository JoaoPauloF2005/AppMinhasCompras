﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMinhasCompras.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked_Novo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NovoProduto());
        } 

        private void ToolbarItem_Clicked_Somar(object sender, EventArgs e)
        {

        }
    }
}