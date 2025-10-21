namespace FNAF_2D_Engine
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.PictureBox();
            this.pbVersion = new System.Windows.Forms.PictureBox();
            this.btnGitHub = new System.Windows.Forms.PictureBox();
            this.pbCredits = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(-114, -11);
            this.pbMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(1188, 606);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(314, 3);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(248, 393);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGame.Image")));
            this.btnNewGame.Location = new System.Drawing.Point(10, 151);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(250, 33);
            this.btnNewGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Click += new System.EventHandler(this.PlayNewspaperIntro);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.btnNewGame_MouseEnter);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.btnNewGame_MouseLeave);
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.Location = new System.Drawing.Point(9, 215);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(250, 33);
            this.btnContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContinue.TabIndex = 17;
            this.btnContinue.TabStop = false;
            this.btnContinue.Click += new System.EventHandler(this.PlayNewspaperIntro);
            this.btnContinue.MouseEnter += new System.EventHandler(this.btnContinue_MouseEnter);
            this.btnContinue.MouseLeave += new System.EventHandler(this.btnContinue_MouseLeave);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(9, 329);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(106, 41);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuit.TabIndex = 18;
            this.btnQuit.TabStop = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pbVersion
            // 
            this.pbVersion.Image = ((System.Drawing.Image)(resources.GetObject("pbVersion.Image")));
            this.pbVersion.Location = new System.Drawing.Point(10, 527);
            this.pbVersion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVersion.Name = "pbVersion";
            this.pbVersion.Size = new System.Drawing.Size(79, 32);
            this.pbVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVersion.TabIndex = 19;
            this.pbVersion.TabStop = false;
            // 
            // btnGitHub
            // 
            this.btnGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.Location = new System.Drawing.Point(631, 285);
            this.btnGitHub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(257, 153);
            this.btnGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGitHub.TabIndex = 20;
            this.btnGitHub.TabStop = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // pbCredits
            // 
            this.pbCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCredits.Image = ((System.Drawing.Image)(resources.GetObject("pbCredits.Image")));
            this.pbCredits.Location = new System.Drawing.Point(468, 520);
            this.pbCredits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCredits.Name = "pbCredits";
            this.pbCredits.Size = new System.Drawing.Size(341, 24);
            this.pbCredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCredits.TabIndex = 22;
            this.pbCredits.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.pbCredits);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.pbVersion);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "MainMenu";
            this.Text = "Five Nights At Freddy\'s 1 Remake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pbMenu;
        internal System.Windows.Forms.PictureBox pbLogo;
        internal System.Windows.Forms.PictureBox btnNewGame;
        internal System.Windows.Forms.PictureBox btnContinue;
        internal System.Windows.Forms.PictureBox btnQuit;
        internal System.Windows.Forms.PictureBox pbVersion;
        internal System.Windows.Forms.PictureBox btnGitHub;
        internal System.Windows.Forms.PictureBox pbCredits;
    }
}