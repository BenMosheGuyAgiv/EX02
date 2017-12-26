using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public class Authenticator
    {
        public User LoggedInUser { get; set; }

        public bool Login(string i_AppId)
        {
            bool logged = false;
            LoginResult result;

            result = FacebookService.Login(
                i_AppId,
            "public_profile",
            "user_friends",
            "publish_actions",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_tagged_places",
            "publish_pages",
            "manage_pages",
            "publish_actions",
            "publish_pages",
            "publish_actions",
            "rsvp_event");            
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                FacebookService.s_CollectionLimit = 100;
                logged = true;
            }

            return logged;
        }

        public void LoginWrapper()
        {
            LoggedInUser = null;
        }

        public void Logout()
        {
            FacebookService.Logout(LoginWrapper);
        }
    }
}
