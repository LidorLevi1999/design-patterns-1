using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class ProfilePageTab : UserControl
    {
        public event EventHandler LogoutButtonClicked;
        private string m_PlaceholderText = "Whats on your mind ?";
        private User User { get; set; }
        public ProfilePageTab()
        {
            InitializeComponent();
            initializeNewStatusTextBox();
        }

        public void loadProfileData(User i_User)
        {
            this.User = i_User;
            this.profileImage.ImageLocation = User.PictureNormalURL;
            this.userName.Text = $"{User.Name} , {User.Location.Name}";
            this.userEmail.Text = User.Email;
            this.userGender.Text = User.Gender.ToString();
            this.userBirthday.Text = $"Born at : {User.Birthday}";
            this.releationshipStatus.Text = $"Relationship status : {User.RelationshipStatus.ToString()}";
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == m_PlaceholderText)
            {
                textBox.Text = String.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void initializeNewStatusTextBox()
        {
            newStatusTextbox.Text = m_PlaceholderText;
            newStatusTextbox.ForeColor = Color.Gray;
            postNewStatusButton.Enabled = false;
            newStatusTextbox.Enter += removePlaceholder;
            newStatusTextbox.Leave += setPlaceholder;
        }


        private void setPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = m_PlaceholderText;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void postNewStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.postNewStatusButton.Enabled = false;
                User.PostStatus(this.newStatusTextbox.Text);
                MessageBox.Show("Status posted successfully!");
            }
            catch (Exception i_Exception)
            {
                MessageBox.Show("Failed to post status: " + i_Exception.Message);
            }
            finally
            {
                this.newStatusTextbox.Text = m_PlaceholderText;
            }
        }

        private void newStatusTextbox_TextChanged(object sender, EventArgs e)
        {
            bool isTextboxEmpty = String.IsNullOrEmpty(this.newStatusTextbox.Text);
            bool isTextOfTextboxIsThePlaceholder = this.newStatusTextbox.Text == m_PlaceholderText;

            this.postNewStatusButton.Enabled = !isTextOfTextboxIsThePlaceholder && !isTextboxEmpty;
        }

        private void createMemeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Select an Image File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    MemeCreatorForm memeCreatorForm = new MemeCreatorForm(selectedImage, User);

                    memeCreatorForm.StartPosition = FormStartPosition.CenterScreen;
                    memeCreatorForm.BackgroundImageLayout = ImageLayout.Stretch;
                    memeCreatorForm.ShowDialog();
                }
            }
        }
    }
}
