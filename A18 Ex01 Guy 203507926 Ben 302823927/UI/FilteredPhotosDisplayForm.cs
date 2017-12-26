using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class FilteredPhotosDisplayForm : Form
    {
        private const int k_StepBack = -1;
        private const int k_StepForward = 1;

        public List<PhotoForShow> PhotosList { get; set; }

        public int CurrentPicDisplayed { get; set; }

        public int CurrentLikes { get; set; }

        public int AmountOfLikes { get; set; }

        public FilteredPhotosDisplayForm(List<PhotoForShow> i_PhotosList)
        {
            InitializeComponent();            
            PhotosList = i_PhotosList;
            refreshPhotoData();
            CurrentPicDisplayed = 0;
        }

        private void runNumOfLikes()
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timerTickEventHandler);
            AmountOfLikes = 0;
            timer.Interval = 20;
            timer.Enabled = true;
            timer.Start();
        }

        private void timerTickEventHandler(object sender, EventArgs e)
        {
            if (int.Parse(textBoxNumOfLikes.Text) < PhotosList[CurrentPicDisplayed].ListOfFrindsLiked.Count)
            {
                int numOfLikes = int.Parse(textBoxNumOfLikes.Text);
                numOfLikes++;
                textBoxNumOfLikes.Text = numOfLikes.ToString();
            }
        }

        private void buttonNextPic_Click(object sender, EventArgs e)
        {
            navigatePictures(k_StepForward);
        }

        private void buttonPrevPic_Click(object sender, EventArgs e)
        {
            navigatePictures(k_StepBack);
        }

        private void navigatePictures(int i_Direction)
        {
            if ((CurrentPicDisplayed == 0) && i_Direction == k_StepBack)
            {
                MessageBox.Show("This is the first photo we've found within the collection..");
            }
            else if ((CurrentPicDisplayed == PhotosList.Count - 1) && i_Direction == k_StepForward)
            {
                MessageBox.Show("This is the last photo we've found within the collection..");
            }
            else
            {
                CurrentPicDisplayed += i_Direction;
                refreshPhotoData();
            }
        }

        private void refreshPhotoData()
        {
            pictureBoxCurrentPhoto.Load(PhotosList[CurrentPicDisplayed].URL);
            textBoxNumOfLikes.Text = "0";
            runNumOfLikes();
            populateFriendsWhoLike();
        }

        private void populateFriendsWhoLike()
        {
            listBoxFriendsWhoLike.Items.Clear();
            foreach(string name in PhotosList[CurrentPicDisplayed].ListOfFrindsLiked)
            {
                listBoxFriendsWhoLike.Items.Add(name);
            }
        }
    }
}
