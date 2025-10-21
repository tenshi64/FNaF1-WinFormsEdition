using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FNAF_2D_Engine
{
    static class Movement
    {
        private static int lastOffset;
        private static bool _play;

        public static void MoveCameraWithMouse(PictureBox office, int offset, Form form)
        {
            if (office.Location.X < 0 && office.Location.X > -(office.Size.Width / 4) + 100)
            {
                if (office.Location.X + (-offset * 4) >= 2 || office.Location.X + (-offset * 4) <= -(office.Size.Width / 4) - 2 + 100)
                {
                    if (offset == lastOffset)
                    {
                        offset = 0;
                    }
                    else
                    {
                        offset = -offset / 2;
                    }
                }
                office.Location = new Point(office.Location.X + (-offset * 4), office.Location.Y);
                (form as Game).btnCameras.Location = new Point((form as Game).btnCameras.Location.X + (offset * 4), (form as Game).btnCameras.Location.Y);
                (form as Game).pbNight1.Location = new Point((form as Game).pbNight1.Location.X + (offset * 4), (form as Game).pbNight1.Location.Y);
                (form as Game).pbAM.Location = new Point((form as Game).pbAM.Location.X + (offset * 4), (form as Game).pbAM.Location.Y);
                lastOffset = offset;
            }
        }

        public static bool isPlaying;
        public static async void MoveCamera(PictureBox cam, Form form)
        {
            if (!isPlaying)
            {
                int offset = 0;
                bool wasOne = false;
                cam.Location = new Point(1, cam.Location.Y);
                isPlaying = true;

                while (_play)
                {
                    if (!_play)
                    {
                        break;
                    }
                    if (offset == 0)
                    {
                        if (!wasOne)
                        {
                            await Task.Delay(5000);
                            offset = 1;
                            wasOne = true;
                        }
                        else
                        {
                            await Task.Delay(5000);
                            offset = -1;
                            wasOne = false;
                        }
                    }
                    else
                    {
                        if (offset == -1)
                        {
                            if (cam.Location.X < 0)
                            {
                                AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\CAMERA_VIDEO_LOA_60105303.wav", 0.9f);
                                cam.Location = new Point(cam.Location.X + (-offset * 4), cam.Location.Y);
                                (form as Game).pbBorder.Location = new Point((form as Game).pbBorder.Location.X + (offset * 4), (form as Game).pbBorder.Location.Y);
                                (form as Game).pbMiniMap.Location = new Point((form as Game).pbMiniMap.Location.X + (offset * 4), (form as Game).pbMiniMap.Location.Y);
                                (form as Game).pbRedDot.Location = new Point((form as Game).pbRedDot.Location.X + (offset * 4), (form as Game).pbRedDot.Location.Y);
                                (form as Game).btnCameras.Location = new Point((form as Game).btnCameras.Location.X + (offset * 4), (form as Game).btnCameras.Location.Y);
                                (form as Game).pbNight1.Location = new Point((form as Game).pbNight1.Location.X + (offset * 4), (form as Game).pbNight1.Location.Y);
                                (form as Game).pbAM.Location = new Point((form as Game).pbAM.Location.X + (offset * 4), (form as Game).pbAM.Location.Y);
                                await Task.Delay(10);
                            }
                            else
                            {
                                offset = 0;
                                AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\CAMERA_VIDEO_LOA_60105303.wav");
                                wasOne = false;
                                continue;
                            }
                        }
                        else
                        {
                            if (cam.Location.X > -(cam.Size.Width / 4) + 200)
                            {
                                AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\CAMERA_VIDEO_LOA_60105303.wav", 0.9f);
                                cam.Location = new Point(cam.Location.X + (-offset * 4), cam.Location.Y);
                                (form as Game).pbBorder.Location = new Point((form as Game).pbBorder.Location.X + (offset * 4), (form as Game).pbBorder.Location.Y);
                                (form as Game).pbMiniMap.Location = new Point((form as Game).pbMiniMap.Location.X + (offset * 4), (form as Game).pbMiniMap.Location.Y);
                                (form as Game).pbRedDot.Location = new Point((form as Game).pbRedDot.Location.X + (offset * 4), (form as Game).pbRedDot.Location.Y);
                                (form as Game).btnCameras.Location = new Point((form as Game).btnCameras.Location.X + (offset * 4), (form as Game).btnCameras.Location.Y);
                                (form as Game).pbNight1.Location = new Point((form as Game).pbNight1.Location.X + (offset * 4), (form as Game).pbNight1.Location.Y);
                                (form as Game).pbAM.Location = new Point((form as Game).pbAM.Location.X + (offset * 4), (form as Game).pbAM.Location.Y);
                                await Task.Delay(10);
                            }
                            else
                            {
                                offset = 0;
                                AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\CAMERA_VIDEO_LOA_60105303.wav");
                            }
                        }
                    }
                    /*if (cam.Location.X < 0 && cam.Location.X > -(cam.Size.Width / 4) + 100)
                    {
                        if (cam.Location.X + (-offset * 4) >= 2 || cam.Location.X + (-offset * 4) <= -(cam.Size.Width / 4) - 2 + 100)
                        {
                            if (offset == lastOffset)
                            {
                                offset = 0;
                            }
                            else
                            {
                                offset = -offset / 2;
                            }
                        }
                        lastOffset = offset;
                    }*/
                }
            }
        }

        public static bool Play
        {
            get { return _play; }
            set { _play = value; }
        }
    }
}