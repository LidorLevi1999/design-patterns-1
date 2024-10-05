﻿namespace BasicFacebookFeatures
{
    partial class PictureDetailsForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label likeCountLabel;
            System.Windows.Forms.Label photoNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureDetailsForm));
            this.picturesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureIndexListBox = new System.Windows.Forms.ListBox();
            this.photoProxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picDescriptionLabel = new System.Windows.Forms.Label();
            this.picLikeCountLabel = new System.Windows.Forms.Label();
            this.photoNameLabel1 = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            likeCountLabel = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingNavigator)).BeginInit();
            this.picturesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoProxyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(26, 326);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(147, 25);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(26, 368);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(126, 25);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // likeCountLabel
            // 
            likeCountLabel.AutoSize = true;
            likeCountLabel.Location = new System.Drawing.Point(26, 404);
            likeCountLabel.Name = "likeCountLabel";
            likeCountLabel.Size = new System.Drawing.Size(121, 25);
            likeCountLabel.TabIndex = 4;
            likeCountLabel.Text = "Like Count:";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(26, 439);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(136, 25);
            photoNameLabel.TabIndex = 6;
            photoNameLabel.Text = "Photo Name:";
            // 
            // picturesBindingNavigator
            // 
            this.picturesBindingNavigator.AddNewItem = null;
            this.picturesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.picturesBindingNavigator.DeleteItem = null;
            this.picturesBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.picturesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.picturesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.picturesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.picturesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.picturesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.picturesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.picturesBindingNavigator.Name = "picturesBindingNavigator";
            this.picturesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.picturesBindingNavigator.Size = new System.Drawing.Size(1037, 42);
            this.picturesBindingNavigator.TabIndex = 1;
            this.picturesBindingNavigator.Text = "picturesBindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // pictureIndexListBox
            // 
            this.pictureIndexListBox.FormattingEnabled = true;
            this.pictureIndexListBox.ItemHeight = 25;
            this.pictureIndexListBox.Location = new System.Drawing.Point(786, 82);
            this.pictureIndexListBox.Name = "pictureIndexListBox";
            this.pictureIndexListBox.Size = new System.Drawing.Size(120, 304);
            this.pictureIndexListBox.TabIndex = 2;
            // 
            // photoProxyBindingSource
            // 
            this.photoProxyBindingSource.DataSource = typeof(BasicFacebookFeatures.PhotoProxy);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.picDescriptionLabel);
            this.panel1.Controls.Add(likeCountLabel);
            this.panel1.Controls.Add(this.picLikeCountLabel);
            this.panel1.Controls.Add(photoNameLabel);
            this.panel1.Controls.Add(this.photoNameLabel1);
            this.panel1.Location = new System.Drawing.Point(27, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 531);
            this.panel1.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoProxyBindingSource, "Photo.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(17, 17);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(314, 287);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 9;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photoProxyBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(179, 326);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // picDescriptionLabel
            // 
            this.picDescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoProxyBindingSource, "Description", true));
            this.picDescriptionLabel.Location = new System.Drawing.Point(179, 368);
            this.picDescriptionLabel.Name = "picDescriptionLabel";
            this.picDescriptionLabel.Size = new System.Drawing.Size(200, 23);
            this.picDescriptionLabel.TabIndex = 3;
            this.picDescriptionLabel.Text = "label1";
            // 
            // picLikeCountLabel
            // 
            this.picLikeCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoProxyBindingSource, "LikeCount", true));
            this.picLikeCountLabel.Location = new System.Drawing.Point(179, 404);
            this.picLikeCountLabel.Name = "picLikeCountLabel";
            this.picLikeCountLabel.Size = new System.Drawing.Size(200, 23);
            this.picLikeCountLabel.TabIndex = 5;
            this.picLikeCountLabel.Text = "label1";
            // 
            // photoNameLabel1
            // 
            this.photoNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoProxyBindingSource, "PhotoName", true));
            this.photoNameLabel1.Location = new System.Drawing.Point(179, 439);
            this.photoNameLabel1.Name = "photoNameLabel1";
            this.photoNameLabel1.Size = new System.Drawing.Size(200, 23);
            this.photoNameLabel1.TabIndex = 7;
            this.photoNameLabel1.Text = "label1";
            // 
            // PictureDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureIndexListBox);
            this.Controls.Add(this.picturesBindingNavigator);
            this.Name = "PictureDetailsForm";
            this.Text = "Picture Details Form";
            this.Load += new System.EventHandler(this.PictureDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingNavigator)).EndInit();
            this.picturesBindingNavigator.ResumeLayout(false);
            this.picturesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoProxyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator picturesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ListBox pictureIndexListBox;
        private System.Windows.Forms.BindingSource photoProxyBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.Label picDescriptionLabel;
        private System.Windows.Forms.Label picLikeCountLabel;
        private System.Windows.Forms.Label photoNameLabel1;
    }
}