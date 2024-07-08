using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment_10._1._1_Create_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var forecast = new Terminal_Aerodrome_Forecast
            {
                Date = 240708,
                StartTime = 1100,
                EndTime = 1900,
                Group = "BECMG",
                WindDirection = 180,
                WindSpeed = 10,
                Visibility = "7SM",
                AltimeterSetting = 30.12,
                Turbulence = 50103,
                Icing = 60104,
                PresentWeather = "NSW"
            };

            string jsonString = JsonSerializer.Serialize(forecast);

            Console.WriteLine(jsonString);

            XmlSerializer mySerializer = new XmlSerializer(typeof(Terminal_Aerodrome_Forecast));

            var sw = new StreamWriter("D://MSSA//myFileName.xml");
            mySerializer.Serialize(sw, forecast);
            sw.Close();
        }
    }
}
