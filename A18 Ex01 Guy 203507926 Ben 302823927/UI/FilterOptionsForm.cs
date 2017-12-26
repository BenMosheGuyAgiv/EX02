using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookFeaturesLogic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class FilterOptionsForm : Form
    {
        public string FilterText { get; set; }

        public Authenticator Authenticator { get; set; }

        public FilterOptionsForm(Authenticator i_Authenticator)
        {
            InitializeComponent();
            Authenticator = i_Authenticator;
        }

        private void buttonStartFilter_Click(object sender, EventArgs e)
        {
            checkAndNavigateChosenFilterOption();
        }

        private void checkAndNavigateChosenFilterOption()
        {
            if (textBoxFilterVal.TextLength == 0)
            {
                MessageBox.Show("Filter box cannot be empty", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Photo> photoList = new List<Photo>();

                FilterText = textBoxFilterVal.Text;

                if (radioButtonByLocation.Checked)
                {
                    photoList = findPictureByLocation();
                }
                else
                {
                    if (isFriendExist())
                    {
                        photoList = findPictureByTaggedFriend();
                    }
                    else
                    {
                        MessageBox.Show("Friend name doesnt exist!");
                    }
                }

                if (photoList == null || photoList.Count == 0)
                {
                    string failedMsg = string.Format("Couldnt Find a picture of {0}", FilterText);
                    MessageBox.Show(failedMsg);
                }
                else
                {
                    FilteredPhotosDisplayForm showForm = new FilteredPhotosDisplayForm(convertPhotosToPhotoForShow(photoList));
                    showForm.ShowDialog();
                }
            }
        }

        private bool isFriendExist()
        {
            bool isFound = false;

            foreach(User friend in Authenticator.LoggedInUser.Friends)
            {
                if (friend.Name == FilterText)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        private List<Photo> findPictureByTaggedFriend()
        {
            List<Photo> taggedFriendPhotos = new List<Photo>();

            foreach (Album album in Authenticator.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.Tags != null)
                    {
                        foreach (PhotoTag phototag in photo.Tags)
                        {
                            if (phototag.User.Name == FilterText)
                            {
                                taggedFriendPhotos.Add(photo);
                            }
                        }
                    }
                }
            }

            return taggedFriendPhotos.Count == 0 ? null : taggedFriendPhotos;
        }

        private List<Photo> findPictureByLocation()
        {
            List<Photo> locationPhotos = new List<Photo>();

            foreach (Album album in Authenticator.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.Place != null && photo.Place.Name != null && photo.Place.Location != null && photo.Place.Location.City != null)
                    {
                        string userPlace = FilterText.ToLower();
                        string photoPlace = photo.Place.Name.ToLower();
                        string photoLocation = photo.Place.Location.ToString().ToLower();
                        string photoLocationCity = photo.Place.Location.City.ToLower();

                        if (photoPlace.Contains(userPlace) || photoLocation.Contains(userPlace) || photoLocationCity.Contains(userPlace))
                        {
                            locationPhotos.Add(photo);
                        }
                    }
                }
            }
            
            return locationPhotos;
        }

        private List<PhotoForShow> convertPhotosToPhotoForShow(List<Photo> i_PhotosToConvert)
        {
            List<PhotoForShow> photoList = new List<PhotoForShow>();

            foreach (Photo photo in i_PhotosToConvert)
            {
                photoList.Add(new PhotoForShow(photo));
            }

            return photoList;
        }
    }
}