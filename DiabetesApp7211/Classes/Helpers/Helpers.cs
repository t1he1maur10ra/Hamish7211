using System;
using System.Collections.Generic;
using System.Net;
using DiabetesApp7211.Models;
using Newtonsoft.Json;

namespace DiabetesApp7211.Classes.Helpers
{
    public class Helpers
    {
        static List<Data> currentData = new List<Data>();

        //public static void FetchApiData()
        //{
        //    var startTimeSpan = TimeSpan.Zero;
        //    var periodTimeSpan = TimeSpan.FromMinutes(1);

        //    var timer = new System.Threading.Timer((e) =>
        //    {
        //        LoadData();
        //        Console.WriteLine("LoadData completed at: " + DateTime.Now);
        //        Console.WriteLine("BG is: " + GetCurrentMmolValue());
        //    }, null, startTimeSpan, periodTimeSpan);
        //}

        //static void LoadData()
        //{
        //    string json = new WebClient().DownloadString("https://orriebetes.herokuapp.com/api/v1/entries.json?count=36");
        //    currentData = JsonConvert.DeserializeObject<List<Data>>(json);
        //}

        //public static double GetCurrentMmolValue()
        //{
        //    int currentMgDlValue = currentData[0].Sgv;
        //    double currentMmolValue = (currentMgDlValue / 18);
        //    currentMmolValue = Math.Round(currentMmolValue, 1);
        //    return currentMmolValue;
        //}

    }
}
