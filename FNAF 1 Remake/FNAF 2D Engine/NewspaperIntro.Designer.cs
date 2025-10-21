namespace FNAF_2D_Engine
{
    partial class NewspaperIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewspaperIntro));
            this.pbNewspaper = new System.Windows.Forms.PictureBox();
            this.pbNight1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewspaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNight1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNewspaper
            // 
            this.pbNewspaper.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNewspaper.Image = ((System.Drawing.Image)(resources.GetObject("pbNewspaper.Image")));
            this.pbNewspaper.Location = new System.Drawing.Point(189, 87);
            this.pbNewspaper.Name = "pbNewspaper";
            this.pbNewspaper.Size = new System.Drawing.Size(964, 535);
            this.pbNewspaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewspaper.TabIndex = 25;
            this.pbNewspaper.TabStop = false;
            // 
            // pbNight1
            // 
            this.pbNight1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNight1.Image = ((System.Drawing.Image)(resources.GetObject("pbNight1.Image")));
            this.pbNight1.Location = new System.Drawing.Point(483, 241);
            this.pbNight1.Name = "pbNight1";
            this.pbNight1.Size = new System.Drawing.Size(295, 117);
            this.pbNight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNight1.TabIndex = 26;
            this.pbNight1.TabStop = false;
            this.pbNight1.Visible = false;
            // 
            // NewspaperIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pbNight1);
            this.Controls.Add(this.pbNewspaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "NewspaperIntro";
            this.Text = "Five Nights At Freddy\'s 1 Remake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewspaperIntro_FormClosing);
            this.Load += new System.EventHandler(this.NewspaperIntro_Load);
            this.Shown += new System.EventHandler(this.NewspaperIntro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewspaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNight1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pbNewspaper;
        internal System.Windows.Forms.PictureBox pbNight1;
    }
}