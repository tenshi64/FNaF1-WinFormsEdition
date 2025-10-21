using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Security.Cryptography;

namespace FNAF_2D_Engine
{
    public partial class Game : Form
    {
        Animations Animations;
        //private readonly NewspaperIntro newspaper = (NewspaperIntro)Application.OpenForms.Cast<Form>().Last();
        public Game()
        {
            InitializeComponent();
            btnCameras.BackColor = Color.FromArgb(15, Color.Black);
        }

        public bool leftDoorClosed;
        public bool leftLightOn;
        public bool rightDoorClosed;
        public bool rightLightOn;

        private void Game_Load(object sender, EventArgs e)
        {
            Animations = new Animations();
            lblDebugMenu.Location = new Point(0,0);
            lblDebugMenu.Hide();
            this.BackColor = Color.Black;
            pbOffice.Size = new Size(1500, 700);
            pbOffice.Location = new Point((this.Size.Width / 2) - (pbOffice.Size.Width / 2), -70);
            Cursor.Position = new Point((this.Size.Width / 2), (this.Size.Height / 2));

            //Cameras
            cameraScreen.LoadAsync(@".\Assets\FNaF 1\142.PNG");

            pbNight1.Parent = pbOffice;
            pbNight1.BackColor = Color.Transparent;

            pbAM.Parent = pbOffice;
            pbAM.BackColor = Color.Transparent;

            //MiniMap
            pbMiniMap.Parent = cameraScreen;
            pbMiniMap.Size = new Size(500, 550);
            pbMiniMap.BackColor = Color.Transparent;

            //Red Dot
            pbRedDot.Parent = cameraScreen;
            pbRedDot.Size = new Size(100, 100);
            pbRedDot.BackColor = Color.Transparent;
            pbRedDot.Location = new Point(100, 100);

            //Mute Call
            btnMuteCall.Location = new Point(40, 50);

            //Door buttons
            btnFreddysNose.Parent = pbOffice;
            btnFreddysNose.BackColor = Color.Transparent;

            //Old res: btnFreddysNose.Location = new Point(this.Location.X/2 + this.Size.Width/2 + 100, pbOffice.Location.Y/2 + this.Size.Height/2 - 80);
            btnFreddysNose.Location = new Point(pbOffice.Location.X / 2 + this.Size.Width / 2 + 670, pbOffice.Location.Y / 2 + this.Size.Height / 2 + 120);
            btnFreddysNose.BringToFront();

            btnCameras.Parent = pbOffice;
            btnCameras.BackColor = Color.Transparent;
            btnCameras.BringToFront();

            rightDoor.Parent = pbOffice;
            rightDoor.BackColor = Color.Transparent;
            //Old res: rightDoor.Location = new Point((pbOffice.Size.Width / 4) + 1165, 50);
            rightDoor.Location = new Point((pbOffice.Size.Width / 4) + 1635, 50);
            rightDoor.Size = new Size(rightDoor.Size.Width, 1200);

            leftDoor.Parent = pbOffice;
            leftDoor.BackColor = Color.Transparent;
            //Old res: leftDoor.Location = new Point(-(pbOffice.Size.Width / 4) + 630, 50);
            leftDoor.Location = new Point(-(pbOffice.Size.Width / 4) + 490, 50);
            leftDoor.Size = new Size(rightDoor.Size.Width, 1200);

            buttonsR.Parent = pbOffice;
            buttonsR.BackColor = Color.Transparent;
            //Old res: buttonsR.Location = new Point((pbOffice.Size.Width/4)+1420, 400);
            buttonsR.Location = new Point((pbOffice.Size.Width/4)+1930, 400);

            buttonsL.Parent = pbOffice;
            buttonsL.BackColor = Color.Transparent;
            //Old res: buttonsL.Location = new Point(-(pbOffice.Size.Width/4)+540, 400);
            buttonsL.Location = new Point(-(pbOffice.Size.Width/4)+390, 400);


            btnDoorL.Parent = buttonsL;
            btnDoorL.BackColor = Color.Transparent;
            btnDoorL.Location = new Point(37, 60);
            btnDoorL.BringToFront();

            btnLightL.Parent = buttonsL;
            btnLightL.BackColor = Color.Transparent;
            btnLightL.Location = new Point(37, 150);
            btnLightL.BringToFront();


            btnDoorR.Parent = buttonsR;
            btnDoorR.BackColor = Color.Transparent;
            btnDoorR.Location = new Point(26, 60);
            btnDoorR.BringToFront();

            btnLightR.Parent = buttonsR;
            btnLightR.BackColor = Color.Transparent;
            btnLightR.Location = new Point(26, 150);
            btnLightR.BringToFront();

            //Playing sounds
            AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\ColdPresc B.wav", 0.5f);
            AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\Buzz_Fan_Florescent2.wav", 0.5f);

            PhoneCall();
            Time();
        }

