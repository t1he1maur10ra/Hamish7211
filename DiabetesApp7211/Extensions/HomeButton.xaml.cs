using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DiabetesApp7211.Extensions
{
    public partial class HomeButton : Grid
    {
        public HomeButton()
        {
            InitializeComponent();
        }

        async void Handle_HomeBtnClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
