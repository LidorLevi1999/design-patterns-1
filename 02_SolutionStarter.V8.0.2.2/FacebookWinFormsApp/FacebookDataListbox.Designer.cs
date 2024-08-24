namespace BasicFacebookFeatures
{
    partial class FacebookDataListbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.AccessibleName = "Listbox";
            this.GroupBox.Controls.Add(this.PictureBox);
            this.GroupBox.Controls.Add(this.ListBox);
            this.GroupBox.Location = new System.Drawing.Point(16, 20);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(521, 392);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "groupBox1";
            // 
            // PictureBox
            // 
            this.PictureBox.AccessibleName = "Image";
            this.PictureBox.Location = new System.Drawing.Point(403, 278);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(112, 96);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(17, 32);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(498, 342);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // FacebookDataListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.Name = "FacebookDataListbox";
            this.Size = new System.Drawing.Size(554, 439);
            this.Load += new System.EventHandler(this.FacebookDataListbox_Load);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox;
        internal System.Windows.Forms.ListBox ListBox;
        internal System.Windows.Forms.PictureBox PictureBox;
    }
}
