using BasicFacebookFeatures;
using FacebookWrapper;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

public partial class FeedTab : UserControl, IFacebookTab
{
    private FacebookDataListbox LikedPageFacebookDataListbox;
    private FacebookDataListbox FavouriteTeamsFacebookDataListbox;
    private FacebookDataListbox PostsFacebookDataListBox;
    private MonthCalendar calendarStart;
    private Button logoutButton;

    public FeedTab()
    {
        InitializeComponent();
        InitializeCustomComponent();
    }

    private void InitializeCustomComponent()
    {
        this.LikedPageFacebookDataListbox = new FacebookDataListbox("Liked Pages");
        this.FavouriteTeamsFacebookDataListbox = new FacebookDataListbox("Favourite Teams");
        this.PostsFacebookDataListBox = new FacebookDataListbox("Posts");

        // 
        // LikedPageFacebookDataListbox
        // 
        this.LikedPageFacebookDataListbox.Location = new System.Drawing.Point(0, 0);
        this.LikedPageFacebookDataListbox.Name = "LikedPageFacebookDataListbox";
        this.LikedPageFacebookDataListbox.Size = new System.Drawing.Size(554, 398);
        this.LikedPageFacebookDataListbox.TabIndex = 7;
        this.LikedPageFacebookDataListbox.Load += new System.EventHandler(this.LikedPageFacebookDataListbox_Load);
        // 
        // FavouriteTeamsFacebookDataListbox
        // 
        this.FavouriteTeamsFacebookDataListbox.Location = new System.Drawing.Point(0, 441);
        this.FavouriteTeamsFacebookDataListbox.Name = "FavouriteTeamsFacebookDataListbox";
        this.FavouriteTeamsFacebookDataListbox.Size = new System.Drawing.Size(554, 362);
        this.FavouriteTeamsFacebookDataListbox.TabIndex = 6;
        this.FavouriteTeamsFacebookDataListbox.Load += new System.EventHandler(this.FavouriteTeamsFacebookDataListbox_Load);
        // 
        // PostsFacebookDataListBox
        // 
        this.PostsFacebookDataListBox.AccessibleName = "PostsFacebookDataListbox";
        this.PostsFacebookDataListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
        this.PostsFacebookDataListBox.Location = new System.Drawing.Point(598, 12);
        this.PostsFacebookDataListBox.Name = "PostsFacebookDataListBox";
        this.PostsFacebookDataListBox.Size = new System.Drawing.Size(563, 386);
        this.PostsFacebookDataListBox.TabIndex = 0;

                    this.Controls.Add(this.PostsFacebookDataListBox);
            this.Controls.Add(this.FavouriteTeamsFacebookDataListbox);
            this.Controls.Add(this.LikedPageFacebookDataListbox);
        FavouriteTeamsFacebookDataListbox.ListBox.DisplayMember = "Name";
        LikedPageFacebookDataListbox.ListBox.DisplayMember = "Name";
        PostsFacebookDataListBox.ListBox.DisplayMember = "Title";
        calendarStart.SetDate(new DateTime(2007, 1, 1));

    }

    public void loadData(LoginResult i_LoginResult)
    {
        // Create tasks for each component's data fetching
        Thread favouriteTeamsThread = new Thread(() =>
        {
            if (!FavouriteTeamsFacebookDataListbox.IsDataLoaded)
            {
                var favouriteTeams = i_LoginResult.LoggedInUser.FavofriteTeams;
                // Use BeginInvoke to update UI safely
                this.BeginInvoke((MethodInvoker)delegate
                {
                    FavouriteTeamsFacebookDataListbox.loadData(favouriteTeams);
                });
            }
        });

        Thread likedPagesThread = new Thread(() =>
        {
            if (!LikedPageFacebookDataListbox.IsDataLoaded)
            {
                var likedPages = i_LoginResult.LoggedInUser.LikedPages.ToArray();
                // Use BeginInvoke to update UI safely
                this.BeginInvoke((MethodInvoker)delegate
                {
                    LikedPageFacebookDataListbox.loadData(likedPages);
                });
            }
        });

        Thread postsThread = new Thread(() =>
        {
            if (!PostsFacebookDataListBox.IsDataLoaded)
            {
                var posts = i_LoginResult.LoggedInUser.Posts.ToArray();
                // Use BeginInvoke to update UI safely
                this.BeginInvoke((MethodInvoker)delegate
                {
                    PostsFacebookDataListBox.loadData(posts);
                });
            }
        });

        // Start all threads
        favouriteTeamsThread.Start();
        likedPagesThread.Start();
        postsThread.Start();
    }

    public void hideData()
    {
        
    }

    private void InitializeComponent()
    {
            this.calendarStart = new System.Windows.Forms.MonthCalendar();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // calendarStart
            // 
            this.calendarStart.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.calendarStart.Location = new System.Drawing.Point(1819, 12);
            this.calendarStart.Name = "calendarStart";
            this.calendarStart.TabIndex = 0;
            this.calendarStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarStart_DateChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1913, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            // 
            // FeedTab
            // 
            this.AccessibleName = "feedTabPage";
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.calendarStart);
            this.Location = new System.Drawing.Point(8, 51);
            this.Name = "Feed Tab";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(2288, 1016);
            this.Enter += new System.EventHandler(this.FeedTab_Enter);
            this.ResumeLayout(false);

    }

    private void FeedTab_Enter(object sender, EventArgs e)
    {
        // Assuming you have a reference to the main form or login result
        FormMain formMain = this.FindForm() as FormMain;
        if (formMain != null)
        {
            loadData(formMain.LoginResult);
        }
    }

    private void calendarEnd_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void calendarStart_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void likedPagesGroup_Enter(object sender, EventArgs e)
    {

    }

    private void FeedTab_Load_1(object sender, EventArgs e)
    {

    }

    private void FavouriteTeamsFacebookDataListbox_Load(object sender, EventArgs e)
    {

    }

    private void LikedPageFacebookDataListbox_Load(object sender, EventArgs e)
    {

    }
}
