using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Net;
using FacebookFeaturesLogic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public class FacebookUtilitiesManager
    {
        private const string k_defaultCity = "Tel Aviv";
        private const string k_defaultCountry = "Israel";
        private const string k_WarmWeather = "Warm";
        private const string k_ColdWeather = "Cold";
        private const string k_HotWeather = "Hot";
        private const int k_HotTempature = 27;
        private const int k_ColdTempature = 20;
        private const int k_MinDaysToFetchEvents = 0;
        private const int k_MaxDaysToFetchEvents = 5;

        public Dictionary<string, string> WeatherNotes { get; private set; }

        public FacebookUtilitiesManager()
        {
            Authenticator = new Authenticator();
            UserEvents = new UserEvents();
        }

        public Authenticator Authenticator { get; private set; }

        public UserEvents UserEvents { get; private set; }

        public string DefaultCity
        {
            get
            {
                return k_defaultCity;
            }
        }

        public string DefaultCountry
        {
            get
            {
                return k_defaultCountry;
            }
        }

        public string WarmWeather
        {
            get
            {
                return k_WarmWeather;
            }
        }

        public string ColdWeather
        {
            get
            {
                return k_ColdWeather;
            }
        }

        public string HotWeather
        {
            get
            {
                return k_HotWeather;
            }
        }

        public int HotTempature
        {
            get
            {
                return k_HotTempature;
            }
        }

        public int ColdTempature
        {
            get
            {
                return k_ColdTempature;
            }
        }

        public int MinDaysToFetchEvents
        {
            get
            {
                return k_MinDaysToFetchEvents;
            }
        }

        public int MaxDaysToFetchEvents
        {
            get
            {
                return k_MaxDaysToFetchEvents;
            }
        }

        public WeatherNodes GetXMLForWeather(WeatherLocation i_Location)
        {
            bool foundWeather = false;
            XmlReader reader = null;
            XmlSerializer serializerObj = null;
            WeatherNodes loadedObj = null;
            ///Try with the event location first,if not found get the default
            while (foundWeather == false)
            {
                string url = string.Format(@"http://api.openweathermap.org/data/2.5/forecast?q={0},{1}&units=metric&mode=xml&appid=d6c795304f427b8b78559ab660464d80", i_Location.City, i_Location.CountryIsoCode);
                try
                {
                    reader = XmlReader.Create(url);
                    foundWeather = true;
                    serializerObj = new XmlSerializer(typeof(WeatherNodes));
                    loadedObj = (WeatherNodes)serializerObj.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    ////Handle case for city not found from this API:                    
                    if (ex is WebException)
                    {
                        WebException webExp = ex as WebException;

                        if (!(webExp == null) && ((WebException)ex).Status == WebExceptionStatus.ProtocolError)
                        {
                            HttpWebResponse resp = webExp.Response as HttpWebResponse;

                            if (resp != null && resp.StatusCode == HttpStatusCode.NotFound)
                            {
                                MessageBox.Show(string.Format("Sorry could not get weather for {0} fetching weather for {1} instead)", i_Location.City, k_defaultCity));
                                ResetToDefaultCity(i_Location);
                            }
                        }
                    }
                    else
                    {
                        throw ex;
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return loadedObj;
        }

        public void ResetToDefaultCity(WeatherLocation location)
        {
            location.City = k_defaultCity;
            location.Country = k_defaultCountry;
            location.CountryIsoCode = GetCountryIso(location.Country);
        }

        public RegionInfo GetCountryIso(string i_Country)
        {
            IEnumerable<RegionInfo> regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            RegionInfo countryIsoCode = regions.FirstOrDefault(region => region.EnglishName.Contains(i_Country));
            return countryIsoCode;
        }

        public void setWeatherNotesList()
        {
            WeatherNotes = new Dictionary<string, string>();
            WeatherNotes.Add(k_HotWeather, "Going to be hot that day! might want to go light on the clothes");
            WeatherNotes.Add(k_ColdWeather, "Going to be cold outside! better bring something warm");
            WeatherNotes.Add(k_WarmWeather, "Going to be warm outside! have fun!");
        }

        public void FetchFutureEvents()
        {
            UserEvents.EventList.Clear();
            try
            {
                foreach (Event eve in Authenticator.LoggedInUser.Events)
                {
                    double daysDifference = (eve.StartTime - DateTime.Now).Value.TotalDays;
                    if (daysDifference >= MinDaysToFetchEvents && daysDifference <= MaxDaysToFetchEvents)
                    {
                        UserEvents.EventList.Add(eve.Name, eve);
                    }
                }
            }
            catch(Exception ex)
            {
                if(ex is NullReferenceException)
                {
                    MessageBox.Show("Something bad happend..");
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}
