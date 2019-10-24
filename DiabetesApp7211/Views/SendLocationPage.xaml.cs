using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace DiabetesApp7211.Views
{
    public partial class SendLocationPage : ContentPage
    {
        public SendLocationPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Handle_HomeButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private async void SendButton_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                await Sms.ComposeAsync(new SmsMessage(EntryMessage.Text,
                    EntryNumber.Text));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Unable to send message", "Please enter valid number", "OK");
            }
        }
    }
}
