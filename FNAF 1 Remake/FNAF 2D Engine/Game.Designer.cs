
using System.Windows.Forms;

namespace FNAF_2D_Engine
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbOffice = new System.Windows.Forms.PictureBox();
            this.lblDebugMenu = new System.Windows.Forms.Label();
            this.buttonsR = new System.Windows.Forms.PictureBox();
            this.buttonsL = new System.Windows.Forms.PictureBox();
            this.btnDoorL = new System.Windows.Forms.Label();
            this.btnLightL = new System.Windows.Forms.Label();
            this.btnLightR = new System.Windows.Forms.Label();
            this.btnDoorR = new System.Windows.Forms.Label();
            this.rightDoor = new System.Windows.Forms.PictureBox();
            this.leftDoor = new System.Windows.Forms.PictureBox();
            this.btnCameras = new System.Windows.Forms.PictureBox();
            this.btnFreddysNose = new System.Windows.Forms.Panel();
            this.cameraScreen = new System.Windows.Forms.PictureBox();
            this.btnMuteCall = new System.Windows.Forms.PictureBox();
            this.pbMiniMap = new System.Windows.Forms.PictureBox();
            this.pbRedDot = new System.Windows.Forms.PictureBox();
            this.pbBorder = new System.Windows.Forms.PictureBox();
            this.pbAM = new System.Windows.Forms.PictureBox();
            this.pbNight1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMuteCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNight1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOffice
            // 
            this.pbOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbOffice.Image = ((System.Drawing.Image)(resources.GetObject("pbOffice.Image")));
            this.pbOffice.Location = new System.Drawing.Point(-111, -15);
            this.pbOffice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbOffice.Name = "pbOffice";
            this.pbOffice.Size = new System.Drawing.Size(1188, 606);
            this.pbOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOffice.TabIndex = 0;
            this.pbOffice.TabStop = false;
            this.pbOffice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // lblDebugMenu
            // 
            this.lblDebugMenu.AutoSize = true;
            this.lblDebugMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblDebugMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugMenu.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDebugMenu.Location = new System.Drawing.Point(885, 7);
            this.lblDebugMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebugMenu.Name = "lblDebugMenu";
            this.lblDebugMenu.Size = new System.Drawing.Size(292, 29);
            this.lblDebugMenu.TabIndex = 1;
            this.lblDebugMenu.Text = "DEBUG MENU: Not active";
            // 
            // buttonsR
            // 
            this.buttonsR.BackColor = System.Drawing.Color.Transparent;
            this.buttonsR.Image = ((System.Drawing.Image)(resources.GetObject("buttonsR.Image")));
            this.buttonsR.Location = new System.Drawing.Point(657, 242);
            this.buttonsR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsR.Name = "buttonsR";
            this.buttonsR.Size = new System.Drawing.Size(111, 284);
            this.buttonsR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonsR.TabIndex = 2;
            this.buttonsR.TabStop = false;
            this.buttonsR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // buttonsL
            // 
            this.buttonsL.BackColor = System.Drawing.Color.Transparent;
            this.buttonsL.Image = ((System.Drawing.Image)(resources.GetObject("buttonsL.Image")));
            this.buttonsL.Location = new System.Drawing.Point(501, 242);
            this.buttonsL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsL.Name = "buttonsL";
            this.buttonsL.Size = new System.Drawing.Size(111, 284);
            this.buttonsL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonsL.TabIndex = 3;
            this.buttonsL.TabStop = false;
            this.buttonsL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // btnDoorL
            // 
            this.btnDoorL.BackColor = System.Drawing.Color.White;
            this.btnDoorL.Location = new System.Drawing.Point(536, 302);
            this.btnDoorL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDoorL.Name = "btnDoorL";
            this.btnDoorL.Size = new System.Drawing.Size(47, 65);
            this.btnDoorL.TabIndex = 4;
            this.btnDoorL.Click += new System.EventHandler(this.DoorOrLightClicked);
            this.btnDoorL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // btnLightL
            // 
            this.btnLightL.BackColor = System.Drawing.Color.White;
            this.btnLightL.Location = new System.Drawing.Point(536, 393);
            this.btnLightL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLightL.Name = "btnLightL";
            this.btnLightL.Size = new System.Drawing.Size(47, 65);
            this.btnLightL.TabIndex = 5;
            this.btnLightL.Click += new System.EventHandler(this.DoorOrLightClicked);
            this.btnLightL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // btnLightR
            // 
            this.btnLightR.BackColor = System.Drawing.Color.White;
            this.btnLightR.Location = new System.Drawing.Point(686, 393);
            this.btnLightR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLightR.Name = "btnLightR";
            this.btnLightR.Size = new System.Drawing.Size(47, 65);
            this.btnLightR.TabIndex = 7;
            this.btnLightR.Click += new System.EventHandler(this.DoorOrLightClicked);
            this.btnLightR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // btnDoorR
            // 
            this.btnDoorR.BackColor = System.Drawing.Color.White;
            this.btnDoorR.Location = new System.Drawing.Point(686, 302);
            this.btnDoorR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDoorR.Name = "btnDoorR";
            this.btnDoorR.Size = new System.Drawing.Size(47, 65);
            this.btnDoorR.TabIndex = 6;
            this.btnDoorR.Click += new System.EventHandler(this.DoorOrLightClicked);
            this.btnDoorR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // rightDoor
            // 
            this.rightDoor.Image = ((System.Drawing.Image)(resources.GetObject("rightDoor.Image")));
            this.rightDoor.Location = new System.Drawing.Point(737, -15);
            this.rightDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightDoor.Name = "rightDoor";
            this.rightDoor.Size = new System.Drawing.Size(303, 599);
            this.rightDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDoor.TabIndex = 8;
            this.rightDoor.TabStop = false;
            this.rightDoor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // leftDoor
            // 
            this.leftDoor.Image = ((System.Drawing.Image)(resources.GetObject("leftDoor.Image")));
            this.leftDoor.Location = new System.Drawing.Point(9, -7);
            this.leftDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftDoor.Name = "leftDoor";
            this.leftDoor.Size = new System.Drawing.Size(285, 599);
            this.leftDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDoor.TabIndex = 9;
            this.leftDoor.TabStop = false;
            this.leftDoor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOffice_MouseMove);
            // 
            // btnCameras
            // 
            this.btnCameras.BackColor = System.Drawing.Color.Transparent;
            this.btnCameras.Image = ((System.Drawing.Image)(resources.GetObject("btnCameras.Image")));
            this.btnCameras.Location = new System.Drawing.Point(51, 508);
            this.btnCameras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCameras.Name = "btnCameras";
            this.btnCameras.Size = new System.Drawing.Size(795, 59);
            this.btnCameras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCameras.TabIndex = 10;
            this.btnCameras.TabStop = false;
            this.btnCameras.MouseEnter += new System.EventHandler(this.btnCameras_MouseEnter);
            this.btnCameras.MouseLeave += new System.EventHandler(this.btnCameras_MouseLeave);
            // 
            // btnFreddysNose
            // 
            this.btnFreddysNose.Location = new System.Drawing.Point(375, 172);
            this.btnFreddysNose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFreddysNose.Name = "btnFreddysNose";
            this.btnFreddysNose.Size = new System.Drawing.Size(32, 30);
            this.btnFreddysNose.TabIndex = 11;
            this.btnFreddysNose.Click += new System.EventHandler(this.btnFreddysNose_Click);
            // 
            // cameraScreen
            // 
            this.cameraScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cameraScreen.Image = ((System.Drawing.Image)(resources.GetObject("cameraScreen.Image")));
            this.cameraScreen.Location = new System.Drawing.Point(230, 257);
            this.cameraScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cameraScreen.Name = "cameraScreen";
            this.cameraScreen.Size = new System.Drawing.Size(266, 167);
            this.cameraScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraScreen.TabIndex = 12;
            this.cameraScreen.TabStop = false;
            this.cameraScreen.Visible = false;
            // 
            // btnMuteCall
            // 
            this.btnMuteCall.Image = ((System.Drawing.Image)(resources.GetObject("btnMuteCall.Image")));
            this.btnMuteCall.Location = new System.Drawing.Point(536, 115);
            this.btnMuteCall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMuteCall.Name = "btnMuteCall";
            this.btnMuteCall.Size = new System.Drawing.Size(157, 40);
            this.btnMuteCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMuteCall.TabIndex = 13;
            this.btnMuteCall.TabStop = false;
            this.btnMuteCall.Visible = false;
            this.btnMuteCall.Click += new System.EventHandler(this.btnMuteCall_Click);
            // 
            // pbMiniMap
            // 
            this.pbMiniMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMiniMap.Image")));
            this.pbMiniMap.Location = new System.Drawing.Point(399, 347);
            this.pbMiniMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMiniMap.Name = "pbMiniMap";
            this.pbMiniMap.Size = new System.Drawing.Size(80, 69);
            this.pbMiniMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniMap.TabIndex = 14;
            this.pbMiniMap.TabStop = false;
            this.pbMiniMap.Visible = false;
            // 
            // pbRedDot
            // 
            this.pbRedDot.Image = ((System.Drawing.Image)(resources.GetObject("pbRedDot.Image")));
            this.pbRedDot.Location = new System.Drawing.Point(338, 273);
            this.pbRedDot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRedDot.Name = "pbRedDot";
            this.pbRedDot.Size = new System.Drawing.Size(51, 55);
            this.pbRedDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedDot.TabIndex = 15;
            this.pbRedDot.TabStop = false;
            this.pbRedDot.Visible = false;
            // 
            // pbBorder
            // 
            this.pbBorder.Image = ((System.Drawing.Image)(resources.GetObject("pbBorder.Image")));
            this.pbBorder.Location = new System.Drawing.Point(266, 273);
            this.pbBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBorder.Name = "pbBorder";
            this.pbBorder.Size = new System.Drawing.Size(51, 55);
            this.pbBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBorder.TabIndex = 16;
            this.pbBorder.TabStop = false;
            this.pbBorder.Visible = false;
            // 
            // pbAM
            // 
            this.pbAM.Image = ((System.Drawing.Image)(resources.GetObject("pbAM.Image")));
            this.pbAM.Location = new System.Drawing.Point(571, 37);
            this.pbAM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAM.Name = "pbAM";
            this.pbAM.Size = new System.Drawing.Size(143, 57);
            this.pbAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAM.TabIndex = 17;
            this.pbAM.TabStop = false;
            // 
            // pbNight1
            // 
            this.pbNight1.Image = ((System.Drawing.Image)(resources.GetObject("pbNight1.Image")));
            this.pbNight1.Location = new System.Drawing.Point(592, 115);
            this.pbNight1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbNight1.Name = "pbNight1";
            this.pbNight1.Size = new System.Drawing.Size(123, 47);
            this.pbNight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNight1.TabIndex = 18;
            this.pbNight1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.pbNight1);
            this.Controls.Add(this.pbAM);
            this.Controls.Add(this.pbBorder);
            this.Controls.Add(this.pbRedDot);
            this.Controls.Add(this.pbMiniMap);
            this.Controls.Add(this.btnMuteCall);
            this.Controls.Add(this.cameraScreen);
            this.Controls.Add(this.btnFreddysNose);
            this.Controls.Add(this.btnCameras);
            this.Controls.Add(this.leftDoor);
            this.Controls.Add(this.rightDoor);
            this.Controls.Add(this.btnLightR);
            this.Controls.Add(this.btnDoorR);
            this.Controls.Add(this.btnLightL);
            this.Controls.Add(this.btnDoorL);
            this.Controls.Add(this.buttonsL);
            this.Controls.Add(this.buttonsR);
            this.Controls.Add(this.lblDebugMenu);
            this.Controls.Add(this.pbOffice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "Game";
            this.Text = "Five Nights At Freddy\'s 1 Remake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.ClientSizeChanged += new System.EventHandler(this.Game_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMuteCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNight1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label btnDoorR;
        internal Label btnLightR;
        internal Label btnLightL;
        internal Label btnDoorL;
        internal PictureBox btnCameras;
        internal PictureBox buttonsR;
        internal PictureBox buttonsL;
        internal Label lblDebugMenu;
        internal PictureBox pbOffice;
        internal PictureBox rightDoor;
        internal PictureBox leftDoor;
        internal Panel btnFreddysNose;
        internal PictureBox cameraScreen;
        internal PictureBox btnMuteCall;
        internal PictureBox pbMiniMap;
        internal PictureBox pbRedDot;
        internal PictureBox pbBorder;
        internal PictureBox pbAM;
        internal PictureBox pbNight1;
    }
}