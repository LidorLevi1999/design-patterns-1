using CefSharp.DevTools.Page;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MemeCreatorForm : Form
    {
        private string TopMemeText { get; set; } = String.Empty;
        private string BottomMemeText { get; set; } = String.Empty;
        private Color TopTextColor { get; set; } = Color.Black;
        private Color BottomTextColor { get; set; } = Color.Black;
        private readonly string r_DefaultFont = "Arial";
        private User User { get; set; }
        public MemeCreatorForm(Image selectedImage, User user)
        {
            this.User = user;
            InitializeComponent();
            InitializeFontComboBoxesWithData();
            setupPictureBox(selectedImage);
        }

        private void InitializeFontComboBoxesWithData()
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

        private void setupPictureBox(Image selectedImage)
        {
            this.MemePictureBox.Image = selectedImage;
        }

        private void bottomTextInputBox_TextChanged(object sender, EventArgs e)
        {
            this.BottomMemeText = bottomTextInputBox.Text;
            MemePictureBox.Invalidate();
        }

        private void topTextInputBox_TextChanged(object sender, EventArgs e)
        {
            this.TopMemeText = topTextInputBox.Text;
            MemePictureBox.Invalidate();
        }

        private void MemePictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var imageSize = MemePictureBox.Image.Size;
            string topFontName = topMemeTextFontComboBox.SelectedItem?.ToString() ?? r_DefaultFont;
            string bottomFontName = bottomMemeTextFontComboBox.SelectedItem?.ToString() ?? r_DefaultFont;
            using (Font topFont = new Font(topFontName, 24, FontStyle.Bold))
            using (Font bottomFont = new Font(bottomFontName, 24, FontStyle.Bold))
            {
                DrawCenteredText(g, TopMemeText, topFont, TopTextColor, imageSize, true);
                DrawCenteredText(g, BottomMemeText, bottomFont, BottomTextColor, imageSize, false);
            }
        }

        private void DrawCenteredText(Graphics g, string text, Font font, Color color, Size imageSize, bool isTopText)
        {
            using (Brush brush = new SolidBrush(color))
            {
                SizeF textSize = g.MeasureString(text, font);
                float x;

                // Adjust initial x position based on text length and shift it left by 20 pixels
                x = (imageSize.Width - textSize.Width) / 2 - 30;

                if (isTopText)
                {

                    float y = 20; 
                    g.DrawString(text, font, brush, new PointF(x, y));
                }
                else
                {
                    float y = 340;
                    g.DrawString(text, font, brush, new PointF(x, y));
                }
            }
        }



        private void colorPickerMemeTopTextButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                TopTextColor = colorDialog.Color;
                MemePictureBox.Invalidate();
            }
        }

        private void colorPickerMemeBottomTextButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BottomTextColor = colorDialog.Color;
                MemePictureBox.Invalidate();
            }
        }

        private void topMemeTextFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemePictureBox.Invalidate();
        }

        private void bottomMemeTextFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemePictureBox.Invalidate();
        }

        private void uploadMeme_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Capture the current image from the PictureBox
                var memeImage = new Bitmap(MemePictureBox.Width, MemePictureBox.Height);
                MemePictureBox.DrawToBitmap(memeImage, new Rectangle(0, 0, MemePictureBox.Width, MemePictureBox.Height));

                // 2. Save the image to the disk in the same application location
                string filePath = Path.Combine(Application.StartupPath, "meme.png");
                memeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                // 3. Upload the image using User.PostPhoto
                User.PostPhoto(filePath);

                MessageBox.Show("Meme uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Close the form after uploading
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
