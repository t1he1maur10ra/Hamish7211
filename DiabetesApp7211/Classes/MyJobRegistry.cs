using System;
using FluentScheduler;

namespace DiabetesApp7211.Classes
{
    public class MyJobRegistry : Registry
    {
        public MyJobRegistry()
        {
            //Schedule<LoadData>().ToRunNow().AndEvery(1).Minutes();
        }
    }
}
