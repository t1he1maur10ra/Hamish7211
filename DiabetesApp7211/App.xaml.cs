using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Timers;
using DiabetesApp7211.Classes.Helpers;
using DiabetesApp7211.Models;
using DiabetesApp7211.Views;
using FluentScheduler;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DiabetesApp7211
{
    public partial class App : Application
    {
        public static List<Data> currentData = new List<Data>();
        public static double currentMmolValue;
        public static bool dataHasBeenUpdated;

        // using Application.Current.Properties
        private const string FirstNameKey = "FirstName";
        private const string LastNameKey = "LastName";
        private const string FollowerNameKey = "FollowerName";
        private const string FollowerNumberKey = "FollowerNumberName";
        private const string NightscoutUrlKey = "NightscoutUrlName";


        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }


        /**Testing - Can be deleted**/
        static void TestOutput()
        {
            Console.WriteLine("LoadData completed at: " + DateTime.Now);
            Console.WriteLine("currentData[0].Sgv => " + currentData[0].Sgv);
            Console.WriteLine("BG is: " + currentMmolValue);
          
        }



        public static void FetchApiData()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer((e) =>
            {
                LoadData();

            }, null, startTimeSpan, periodTimeSpan);
        }

        public static double LoadData()
        {
            string json = new WebClient().DownloadString("https://orriebetes.herokuapp.com/api/v1/entries.json?count=36");
            currentData = JsonConvert.DeserializeObject<List<Data>>(json);
            double temp = GetMmolValue();
            TestOutput();
            if (Application.Current.Properties.ContainsKey("currentMmolValue"))
                Application.Current.Properties["currentMmolValue"] = currentMmolValue;
            else
                Application.Current.Properties.Add("currentMmolValue", currentMmolValue);
            return temp;
        }

        public static double GetMmolValue()
        {
            double currentMgDlValue = currentData[0].Sgv;
            double mmolValue = (currentMgDlValue / 18);
            double roundedMmolValue = Math.Round(mmolValue, 1);
            currentMmolValue = roundedMmolValue;
            return roundedMmolValue;
        }


        protected override void OnStart()
        {
            // Handle when your app starts
           LoadData();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            LoadData();
        }

      
        // using Application.Current.Properties
        public string FirstName
        {
            get
            {
                if (Properties.ContainsKey(FirstNameKey))
                    return Properties[FirstNameKey].ToString();

                return "";
            }
            set
            {
                Properties[FirstNameKey] = value;
            }
        }

        public string LastName
        {
            get
            {
                if (Properties.ContainsKey(LastNameKey))
                    return Properties[LastNameKey].ToString();

                return "";
            }
            set
            {
                Properties[LastNameKey] = value;
            }
        }

        public string FollowerName
        {
            get
            {
                if (Properties.ContainsKey(FollowerNameKey))
                    return Properties[FollowerNameKey].ToString();

                return "";
            }
            set
            {
                Properties[FollowerNameKey] = value;
            }
        }

        public string FollowerNumber
        {
            get
            {
                if (Properties.ContainsKey(FollowerNumberKey))
                    return Properties[FollowerNumberKey].ToString();

                return "";
            }
            set
            {
                Properties[FollowerNumberKey] = value;
            }
        }

        public string NightscoutUrl
        {
            get
            {
                if (Properties.ContainsKey(NightscoutUrlKey))
                    return Properties[NightscoutUrlKey].ToString();

                return "";
            }
            set
            {
                Properties[NightscoutUrlKey] = value;
            }
        }
    }
}