        private void Game_ClientSizeChanged(object sender, EventArgs e)
        {
            pbOffice.Location = new Point((this.Size.Width / 2) - (pbOffice.Size.Width / 2), -70);
            this.Size = new Size(this.Size.Width, Convert.ToInt32(Math.Floor(this.Size.Width / 2.22f)));
        }

        private void pbOffice_MouseMove(object sender, MouseEventArgs e)
        {
            int deadZone = 200;
            if (Cursor.Position.X < (this.Size.Width / 2) - deadZone)
            {
                Movement.MoveCameraWithMouse(pbOffice, -1, this);
                //Left
            }
            if (Cursor.Position.X > (this.Size.Width / 2) + deadZone)
            {
                Movement.MoveCameraWithMouse(pbOffice, 1, this);
                //btnCameras.Location = new Point(btnCameras.Location.X * (100) * 4, pbOffice.Location.Y + this.Size.Height - 50);
                //Right
            }
            if(Cursor.Position.X < (this.Size.Width / 2) + deadZone && Cursor.Position.X > (this.Size.Width / 2) - deadZone)
            {
                Movement.MoveCameraWithMouse(pbOffice, 0, this);
                //btnCameras.Location = new Point(btnCameras.Location.X * (0) * 4, pbOffice.Location.Y + this.Size.Height - 50);
                //Center
            }
        }

        private void btnFreddysNose_Click(object sender, EventArgs e)
        {
            AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\nose.mp3", 1);
        }

        private async void Time()
        {
            for(int i = 1; i <= 6; i++)
            {
                if(i == 1)
                {
                    await Task.Delay(90000);
                    pbAM.LoadAsync($@".\Assets\UI\{i} am.png");
                }
                else
                {
                    await Task.Delay(89000);
                    pbAM.LoadAsync($@".\Assets\UI\{i} am.png");
                }
            }
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            cameraScreen.Size = new Size(this.Size.Width + 100, 100);
            cameraScreen.Location = new Point(0, 0);

            pbNight1.Location = new Point(this.Size.Width + 100, 170);
            pbAM.Location = new Point(this.Size.Width + 85, 120);

            //Border
            pbBorder.Size = new Size(this.Size.Width, this.Size.Height);
            pbBorder.Parent = cameraScreen;
            pbBorder.BackColor = Color.Transparent;
            pbBorder.Location = new Point(0, 0);

            cameraScreen.BringToFront();
            pbBorder.BringToFront();
            pbRedDot.BringToFront();
            pbMiniMap.BringToFront();
            btnCameras.BringToFront();
            btnMuteCall.BringToFront();

            //Cameras
            btnCameras.Location = new Point(pbOffice.Location.X + 900, this.Size.Height - 50);
            pbMiniMap.Location = new Point(cameraScreen.Size.Width - 550, 500);
            //newspaper.Hide();
        }

        private bool camerasOff;
        public bool camerasChanged;

        private void btnCameras_MouseLeave(object sender, EventArgs e)
        {
            camerasChanged = false;
        }

        private void btnCameras_MouseEnter(object sender, EventArgs e)
        {
            leftLightOn = false;
            rightLightOn = false;
            Animations.ChangeImages(buttonsR, buttonsL);
            Animations.ChangeImages(buttonsL, buttonsR);

            if (!camerasChanged)
            {
                AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\put down.wav", 0.5f);
                
                if (!camerasOff)
                {
                    Animations.CameraScreen(cameraScreen, !camerasOff);
                }
                else
                {
                    Animations.CameraScreen(cameraScreen, !camerasOff);
                }

                camerasOff = !camerasOff;
                camerasChanged = true;
            }
        }

        private void DoorOrLightClicked(object sender, EventArgs e)
        {
            if ((sender as Label).Name.Contains("Door"))
            {
                if ((sender as Label).Name.Contains("DoorL"))
                {
                    leftDoorClosed = !leftDoorClosed;
                    AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\SFXBible_12478.wav", 1);
                    Animations.ChangeImages(buttonsL, buttonsR);
                }
                else if ((sender as Label).Name.Contains("DoorR"))
                {
                    rightDoorClosed = !rightDoorClosed;
                    AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\SFXBible_12478.wav", 1);
                    Animations.ChangeImages(buttonsR, buttonsL);
                }
            }
            else if ((sender as Label).Name.Contains("Light"))
            {
                if ((sender as Label).Name.Contains("LightL"))
                {
                    leftLightOn = !leftLightOn;
                    rightLightOn = false;
                    Animations.ChangeImages(buttonsL, buttonsR);
                }
                else if ((sender as Label).Name.Contains("LightR"))
                {
                    rightLightOn = !rightLightOn;
                    leftLightOn = false;
                    Animations.ChangeImages(buttonsR, buttonsL);
                }
            }
        }

        private async void PhoneCall()
        {
            await Task.Delay(4000);
            AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\voiceover1c.wav", 1f);
            await Task.Delay(18000);
            btnMuteCall.Show();
            await Task.Delay(40000);
            btnMuteCall.Hide();
        }

        private void btnMuteCall_Click(object sender, EventArgs e)
        {
            AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\voiceover1c.wav");
            btnMuteCall.Hide();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
