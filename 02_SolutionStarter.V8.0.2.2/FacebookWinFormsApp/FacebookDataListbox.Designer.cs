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
            this.category = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.AccessibleName = "Listbox";
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.category);
            this.GroupBox.Controls.Add(this.searchTextBox);
            this.GroupBox.Controls.Add(this.loadDataButton);
            this.GroupBox.Controls.Add(this.PictureBox);
            this.GroupBox.Controls.Add(this.ListBox);
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(350, 350);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(6, 2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(95, 25);
            this.category.TabIndex = 4;
            this.category.Text = "category";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(0, 30);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(147, 31);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(153, 23);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(139, 34);
            this.loadDataButton.TabIndex = 2;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.AccessibleName = "Image";
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(190, 245);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(59, 55);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 25;
            this.ListBox.Location = new System.Drawing.Point(0, 60);
            this.ListBox.Name = "ListBox";
            this.ListBox.ScrollAlwaysVisible = true;
            this.ListBox.Size = new System.Drawing.Size(285, 229);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // FacebookDataListbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.GroupBox);
            this.Name = "FacebookDataListbox";
            this.Size = new System.Drawing.Size(328, 300);
            this.Load += new System.EventHandler(this.FacebookDataListbox_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox;
        internal System.Windows.Forms.ListBox ListBox;
        internal System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label category;
    }
}
