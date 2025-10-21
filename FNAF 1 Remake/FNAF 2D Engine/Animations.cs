using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_2D_Engine
{
    internal class Animations
    {
        private readonly Game Game = (Game)Application.OpenForms.Cast<Form>().Last();

        public async void CameraScreen(PictureBox picture, bool closed)
        {
            Game.btnMuteCall.BringToFront();
            Movement.isPlaying = false;
            if (closed)
            {
                if (picture.ImageLocation != null)
                {
                    picture.Size = new Size(Game.Size.Width, Game.Size.Height);
                    picture.Location = new Point(0, 0);
                    picture.Show();
                    Game.btnCameras.Hide();
                    picture.LoadAsync(@".\Assets\FNaF 1\144.PNG");
                    await Task.Delay(13);
                    picture.LoadAsync(@".\Assets\FNaF 1\132.PNG");
                    await Task.Delay(13);
                    picture.LoadAsync(@".\Assets\FNaF 1\133.PNG");
                    await Task.Delay(13);
                    for (int i = 136; i <= 141; i++)
                    {
                        picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                        await Task.Delay(13);
                    }
                    await Task.Delay(13);

                    Game.btnMuteCall.BringToFront();

                    Game.btnCameras.Parent = picture;
                    Game.btnCameras.BringToFront();
                    Game.btnCameras.Show();

                    Game.pbAM.Parent = picture;
                    Game.pbAM.BringToFront();
                    Game.pbAM.Location = new Point(Game.Width - 185, 50);

                    Game.pbNight1.Parent = picture;
                    Game.pbNight1.BringToFront();
                    Game.pbNight1.Location = new Point(Game.Width - 170, 100);

                    Game.pbMiniMap.Show();
                    Game.pbMiniMap.Location = new Point(picture.Size.Width - 550, 500);


                    Game.pbRedDot.Show();
                    Game.pbBorder.Show();
                    Game.pbBorder.Location = new Point(0, 0);

                    Game.camerasChanged = true;
                    AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\blip3.wav", 1f);
                    picture.LoadAsync(@$".\Assets\Cameras\1A.GIF");

                    Movement.Play = true;
                    Movement.MoveCamera(picture, Game);

                    picture.Size = new Size(2420, 1080);
                    picture.Location = new Point(0, 0);
                    Game.btnCameras.Location = new Point(350, 992);
                }
            }
            else
            {
                if (picture.ImageLocation != null)
                {
                    Game.btnCameras.Hide();
                    Game.pbMiniMap.Hide();
                    Game.pbRedDot.Hide();
                    Game.pbBorder.Hide();
                    Movement.Play = false;

                    picture.Size = new Size(Game.Size.Width, Game.Size.Height);
                    picture.Location = new Point(0, 0);
                    Game.pbMiniMap.Location = new Point(picture.Size.Width - 550, 500);
                    Game.pbRedDot.Location = new Point(100, 100);
                    Game.pbBorder.Location = new Point(0, 0);

                    for (int i = 141; i >= 136; i--)
                    {
                        picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                        await Task.Delay(13);
                    }
                    picture.LoadAsync(@".\Assets\FNaF 1\133.PNG");
                    await Task.Delay(13);
                    picture.LoadAsync(@".\Assets\FNaF 1\132.PNG");
                    await Task.Delay(13);
                    picture.LoadAsync(@".\Assets\FNaF 1\144.PNG");
                    await Task.Delay(13);
                    picture.LoadAsync(@".\Assets\FNaF 1\142.PNG");
                    AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\CAMERA_VIDEO_LOA_60105303.wav");
                    await Task.Delay(13);
                    picture.Hide();

                    Game.pbAM.Parent = Game.pbOffice;
                    Game.pbAM.BringToFront();
                    Game.pbAM.Location = new Point(Game.Size.Width + 85, 120);

                    Game.pbNight1.Parent = Game.pbOffice;
                    Game.pbNight1.BringToFront();
                    Game.pbNight1.Location = new Point(Game.Size.Width + 100, 170);

                    Game.btnCameras.Parent = Game.pbOffice;
                    Game.btnCameras.BringToFront();
                    Game.btnCameras.Show();
                    Game.camerasChanged = true;

                    Game.pbOffice.Location = new Point((Game.Size.Width / 2) - (Game.pbOffice.Size.Width / 2), -70);
                    Cursor.Position = new Point((Game.Size.Width / 2), (Game.Size.Height / 2));

                    Game.btnCameras.Location = new Point(Game.pbOffice.Location.X + 900, Game.Size.Height - 50);
                }
            }
        }

        public async void OpenDoor(PictureBox picture)
        {
            if (picture.Name.Contains("left"))
            {
                if (picture.ImageLocation != null)
                {
                    if (picture.ImageLocation.Contains("102.PNG"))
                    {
                        for (int i = 102; i >= 91; i--)
                        {
                            picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                            await Task.Delay(5);
                        }
                        picture.LoadAsync(@".\Assets\FNaF 1\89.PNG");
                        await Task.Delay(5);
                        picture.LoadAsync(@".\Assets\FNaF 1\88.PNG");
                    }
                }
            }
            else if (picture.Name.Contains("right"))
            {
                if (picture.ImageLocation != null)
                {
                    if (picture.ImageLocation.Contains("118.PNG"))
                    {
                        for (int i = 118; i >= 106; i--)
                        {
                            picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                            await Task.Delay(5);
                        }
                        picture.LoadAsync(@".\Assets\FNaF 1\121.PNG");
                        await Task.Delay(5);
                        picture.LoadAsync(@".\Assets\FNaF 1\104.PNG");
                        await Task.Delay(5);
                    }
                }
            }
        }

        public async void CloseDoor(PictureBox picture)
        {
            if (picture.Name.Contains("left"))
            {
                if (picture.ImageLocation != null)
                {
                    if (!picture.ImageLocation.Contains("102.PNG"))
                    {
                        picture.LoadAsync(@".\Assets\FNaF 1\88.PNG");
                        await Task.Delay(5);
                        picture.LoadAsync(@".\Assets\FNaF 1\89.PNG");
                        await Task.Delay(5);
                        for (int i = 91; i <= 102; i++)
                        {
                            picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                            await Task.Delay(5);
                        }
                    }
                }
                else
                {
                    picture.LoadAsync(@".\Assets\FNaF 1\88.PNG");
                    await Task.Delay(5);
                    picture.LoadAsync(@".\Assets\FNaF 1\89.PNG");
                    await Task.Delay(5);
                    for (int i = 91; i <= 102; i++)
                    {
                        picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                        await Task.Delay(5);
                    }
                }
            }
            else if (picture.Name.Contains("right"))
            {
                if (picture.ImageLocation != null)
                {
                    if (!picture.ImageLocation.Contains("118.PNG"))
                    {
                        picture.LoadAsync(@".\Assets\FNaF 1\104.PNG");
                        await Task.Delay(5);
                        picture.LoadAsync(@".\Assets\FNaF 1\121.PNG");
                        await Task.Delay(5);
                        for (int i = 106; i <= 118; i++)
                        {
                            picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                            await Task.Delay(5);
                        }
                    }
                }
                else
                {
                    picture.LoadAsync(@".\Assets\FNaF 1\104.PNG");
                    await Task.Delay(5);
                    picture.LoadAsync(@".\Assets\FNaF 1\121.PNG");
                    await Task.Delay(5);
                    for (int i = 106; i <= 118; i++)
                    {
                        picture.LoadAsync(@$".\Assets\FNaF 1\{i}.PNG");
                        await Task.Delay(5);
                    }
                }
            }
        }

        public void ChangeImages(PictureBox picture, PictureBox secondPicture)
        {
            if (picture.Name.Contains("L"))
            {
                switch (Game.leftDoorClosed, Game.leftLightOn)
                {
                    case (true, false):
                        AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav");

                        CloseDoor(Game.leftDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\124.PNG");
                        if (!Game.rightLightOn)
                        {
                            Game.pbOffice.LoadAsync(@".\Assets\office.GIF");
                        }
                        break;
                    case (false, true):
                        AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav", 1);

                        OpenDoor(Game.leftDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\125.PNG");
                        Game.pbOffice.LoadAsync(@".\Assets\office left light.GIF");
                        if (Game.rightDoorClosed)
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\135.PNG");
                        }
                        else
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\134.PNG");
                        }
                        break;
                    case (true, true):
                        AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav", 1);

                        CloseDoor(Game.leftDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\130.PNG");
                        Game.pbOffice.LoadAsync(@".\Assets\office left light.GIF");
                        if (Game.rightDoorClosed)
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\135.PNG");
                        }
                        else
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\134.PNG");
                        }
                        break;
                    case (false, false):
                        AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav");

                        OpenDoor(Game.leftDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\122.PNG");
                        if (!Game.rightLightOn)
                        {
                            Game.pbOffice.LoadAsync(@".\Assets\office.GIF");
                        }
                        break;
                }
            }
            else if (picture.Name.Contains("R"))
            {
                switch (Game.rightDoorClosed, Game.rightLightOn)
                {
                    case (true, false):
                        AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav");

                        CloseDoor(Game.rightDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\135.PNG");
                        if (!Game.leftLightOn)
                        {
                            Game.pbOffice.LoadAsync(@".\Assets\office.GIF");
                        }
                        break;
                    case (false, true):
                        AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav", 1);

                        OpenDoor(Game.rightDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\131.PNG");
                        Game.pbOffice.LoadAsync(@".\Assets\office right light.GIF");
                        if (Game.leftDoorClosed)
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\124.PNG");
                        }
                        else
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\122.PNG");
                        }
                        break;
                    case (true, true):
                        AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav", 1);

                        CloseDoor(Game.rightDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\47.PNG");
                        Game.pbOffice.LoadAsync(@".\Assets\office right light.GIF");
                        if (Game.leftDoorClosed)
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\124.PNG");
                        }
                        else
                        {
                            secondPicture.LoadAsync(@".\Assets\FNaF 1\122.PNG");
                        }
                        break;
                    case (false, false):
                        AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\BallastHumMedium2.wav");

                        OpenDoor(Game.rightDoor);
                        picture.LoadAsync(@".\Assets\FNaF 1\134.PNG");
                        if (!Game.leftLightOn)
                        {
                            Game.pbOffice.LoadAsync(@".\Assets\office.GIF");
                        }
                        break;
                }
            }
        }
    }
}
