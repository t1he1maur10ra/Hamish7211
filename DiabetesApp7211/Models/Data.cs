using System;
using Newtonsoft.Json;

namespace DiabetesApp7211.Models
{
    public class Data
    {
        public string _id { get; set; }
        public string Device { get; set; }
        public long Date { get; set; }
        public DateTime DateString { get; set; }
        public int Sgv { get; set; }
        public double Delta { get; set; }
        public string Direction { get; set; }
        public string Type { get; set; }
        public int Filtered { get; set; }
        public int Unfiltered { get; set; }
        public int Rssi { get; set; }
        public int Noise { get; set; }
        public DateTime SysTime { get; set; }
    }
}