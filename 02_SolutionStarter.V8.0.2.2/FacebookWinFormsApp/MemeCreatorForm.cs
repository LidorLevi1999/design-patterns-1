using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MemeCreatorForm : Form
    {
        private Label selectedLabel = null;

        public MemeCreatorForm()
        {
            InitializeComponent();
            setupLabels();
        }

        private void setupLabels()
        {
            Label label1 = new Label { Text = "Top Text", AutoSize = false, Size = new Size(100, 30), Location = new Point(50, 50), BorderStyle = BorderStyle.FixedSingle };
            Label label2 = new Label { Text = "Bottom Text", AutoSize = false, Size = new Size(100, 30), Location = new Point(50, 150), BorderStyle = BorderStyle.FixedSingle };

            this.Controls.Add(label1);
            this.Controls.Add(label2);

            // Allow moving
            label1.MouseDown += label_MouseDown;
            label1.MouseMove += label_MouseMove;
            label1.MouseUp += label_MouseUp;

            label2.MouseDown += label_MouseDown;
            label2.MouseMove += label_MouseMove;
            label2.MouseUp += label_MouseUp;

            // Double-click to edit text
            label1.DoubleClick += label_DoubleClick;
            label2.DoubleClick += label_DoubleClick;

            // Allow resizing
            label1.MouseDown += label_MouseDownForResize;
            label1.MouseMove += label_MouseMoveForResize;
            label1.MouseUp += label_MouseUpForResize;

            label2.MouseDown += label_MouseDownForResize;
            label2.MouseMove += label_MouseMoveForResize;
            label2.MouseUp += label_MouseUpForResize;
        }

        // Methods to move the labels
        private Point mouseDownLocation;
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is Label label)
            {
                label.Left += e.X - mouseDownLocation.X;
                label.Top += e.Y - mouseDownLocation.Y;
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            selectedLabel = sender as Label;
        }

        // Methods to resize the labels
        private bool resizing = false;
        private void label_MouseDownForResize(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                resizing = true;
                selectedLabel = sender as Label;
            }
        }

        private void label_MouseMoveForResize(object sender, MouseEventArgs e)
        {
            if (resizing && selectedLabel != null)
            {
                selectedLabel.Width += e.X;
                selectedLabel.Height += e.Y;
            }
        }

        private void label_MouseUpForResize(object sender, MouseEventArgs e)
        {
            resizing = false;
        }

        // Method to edit label text
        private void label_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                string newText = Microsoft.VisualBasic.Interaction.InputBox("Enter new text:", "Edit Text", label.Text);
                if (!string.IsNullOrEmpty(newText))
                {
                    label.Text = newText;
                }
            }
        }

        // Method to save the meme as an image
        private void saveMemeButton_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("meme.png", ImageFormat.Png);
            }
        }



    }

}
