﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3Page2 : ContentPage
    {
        public activity3Page2()
        {
            InitializeComponent();
        }

        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }  
    }
}