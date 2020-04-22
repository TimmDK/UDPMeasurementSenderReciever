using System;
using System.Collections.Generic;
using System.Text;

namespace UDPWeatherSender
{
    class Measurement
    {
        public DateTime MeasureTime { get; set; }
        public string Location { get; set; }
        public double MeasurementValue { get; set; }

        public Measurement(DateTime measureTime, string location, double measurementValue)
        {
            MeasureTime = measureTime;
            Location = location;
            MeasurementValue = measurementValue;
        }

        public override string ToString()
        {
            return MeasureTime + " " + Location + " " + MeasurementValue;
        }
    }
}
