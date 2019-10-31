using System;
using System.Collections.Generic;
using System.Globalization;
using DiabetesApp7211.Classes.Helpers;
using DiabetesApp7211.Models;
using Xamarin.Forms;

namespace DiabetesApp7211.Views
{
    public partial class EmergencyPage : ContentPage
    {
        static List<Data> currentData = new List<Data>();
        string firstName = "Test";//Application.Current.Properties["FirstName"].ToString();
        //double currentMmolValue = Helpers.ConvertToMmol(currentData[0].Sgv);

        public EmergencyPage(string fname, double val)
        {
            InitializeComponent();
            BindingContext = this;
            CurrentBgMessage(fname, val);
        }

        void CurrentBgMessage(string name, double mmolValue)
        {
            WelcomeMessageName.Text = "Hello " + name;
            WelcomeMessageBg.Text = "Your current BG is";
            CurrentBgNum.Text = mmolValue.ToString();
        }

        void Handle_CallFollowerClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CallFollowerPage());
        }

        void Handle_SendLocationClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SendLocationPage());
        }

        void Handle_FindCarbsClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FindCarbsPage());
        }

        void Handle_HomeButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
