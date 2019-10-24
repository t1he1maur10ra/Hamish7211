using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesApp7211.Views;
using DiabetesApp7211.Models;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;
using Xamarin.Essentials;
using System.Timers;
using DiabetesApp7211.Classes.Helpers;

namespace DiabetesApp7211
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static List<int> sgvData = new List<int>();
        static List<Entry> microchartsEntries = new List<Entry>();
        string firstName = "Test";
        //List<Data> currentData = App.currentData;
        static double currentMmolValue;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = Application.Current;
            currentMmolValue = App.LoadData();
            Console.WriteLine("App.currentMmolValue => " + currentMmolValue);
            CurrentBgMessage(firstName, App.currentMmolValue);
            GetSgvValues();
            BuildMicrochartsEntry();
            Chart1.Chart = new PointChart { Entries = microchartsEntries };
            //RefreshApiDataEveryMinute();
        }

        //double currentMmolValue = Helpers.GetCurrentMmolValue();

        //void LoadData()
        //{
        //    string json = new WebClient().DownloadString("https://orriebetes.herokuapp.com/api/v1/entries.json?count=36");
        //    currentData = JsonConvert.DeserializeObject<List<Data>>(json);

        //    Console.WriteLine("LoadData completed at: " + DateTime.Now);
        //    Console.WriteLine("BG is: " + currentData[0].Sgv);
        //}

        //void RefreshApiDataEveryMinute()
        //{
        //    var startTime = TimeSpan.Zero;
        //    var periodTimeSpan = TimeSpan.FromMinutes(1);

        //    var timer = new System.Threading.Timer((e) =>
        //    {
        //        LoadData();
        //        Console.WriteLine("API data refreshed at: " + DateTime.Now);
        //        Console.WriteLine("BG is: " + currentData[0].Sgv);
        //    }, null, startTime, periodTimeSpan);

        //    CurrentBgMessage();
        //    Console.WriteLine("Current BG message refreshed");

        //}

        void GetSgvValues()
        {
            for (int i = 0; i < App.currentData.Count; i++)
            {
                sgvData.Add(App.currentData[i].Sgv);
            }
        }

        void CurrentBgMessage(string name, double mmolValue)
        {
            WelcomeMessageName.Text = "Hello " + name;
            WelcomeMessageBg.Text = "Your current BG is";
            CurrentBgNum.Text = mmolValue.ToString();
        }

        void BuildMicrochartsEntry()
        {
            int sgv;
            for (int i = 0; i < sgvData.Count; i++)
            {
                sgv = sgvData[i];
                microchartsEntries.Add(
                    new Entry(sgv)
                    {
                        Color = SKColor.Parse("#2B2D42")
                    }
                );
            }
        }

        void Handle_UserIconClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        void Handle_EmergencyButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EmergencyPage());
        }
    }
}
