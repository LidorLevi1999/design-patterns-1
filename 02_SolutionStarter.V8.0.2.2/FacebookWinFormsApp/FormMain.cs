using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private Screen CurrentScreen { get; set; }
        private Size SizeOnLoginTab { get; } = new Size(682, 408);
        private LoginResult m_LoginResult;
        internal LoginResult LoginResult { get { return m_LoginResult; } }
        private Size m_MinimumSize = new Size(800, 800);
        public string FacebookAppId { get; } = "899084605365060";
        public FormMain()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            lockFormSize();
            AppSettings.Instance.LoadAppSettings();
            InitializeComponent();
            if (AppSettings.Instance.RememberUser && AppSettings.Instance.AccessTokenExpireDate < DateTime.Now)
            {
                Thread connectThread = new Thread(() =>
                {
                    m_LoginResult = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
                    if (m_LoginResult.LoggedInUser != null)
                    {
                        this.Invoke((MethodInvoker)initializeCustomTabs);
                    }
                });
                connectThread.Start();
            }
        }

        private void lockFormSize()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            CurrentScreen = Screen.FromControl(this);
        }

        private void MainForm_OnFormClosing(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {

                if (AppSettings.Instance.RememberUser && m_LoginResult != null)
                {
                    AppSettings.Instance.LastAccessToken = m_LoginResult.AccessToken;
                    AppSettings.Instance.AccessTokenExpireDate = m_LoginResult.FacebookOAuthResult?.Expires ?? DateTime.MinValue;
                    AppSettings.Instance.SaveAppSettings();
                }
                else
                {
                    AppSettings.Instance.DeleteAppSettings();
                }
            }));
        }

        private void initializeCustomTabs()
        {
            this.createFeedTab();
            this.createProfilePageTab();
            this.initTabControl();
            this.HideTab(loginTabPage);
            this.expandAndLockFormSize();
        }

        private void expandAndLockFormSize()
        {
            Screen currentScreen = Screen.FromControl(this);

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Location = new Point(0, 20);
            this.MaximizeBox = true;
            this.Size = currentScreen.Bounds.Size;
            this.MinimumSize = this.m_MinimumSize;
        }

        private void initTabControl()
        {
            this.generalTabControl.Controls.Add(this.profileTabPage);
            this.generalTabControl.Controls.Add(this.feedTabPage);
            this.generalTabControl.SelectedTab = this.profileTabPage;
        }

        private void createProfilePageTab()
        {
            ProfilePageTab profileTabPage = new ProfilePageTab();

            profileTabPage.LoadProfileData(m_LoginResult.LoggedInUser);
            profileTabPage.LogoutButtonClicked += profileTabPage_LogoutButtonClicked;
            this.profileTabPage = new TabPage("My Profile");
            this.profileTabPage.Controls.Add(profileTabPage);
        }

        private void profileTabPage_LogoutButtonClicked(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                performLogout();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_LoginResult == null)
            {
                login();
            }
        }


        private void login()
        {
            string[] appPermissions =
            {
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
            };

            AppSettings.Instance.RememberUser = rememberMeCheckbox.Checked;
            m_LoginResult = FacebookService.Login(FacebookAppId, appPermissions);
            if (m_LoginResult.LoggedInUser != null)
            {
                this.Invoke((MethodInvoker)initializeCustomTabs);
            }
            else
            {
                m_LoginResult = null;
            }
        }

        private void performLogout()
        {
           FacebookService.Logout();
           clearUserSession();
        }


        private void clearUserSession()
        {
            AppSettings.Instance.RememberUser = false;
            MessageBox.Show("You have been logged out.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.rememberMeCheckbox.Checked = false;
            this.m_LoginResult = null;
            this.showOnlyLoginStage();
        }

        private void showOnlyLoginStage()
        {
            this.HideTab(feedTabPage);
            this.HideTab(profileTabPage);
            this.MinimumSize = new Size(0, 0);
            this.Size = SizeOnLoginTab;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.lockFormSize();
            this.ShowTab(loginTabPage);
            this.generalTabControl.SelectedTab = loginTabPage;
        }

        private void createFeedTab()
        {
            FeedTab feedTab = new FeedTab();

            feedTab.loadDataToListboxes(m_LoginResult.LoggedInUser);
            feedTab.PostsFacebookDataListBox.IsPictureSupported = false;
            TabPage feedTabPage = new TabPage(feedTab.Name);

            feedTabPage.Controls.Add(feedTab);
            this.feedTabPage = feedTabPage;
        }

        private void rememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberUser = rememberMeCheckbox.Checked;
        }
    }
}
