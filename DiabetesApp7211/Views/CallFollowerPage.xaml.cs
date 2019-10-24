using System;
using System.Collections.Generic;
using DiabetesApp7211.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DiabetesApp7211.Views
{
    public partial class CallFollowerPage : ContentPage
    {
        public CallFollowerPage()
        {
            InitializeComponent();

            BindingContext = this;

        }

        void Handle_CallFollowerClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CallFollowerPage());
        }

        void Handle_HomeButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                PhoneDialer.Open(EntryNumber.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("Unable to make call", "Please enter a number", "OK");
            }
        }
    }
}
