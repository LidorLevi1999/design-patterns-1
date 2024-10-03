using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.rememberMeCheckbox = new System.Windows.Forms.CheckBox();
            this.introText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.loginTabPage.SuspendLayout();
            this.generalTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabPage
            // 
            this.loginTabPage.AccessibleName = "loginTabPage";
            this.loginTabPage.Controls.Add(this.rememberMeCheckbox);
            this.loginTabPage.Controls.Add(this.introText);
            this.loginTabPage.Controls.Add(this.buttonLogin);
            this.loginTabPage.Location = new System.Drawing.Point(4, 28);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(658, 337);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            this.loginTabPage.UseVisualStyleBackColor = true;
            this.loginTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rememberMeCheckbox
            // 
            this.rememberMeCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberMeCheckbox.Location = new System.Drawing.Point(253, 196);
            this.rememberMeCheckbox.Name = "rememberMeCheckbox";
            this.rememberMeCheckbox.Size = new System.Drawing.Size(155, 23);
            this.rememberMeCheckbox.TabIndex = 38;
            this.rememberMeCheckbox.Text = "Keep me logged in";
            this.rememberMeCheckbox.UseVisualStyleBackColor = true;
            this.rememberMeCheckbox.CheckedChanged += new System.EventHandler(this.rememberMeCheckbox_CheckedChanged);
            // 
            // introText
            // 
            this.introText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.introText.Location = new System.Drawing.Point(133, 101);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(399, 19);
            this.introText.TabIndex = 37;
            this.introText.Text = "Welcome to our Design Patterns WinForms Facebook app !";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(129, 124);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(403, 65);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // generalTabControl
            // 
            this.generalTabControl.AccessibleName = "generalTabControl";
            this.generalTabControl.Controls.Add(this.loginTabPage);
            this.generalTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalTabControl.Location = new System.Drawing.Point(0, 0);
            this.generalTabControl.Name = "generalTabControl";
            this.generalTabControl.SelectedIndex = 0;
            this.generalTabControl.Size = new System.Drawing.Size(666, 369);
            this.generalTabControl.TabIndex = 54;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 369);
            this.Controls.Add(this.generalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_OnFormClosing);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.loginTabPage.ResumeLayout(false);
            this.generalTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void HideTab(TabPage tabPage)
        {
            if (generalTabControl.TabPages.Contains(tabPage))
            {
                generalTabControl.TabPages.Remove(tabPage);
            }
        }

        private void ShowTab(TabPage tabPage)
        {
            if (!generalTabControl.TabPages.Contains(tabPage))
            {
                generalTabControl.TabPages.Add(tabPage);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        #endregion
        private TabPage loginTabPage;
        private TabPage feedTabPage;
        private TabPage profileTabPage;
        private TabPage friendsTabPage;
        private Button buttonLogin;
        private TabControl generalTabControl;
        private Label introText;
        private CheckBox rememberMeCheckbox;
    }
}

