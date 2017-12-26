using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class MainForm : Form
    {
        public FacebookUtilitiesManager FacebookManager { get; set; }

        public MainForm()
        {
            InitializeComponent();
            FacebookManager = new FacebookUtilitiesManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FacebookManager.setWeatherNotesList();
            LoginUser();
        }

        private void buttonPicFilter_Click(object sender, EventArgs e)
        {
            FilterOptionsForm form2 = new FilterOptionsForm(FacebookManager.Authenticator);
            form2.ShowDialog();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus;
            if (!string.IsNullOrEmpty(richTextBoxPostStatus.Text))
            {
                postedStatus = FacebookManager.Authenticator.LoggedInUser.PostStatus(richTextBoxPostStatus.Text);
                MessageBox.Show("Your post status has succeeded");
            }
            else
            {
                MessageBox.Show("Cannot post an empty status!");
            }

            richTextBoxPostStatus.ResetText();
        }

        public void LoginUser()
        {
            AppIdOptionsForm appIDForm = new AppIdOptionsForm();
            appIDForm.Authenticator = FacebookManager.Authenticator;
            try
            {
                appIDForm.ShowDialog();
                generateInfoForUser();
            }                       
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }
        }

        private void generateInfoForUser()
        {
            getUserProfileAndCoverPictures();
            addRequiredForecastEventsToListBox();
            fetchFriendsList();
        }

        public static void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void fetchFriendsList()
        {
            listBoxFriendsList.Items.Clear();

            foreach (User friend in FacebookManager.Authenticator.LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend.Name);
            }
        }

        private void getUserProfileAndCoverPictures()
        {
            if (FacebookManager.Authenticator.LoggedInUser != null && FacebookManager.Authenticator != null)
            {
                pictureBoxCover.LoadAsync(FacebookManager.Authenticator.LoggedInUser.Cover.SourceURL);
                pictureBoxProfile.LoadAsync(FacebookManager.Authenticator.LoggedInUser.PictureSqaureURL);
            }
        }

        private void addRequiredForecastEventsToListBox()
        {
            listBoxEventsList.Items.Clear();
            FacebookManager.FetchFutureEvents();

            foreach (Event eve in FacebookManager.UserEvents.EventList.Values)
            {
                listBoxEventsList.Items.Add(eve.Name);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookManager.Authenticator.Logout();
            MessageBox.Show("Logged out! Please relogin if you wish to continue using the app.");
            try
            {
                LoginUser();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void getWeatherForEvent(Event i_SelectedEvent)
        {
            WeatherLocation location = new WeatherLocation();
            getLocationForWeather(i_SelectedEvent, location);
            WeatherNodes loadedObj = FacebookManager.GetXMLForWeather(location);
            Weather eventWeather = null;

            foreach (Weather obj in loadedObj.WeatherList)
            {
                if (i_SelectedEvent.StartTime >= obj.FromTime && i_SelectedEvent.StartTime <= obj.ToTime)
                {
                    eventWeather = obj;
                }
            }

            recommendForWeather(i_SelectedEvent, eventWeather);
            pictureBoxWeatherIcon.Load(string.Format("http://openweathermap.org/img/w/{0}.png", eventWeather.WeatherSymbol.WeatherCode));
            pictureBoxEvent.Load(i_SelectedEvent.PictureLargeURL);
            panelEventDetails.Visible = true;
        }

        private void recommendForWeather(Event i_SelectedEvent, Weather i_EventWeather)
        {
            Color heat = Color.Green;
            string temperatureNote = FacebookManager.WeatherNotes[FacebookManager.WarmWeather];
            double tempature = i_EventWeather.Temperature.AverageTemperature;

            if (tempature >= FacebookManager.HotTempature)
            {
                heat = Color.Red;
                temperatureNote = FacebookManager.WeatherNotes[FacebookManager.HotWeather];
            }
            else if (tempature <= FacebookManager.ColdTempature)
            {
                heat = Color.Blue;
                temperatureNote = FacebookManager.WeatherNotes[FacebookManager.ColdWeather];
            }

            richTextBoxEventDescription.Text = i_SelectedEvent.Description;
            richTextBoxWeatheStats.Clear();
            AppendText(richTextBoxWeatheStats, string.Format("Temperature: {0} {1}\n{2}\n", tempature, i_EventWeather.Temperature.UnitType, temperatureNote), heat);
            richTextBoxWeatheStats.AppendText(string.Format("Weather: {0}", i_EventWeather.WeatherSymbol.WeatherDescription));
        }

        private void getLocationForWeather(Event i_SelectedEvent, WeatherLocation i_Location)
        {
            if (i_SelectedEvent.Place.Location != null)
            {
                i_Location.City = i_SelectedEvent.Place.Location.City;
                i_Location.Country = i_SelectedEvent.Place.Location.Country;
                i_Location.CountryIsoCode = FacebookManager.GetCountryIso(i_Location.Country);
            }
            else
            {
                MessageBox.Show(string.Format("Could not find selected event location! setting to default values({0}, {1}", FacebookManager.DefaultCity, FacebookManager.DefaultCountry));
                FacebookManager.ResetToDefaultCity(i_Location);
            }
        }

        private void listBoxEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEventsList.SelectedItem != null)
            {
                Event selectedEvent = FacebookManager.UserEvents.EventList[listBoxEventsList.SelectedItem.ToString()];
                getWeatherForEvent(selectedEvent);
            }
        }
    }
}
