namespace BasicFacebookFeatures
{
    partial class PicturesGallery
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.galleryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // galleryFlowLayoutPanel
            // 
            this.galleryFlowLayoutPanel.AccessibleName = "galleryFlowLayoutPanel";
            this.galleryFlowLayoutPanel.AutoScroll = true;
            this.galleryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.galleryFlowLayoutPanel.Name = "galleryFlowLayoutPanel";
            this.galleryFlowLayoutPanel.Size = new System.Drawing.Size(1263, 827);
            this.galleryFlowLayoutPanel.TabIndex = 0;
            // 
            // PicturesGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 827);
            this.Controls.Add(this.galleryFlowLayoutPanel);
            this.Name = "PicturesGallery";
            this.Text = "Pictures Gallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel galleryFlowLayoutPanel;
    }
}