namespace BasicFacebookFeatures
{
    partial class MemeCreatorForm
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
            this.MemePictureBox = new System.Windows.Forms.PictureBox();
            this.topMemeLabel = new System.Windows.Forms.Label();
            this.bottomMemeLabel = new System.Windows.Forms.Label();
            this.topTextInputBox = new System.Windows.Forms.TextBox();
            this.topMemeTextLabel = new System.Windows.Forms.Label();
            this.bottomTextInputBox = new System.Windows.Forms.TextBox();
            this.bottomMemeTextLabel = new System.Windows.Forms.Label();
            this.colorPickerMemeTopTextButton = new System.Windows.Forms.Button();
            this.colorPickerMemeBottomTextButton = new System.Windows.Forms.Button();
            this.topMemeTextFontComboBox = new System.Windows.Forms.ComboBox();
            this.bottomMemeTextFontComboBox = new System.Windows.Forms.ComboBox();
            this.topMemeTextFontLabel = new System.Windows.Forms.Label();
            this.bottomMemeTextFontLabel = new System.Windows.Forms.Label();
            this.uploadMeme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MemePictureBox
            // 
            this.MemePictureBox.Location = new System.Drawing.Point(206, 23);
            this.MemePictureBox.Name = "MemePictureBox";
            this.MemePictureBox.Size = new System.Drawing.Size(400, 400);
            this.MemePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MemePictureBox.TabIndex = 0;
            this.MemePictureBox.TabStop = false;
            this.MemePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.memePictureBox_Paint);
            // 
            // topMemeLabel
            // 
            this.topMemeLabel.AutoSize = true;
            this.topMemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.topMemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMemeLabel.Location = new System.Drawing.Point(361, 60);
            this.topMemeLabel.Name = "topMemeLabel";
            this.topMemeLabel.Size = new System.Drawing.Size(0, 31);
            this.topMemeLabel.TabIndex = 1;
            // 
            // bottomMemeLabel
            // 
            this.bottomMemeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomMemeLabel.AutoSize = true;
            this.bottomMemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bottomMemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMemeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bottomMemeLabel.Location = new System.Drawing.Point(361, 361);
            this.bottomMemeLabel.Name = "bottomMemeLabel";
            this.bottomMemeLabel.Size = new System.Drawing.Size(0, 31);
            this.bottomMemeLabel.TabIndex = 2;
            // 
            // topTextInputBox
            // 
            this.topTextInputBox.Location = new System.Drawing.Point(12, 60);
            this.topTextInputBox.MaxLength = 20;
            this.topTextInputBox.Name = "topTextInputBox";
            this.topTextInputBox.Size = new System.Drawing.Size(176, 20);
            this.topTextInputBox.TabIndex = 3;
            this.topTextInputBox.TextChanged += new System.EventHandler(this.topTextInputBox_TextChanged);
            // 
            // topMemeTextLabel
            // 
            this.topMemeTextLabel.AutoSize = true;
            this.topMemeTextLabel.Location = new System.Drawing.Point(9, 44);
            this.topMemeTextLabel.Name = "topMemeTextLabel";
            this.topMemeTextLabel.Size = new System.Drawing.Size(141, 13);
            this.topMemeTextLabel.TabIndex = 4;
            this.topMemeTextLabel.Text = "Enter the text for the top text";
            // 
            // bottomTextInputBox
            // 
            this.bottomTextInputBox.Location = new System.Drawing.Point(12, 186);
            this.bottomTextInputBox.MaxLength = 20;
            this.bottomTextInputBox.Name = "bottomTextInputBox";
            this.bottomTextInputBox.Size = new System.Drawing.Size(176, 20);
            this.bottomTextInputBox.TabIndex = 5;
            this.bottomTextInputBox.TextChanged += new System.EventHandler(this.bottomTextInputBox_TextChanged);
            // 
            // bottomMemeTextLabel
            // 
            this.bottomMemeTextLabel.AutoSize = true;
            this.bottomMemeTextLabel.Location = new System.Drawing.Point(9, 170);
            this.bottomMemeTextLabel.Name = "bottomMemeTextLabel";
            this.bottomMemeTextLabel.Size = new System.Drawing.Size(158, 13);
            this.bottomMemeTextLabel.TabIndex = 6;
            this.bottomMemeTextLabel.Text = "Enter the text for the bottom text";
            // 
            // colorPickerMemeTopTextButton
            // 
            this.colorPickerMemeTopTextButton.Location = new System.Drawing.Point(12, 88);
            this.colorPickerMemeTopTextButton.Name = "colorPickerMemeTopTextButton";
            this.colorPickerMemeTopTextButton.Size = new System.Drawing.Size(176, 23);
            this.colorPickerMemeTopTextButton.TabIndex = 7;
            this.colorPickerMemeTopTextButton.Text = "Selecet Color for top text";
            this.colorPickerMemeTopTextButton.UseVisualStyleBackColor = true;
            this.colorPickerMemeTopTextButton.Click += new System.EventHandler(this.colorPickerMemeTopTextButton_Click);
            // 
            // colorPickerMemeBottomTextButton
            // 
            this.colorPickerMemeBottomTextButton.Location = new System.Drawing.Point(12, 212);
            this.colorPickerMemeBottomTextButton.Name = "colorPickerMemeBottomTextButton";
            this.colorPickerMemeBottomTextButton.Size = new System.Drawing.Size(176, 23);
            this.colorPickerMemeBottomTextButton.TabIndex = 8;
            this.colorPickerMemeBottomTextButton.Text = "Select Color for bottom text";
            this.colorPickerMemeBottomTextButton.UseVisualStyleBackColor = true;
            this.colorPickerMemeBottomTextButton.Click += new System.EventHandler(this.colorPickerMemeBottomTextButton_Click);
            // 
            // topMemeTextFontComboBox
            // 
            this.topMemeTextFontComboBox.FormattingEnabled = true;
            this.topMemeTextFontComboBox.Location = new System.Drawing.Point(12, 130);
            this.topMemeTextFontComboBox.Name = "topMemeTextFontComboBox";
            this.topMemeTextFontComboBox.Size = new System.Drawing.Size(176, 21);
            this.topMemeTextFontComboBox.TabIndex = 9;
            this.topMemeTextFontComboBox.SelectedIndexChanged += new System.EventHandler(this.topMemeTextFontComboBox_SelectedIndexChanged);
            // 
            // bottomMemeTextFontComboBox
            // 
            this.bottomMemeTextFontComboBox.FormattingEnabled = true;
            this.bottomMemeTextFontComboBox.Location = new System.Drawing.Point(12, 253);
            this.bottomMemeTextFontComboBox.Name = "bottomMemeTextFontComboBox";
            this.bottomMemeTextFontComboBox.Size = new System.Drawing.Size(176, 21);
            this.bottomMemeTextFontComboBox.TabIndex = 10;
            this.bottomMemeTextFontComboBox.SelectedIndexChanged += new System.EventHandler(this.bottomMemeTextFontComboBox_SelectedIndexChanged);
            // 
            // topMemeTextFontLabel
            // 
            this.topMemeTextFontLabel.AutoSize = true;
            this.topMemeTextFontLabel.Location = new System.Drawing.Point(9, 114);
            this.topMemeTextFontLabel.Name = "topMemeTextFontLabel";
            this.topMemeTextFontLabel.Size = new System.Drawing.Size(129, 13);
            this.topMemeTextFontLabel.TabIndex = 11;
            this.topMemeTextFontLabel.Text = "Select font for the top text";
            // 
            // bottomMemeTextFontLabel
            // 
            this.bottomMemeTextFontLabel.AutoSize = true;
            this.bottomMemeTextFontLabel.Location = new System.Drawing.Point(10, 237);
            this.bottomMemeTextFontLabel.Name = "bottomMemeTextFontLabel";
            this.bottomMemeTextFontLabel.Size = new System.Drawing.Size(146, 13);
            this.bottomMemeTextFontLabel.TabIndex = 12;
            this.bottomMemeTextFontLabel.Text = "Select font for the bottom text";
            // 
            // uploadMeme
            // 
            this.uploadMeme.Location = new System.Drawing.Point(13, 399);
            this.uploadMeme.Name = "uploadMeme";
            this.uploadMeme.Size = new System.Drawing.Size(175, 23);
            this.uploadMeme.TabIndex = 13;
            this.uploadMeme.Text = "Save and upload your meme!";
            this.uploadMeme.UseVisualStyleBackColor = true;
            this.uploadMeme.Click += new System.EventHandler(this.uploadMeme_Click);
            // 
            // MemeCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadMeme);
            this.Controls.Add(this.bottomMemeTextFontLabel);
            this.Controls.Add(this.topMemeTextFontLabel);
            this.Controls.Add(this.bottomMemeTextFontComboBox);
            this.Controls.Add(this.topMemeTextFontComboBox);
            this.Controls.Add(this.colorPickerMemeBottomTextButton);
            this.Controls.Add(this.colorPickerMemeTopTextButton);
            this.Controls.Add(this.bottomMemeTextLabel);
            this.Controls.Add(this.bottomTextInputBox);
            this.Controls.Add(this.topMemeTextLabel);
            this.Controls.Add(this.topTextInputBox);
            this.Controls.Add(this.bottomMemeLabel);
            this.Controls.Add(this.topMemeLabel);
            this.Controls.Add(this.MemePictureBox);
            this.Name = "MemeCreatorForm";
            this.Text = "MemeCreatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.MemePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MemePictureBox;
        private System.Windows.Forms.Label topMemeLabel;
        private System.Windows.Forms.Label bottomMemeLabel;
        private System.Windows.Forms.TextBox topTextInputBox;
        private System.Windows.Forms.Label topMemeTextLabel;
        private System.Windows.Forms.TextBox bottomTextInputBox;
        private System.Windows.Forms.Label bottomMemeTextLabel;
        private System.Windows.Forms.Button colorPickerMemeTopTextButton;
        private System.Windows.Forms.Button colorPickerMemeBottomTextButton;
        private System.Windows.Forms.ComboBox topMemeTextFontComboBox;
        private System.Windows.Forms.ComboBox bottomMemeTextFontComboBox;
        private System.Windows.Forms.Label topMemeTextFontLabel;
        private System.Windows.Forms.Label bottomMemeTextFontLabel;
        private System.Windows.Forms.Button uploadMeme;
    }
}