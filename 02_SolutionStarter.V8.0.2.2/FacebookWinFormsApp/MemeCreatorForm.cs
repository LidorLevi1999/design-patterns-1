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
        internal static string m_MemesDiredtoryPath = "memes";
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
            InitializeFontComboBoxesWithData();
            setupPictureBox(i_SelectedImage);
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

        private void DrawCenteredText(Graphics i_Graphic, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText)
        {
            using (Brush brush = new SolidBrush(i_Color))
            {
                SizeF textSize = i_Graphic.MeasureString(i_Text, i_Font);
                float xAxis = (i_ImageSize.Width -textSize.Width) / 2 - 30;
                float yAxis = i_IsTopText ? 20 : 340;
                
                i_Graphic.DrawString(i_Text, i_Font, brush, new PointF(xAxis, yAxis));

            }
        }



        private void colorPickerMemeTopTextButton_Click(object sender, EventArgs e)
        {
            ColorPickerButtonClicked(true);
        }

        private void colorPickerMemeBottomTextButton_Click(object sender, EventArgs e)
        {
            ColorPickerButtonClicked(false);
        }

        private void ColorPickerButtonClicked (bool i_IsTopText)
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
            string saveMemeFileName = $@"{m_MemesDiredtoryPath}\meme_{timestampId}.png";

            try
            {
                string directoryPath = Path.Combine(Application.StartupPath, m_MemesDiredtoryPath);
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
