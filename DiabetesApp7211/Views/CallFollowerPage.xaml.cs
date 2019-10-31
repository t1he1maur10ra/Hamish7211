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


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string num = EntryNumber.Text;
            Console.WriteLine(num);
            try
            {
                PhoneDialer.Open(num);
            }
            catch (Exception ex)
            {
                DisplayAlert("Unable to make call", "Please enter a number", "OK");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string num = EntryNumber.Text;
            Console.WriteLine("Number: " + num);
            try
            {
                PhoneDialer.Open(num);
            }
            catch(Exception ex)
            {
                DisplayAlert("Unable to make call", ex.ToString(), "OK");
            }
        }
    }
}
