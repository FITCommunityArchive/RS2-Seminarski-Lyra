﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void Artist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void Album_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void Playlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}