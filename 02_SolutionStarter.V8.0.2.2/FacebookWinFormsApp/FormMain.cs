using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        LoginResult m_LoginResult;
        AppSettings m_AppSettings;

        public string FacebookAppId { get; } = "899084605365060";

        public FormMain()
        {
            m_AppSettings = new AppSettings();
            m_AppSettings.LoadAppSettings();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_AppSettings.RememberUser = true;
            m_AppSettings.LastAccessToken = "EAAMxtnKGm0QBO5i9NRTwTbSeOtv2WMed9IhgQUrqFZCeiBcBrAM2u6y6BXw3K3IFen7DrvxG3JDvwqxA16jyByvIpnRQzwgruKSZAXRjcKyOH2iMWSU5ZCkicLNXKRfNuD5H17hGK2X2QvwchbiTXffZAzVoPSSkOXW0kUrlbpcZCIajR0tOwgUKvagZDZD";
            if (m_AppSettings.RememberUser)
            {
                // Hide the login tab
                HideTab(loginTabPage);

                this.generalTabControl.Controls.Add(this.feedTabPage);
                this.generalTabControl.Controls.Add(this.profileTabPage);
                this.generalTabControl.Controls.Add(this.logoutTabPage);

                // Optionally, select the feed tab after login
                generalTabControl.SelectedTab = feedTabPage;
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                handleUserLoggedIn();
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_LoginResult == null)
            {
                Clipboard.SetText("lidorlevi1999@gmail.com");
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                FacebookAppId,
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                    );

            if (m_LoginResult.LoggedInUser != null)
            {
                // Hide the login tab
                HideTab(loginTabPage);

                this.generalTabControl.Controls.Add(this.feedTabPage);
                this.generalTabControl.Controls.Add(this.profileTabPage);
                this.generalTabControl.Controls.Add(this.logoutTabPage);

                // Optionally, select the feed tab after login
                generalTabControl.SelectedTab = feedTabPage;
                handleUserLoggedIn();
            }
            else { m_LoginResult = null; }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            rememberMeCheckBox.Enabled = false;
            rememberMeCheckBox.Checked = false;
            pictureBoxProfile.ImageLocation = null;

        }

        private void handleUserLoggedIn()
        {
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            rememberMeCheckBox.Enabled = true;
            rememberMeCheckBox.Checked = false;
            
            }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if(rememberMeCheckBox.Checked)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.RememberUser = true;
                m_AppSettings.SaveAppSettings();
            }
            else
            {
                m_AppSettings.DeleteAppSettings();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ((sender as ListBox).SelectedItem as Page).PictureSqaureURL;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = ((sender as ListBox).SelectedItem as Page).PictureSqaureURL;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void calendarStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateFilteredPosts();

        }

        private void calendarEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateFilteredPosts();

        }

        private void UpdateFilteredPosts()
        {
            // Get the selected start and end dates
            DateTime startDate = calendarStart.SelectionStart;
            DateTime endDate = calendarEnd.SelectionStart;

            // Filter posts between the selected dates
            var filteredPosts = m_LoginResult.LoggedInUser.Posts
                                    .Where(post => post.UpdateTime >= startDate && post.UpdateTime <= endDate)
                                    .OrderByDescending(post => post.UpdateTime)
                                    .ToList();

            // Update the ListBox data source
            postsListBox.DataSource = filteredPosts;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void LoadProfileData()
        {
            // Example data - replace with actual data source
            userName.Text = m_LoginResult.LoggedInUser.Name;
            profilePictureBox.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            userBirthday.Text = String.Format(@"Your birthday is at : {0}", m_LoginResult.LoggedInUser.Birthday);
            userEmail.Text = String.Format(@"Your email is : {0}", m_LoginResult.LoggedInUser.Email);
            userGender.Text = String.Format(@"Your gender is : {0}", m_LoginResult.LoggedInUser.Gender);
            userLocation.Text = String.Format(@"Your Location is : {0}", m_LoginResult.LoggedInUser.Location.Name);
        }

        private void LoadFeedData()
        {
            favouriteTeamsListBox.DisplayMember = "Name";
            likedPagesListBox.DisplayMember = "Name";
            postsListBox.DisplayMember = "Title";
            favouriteTeamsListBox.DataSource = m_LoginResult.LoggedInUser.FavofriteTeams;
            likedPagesListBox.DataSource = m_LoginResult.LoggedInUser.LikedPages;
            calendarStart.SetDate(new DateTime(2007, 1, 1)); // or a specific earliest date
            calendarEnd.SetDate(DateTime.Today);

            postsListBox.DataSource = m_LoginResult.LoggedInUser.Posts.OrderByDescending(post => post.UpdateTime).ToList();

        }

        private void LoadLogoutPage()
        {
            // logout from account
            MessageBox.Show("Are you sure you want to logout?");
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void generalTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = generalTabControl.SelectedTab;

            if (selectedTab == feedTabPage)
            {
                LoadFeedData();
            }
            else if (selectedTab == profileTabPage)
            {
                LoadProfileData();
            }
            else if (selectedTab == logoutTabPage)
            {
                LoadLogoutPage();
            }
        }
    }
}
