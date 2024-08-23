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
            this.likedPageProfilePicture = new System.Windows.Forms.PictureBox();
            this.pageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.likedPageProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPageProfilePicture
            // 
            this.likedPageProfilePicture.AccessibleName = "likedPageProfilePicture";
            this.likedPageProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.likedPageProfilePicture.Name = "likedPageProfilePicture";
            this.likedPageProfilePicture.Size = new System.Drawing.Size(170, 203);
            this.likedPageProfilePicture.TabIndex = 0;
            this.likedPageProfilePicture.TabStop = false;
            // 
            // pageName
            // 
            this.pageName.AccessibleName = "pageName";
            this.pageName.AutoSize = true;
            this.pageName.Location = new System.Drawing.Point(221, 38);
            this.pageName.Name = "pageName";
            this.pageName.Size = new System.Drawing.Size(0, 25);
            this.pageName.TabIndex = 1;
            this.pageName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LikedPageDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.pageName);
            this.Controls.Add(this.likedPageProfilePicture);
            this.Name = "LikedPageDetailsForm";
            this.Text = "LikedPageDetailsForm";
            this.Load += new System.EventHandler(this.LikedPageDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.likedPageProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox likedPageProfilePicture;
        private System.Windows.Forms.Label pageName;
    }
}