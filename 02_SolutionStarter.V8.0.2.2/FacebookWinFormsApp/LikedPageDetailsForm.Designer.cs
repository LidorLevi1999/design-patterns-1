namespace BasicFacebookFeatures
{
    partial class LikedPageDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.likedPageProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.likedPageName = new System.Windows.Forms.Label();
            this.likedPageDescription = new System.Windows.Forms.Label();
            this.likedByNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.likedPageProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPageProfilePictureBox
            // 
            this.likedPageProfilePictureBox.AccessibleName = "likedPageProfilePictureBox";
            this.likedPageProfilePictureBox.Location = new System.Drawing.Point(28, 47);
            this.likedPageProfilePictureBox.Name = "likedPageProfilePictureBox";
            this.likedPageProfilePictureBox.Size = new System.Drawing.Size(282, 261);
            this.likedPageProfilePictureBox.TabIndex = 0;
            this.likedPageProfilePictureBox.TabStop = false;
            // 
            // likedPageName
            // 
            this.likedPageName.AccessibleName = "likedPageName";
            this.likedPageName.AutoSize = true;
            this.likedPageName.Location = new System.Drawing.Point(344, 47);
            this.likedPageName.Name = "likedPageName";
            this.likedPageName.Size = new System.Drawing.Size(163, 25);
            this.likedPageName.TabIndex = 1;
            this.likedPageName.Text = "likedPageName";
            // 
            // likedPageDescription
            // 
            this.likedPageDescription.AccessibleName = "likedPageDescription";
            this.likedPageDescription.AutoSize = true;
            this.likedPageDescription.Location = new System.Drawing.Point(349, 172);
            this.likedPageDescription.Name = "likedPageDescription";
            this.likedPageDescription.Size = new System.Drawing.Size(215, 25);
            this.likedPageDescription.TabIndex = 2;
            this.likedPageDescription.Text = "likedPageDescription";
            // 
            // likedByNum
            // 
            this.likedByNum.AccessibleName = "likedByNum";
            this.likedByNum.AutoSize = true;
            this.likedByNum.Location = new System.Drawing.Point(28, 354);
            this.likedByNum.Name = "likedByNum";
            this.likedByNum.Size = new System.Drawing.Size(126, 25);
            this.likedByNum.TabIndex = 3;
            this.likedByNum.Text = "likedByNum";
            // 
            // LikedPageDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 670);
            this.Controls.Add(this.likedByNum);
            this.Controls.Add(this.likedPageDescription);
            this.Controls.Add(this.likedPageName);
            this.Controls.Add(this.likedPageProfilePictureBox);
            this.Name = "LikedPageDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.likedPageProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox likedPageProfilePictureBox;
        private System.Windows.Forms.Label likedPageName;
        private System.Windows.Forms.Label likedPageDescription;
        private System.Windows.Forms.Label likedByNum;
    }
}