using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._1._1_Create_Class
{
    public class Terminal_Aerodrome_Forecast
    {

        public int Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string? Group { get; set; }
        public int WindDirection { get; set; }
        public int WindSpeed { get; set; }
        public string? Visibility { get; set; }
        public double AltimeterSetting { get; set; }
        public int Turbulence { get; set; }
        public int Icing { get; set; }
        
        private string? presentWeather;

        public string PresentWeather
        {
            get { return presentWeather; }
            set { presentWeather = value; }
            
        }
    }
}
