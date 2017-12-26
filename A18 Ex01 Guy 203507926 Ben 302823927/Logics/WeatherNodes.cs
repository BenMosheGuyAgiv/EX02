using System.Xml.Serialization;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    [XmlRoot("weatherdata")]
    public class WeatherNodes
    {
        [XmlArray("forecast")]
        [XmlArrayItem("time", typeof(Weather))]
        public Weather[] WeatherList { get; set; }
    }
}
