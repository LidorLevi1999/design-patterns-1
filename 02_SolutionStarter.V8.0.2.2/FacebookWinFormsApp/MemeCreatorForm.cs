using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MemeCreatorForm : Form
    {
        internal static string m_MemesDirectoryPath = "memes";
        private string TopMemeText { get; set; } = String.Empty;
        private string BottomMemeText { get; set; } = String.Empty;
        private Color TopTextColor { get; set; } = Color.Black;
        private Color BottomTextColor { get; set; } = Color.Black;
        private readonly string r_DefaultFont = "Arial";
        private User User { get; set; }
        public MemeCreatorForm(Image i_SelectedImage, User i_User)
        {
            this.User = i_User;
            InitializeComponent();
            initializeFontComboBoxesWithData();
            setupPictureBox(i_SelectedImage);
        }

        private void initializeFontComboBoxesWithData()
        {
            topMemeTextFontComboBox.DisplayMember = "Name";
            bottomMemeTextFontComboBox.DisplayMember = "Name";
            foreach (var fontFamily in FontFamily.Families)
            {
                topMemeTextFontComboBox.Items.Add(fontFamily);
                bottomMemeTextFontComboBox.Items.Add(fontFamily);
            }

            topMemeTextFontComboBox.SelectedIndex = 0;
            bottomMemeTextFontComboBox.SelectedIndex = 0;
        }

        private void setupPictureBox(Image i_SelectedImage)
        {
            this.MemePictureBox.Image = i_SelectedImage;
        }

        private void bottomTextInputBox_TextChanged(object sender, EventArgs e)
        {
            inputBoxTextChange(false);
        }

        private void topTextInputBox_TextChanged(object sender, EventArgs e)
        {
            inputBoxTextChange(true);
        }

        private void inputBoxTextChange(bool i_IsTopTextInputBox)
        {
            if(i_IsTopTextInputBox)
            {
                this.TopMemeText = topTextInputBox.Text;
            }
            else
            {
                this.BottomMemeText = bottomTextInputBox.Text;
            }

            invalidateMemePictureBox();
        }

        private void memePictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            var imageSize = MemePictureBox.Image.Size;
            string topFontName = topMemeTextFontComboBox.SelectedItem?.ToString() ?? r_DefaultFont;
            string bottomFontName = bottomMemeTextFontComboBox.SelectedItem?.ToString() ?? r_DefaultFont;

            using (Font topFont = new Font(topFontName, 24, FontStyle.Bold))
            using (Font bottomFont = new Font(bottomFontName, 24, FontStyle.Bold))
            {
                new MemeTextDecorator(new ShadowMemeText(new CoreMemeText())).Draw(graphics, TopMemeText, topFont, TopTextColor, imageSize, true);
                new MemeTextDecorator(new ShadowMemeText(new CoreMemeText())).Draw(graphics, BottomMemeText, bottomFont, BottomTextColor, imageSize, false);
            }
        }

        private void colorPickerMemeTopTextButton_Click(object sender, EventArgs e)
        {
            colorPickerButtonClicked(true);
        }

        private void colorPickerMemeBottomTextButton_Click(object sender, EventArgs e)
        {
            colorPickerButtonClicked(false);
        }

        private void colorPickerButtonClicked (bool i_IsTopText)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if(i_IsTopText)
                {
                    TopTextColor = colorDialog.Color;
                }
                else
                {
                    BottomTextColor = colorDialog.Color;
                }
                invalidateMemePictureBox();
            }

        }

        private void invalidateMemePictureBox()
        {
            MemePictureBox.Invalidate();
        }

        private void topMemeTextFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            invalidateMemePictureBox();
        }

        private void bottomMemeTextFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            invalidateMemePictureBox();
        }

        private void uploadMeme_Click(object sender, EventArgs e)
        {
            string timestampId = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString("X");
            string saveMemeFileName = $@"{m_MemesDirectoryPath}\meme_{timestampId}.png";

            try
            {
                string directoryPath = Path.Combine(Application.StartupPath, m_MemesDirectoryPath);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string filePath = Path.Combine(Application.StartupPath, saveMemeFileName);

                using (Bitmap memeImage = new Bitmap(MemePictureBox.Width, MemePictureBox.Height))
                {
                    MemePictureBox.DrawToBitmap(memeImage, new Rectangle(0, 0, MemePictureBox.Width, MemePictureBox.Height));
                    memeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                }

                User.PostPhoto(filePath);
                MessageBox.Show("Meme uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
