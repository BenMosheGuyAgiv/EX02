using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesLogic
{
    public class UserEvents
    {
        public Dictionary<string, Event> EventList { get; set; }

        public UserEvents()
        {
            EventList = new Dictionary<string, Event>();
        }
    }
}
