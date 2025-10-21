using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace FNAF_2D_Engine
{
    static internal class AudioManager
    {
        private static Dictionary<string, MediaPlayer> audioPlayers = new Dictionary<string, MediaPlayer>();
        private static Dictionary<string, MediaPlayer> oneShotPlayers = new Dictionary<string, MediaPlayer>();

        public static void StopPlaying(string path)
        {
            if(audioPlayers.ContainsKey(path))
            {
                foreach (var audioPlayer in audioPlayers.ToList())
                {
                    if (audioPlayer.Value.Source.OriginalString == path)
                    {
                        audioPlayer.Value.Stop();
                        audioPlayers.Remove(audioPlayer.Key);
                    }
                }
            }
            else if(oneShotPlayers.ContainsKey(path))
            {
                foreach (var audioPlayer in oneShotPlayers.ToList())
                {
                    if (audioPlayer.Value.Source.OriginalString == path)
                    {
                        audioPlayer.Value.Stop();
                        audioPlayers.Remove(audioPlayer.Key);
                    }
                }
            }
        }

        public static void PlayLoop(string path, float volume)
        {
            if(!audioPlayers.ContainsKey(path))
            {
                var player = new MediaPlayer();
                player.Volume = volume;
                player.Open(new Uri(path));
                audioPlayers[path] = player;

                player.Play();
                player.MediaEnded += (sender, e) => { LoopSound(sender, e, player); player.Volume = volume; };
            }
        }

        private static bool isPlaying;
        public static void PlayOneShot(string path, float volume)
        {
            if (!path.Contains("Bible") && !path.Contains("put down") && !path.Contains("voiceover1c") && !path.Contains("blip3") && !path.Contains("CAMERA_VIDEO_LOA_60105303"))
            {
                if (!isPlaying)
                {
                    var oneShotPlayer = new MediaPlayer();
                    oneShotPlayer.Volume = volume;
                    oneShotPlayer.Open(new Uri(path));
                    oneShotPlayers[path] = oneShotPlayer;

                    oneShotPlayer.Play();
                    isPlaying = true;
                    oneShotPlayer.MediaEnded += (sender, e) => { StopPlaying(path); isPlaying = false; };
                }
            }
            else
            {
                if (path.Contains("voiceover1c.wav"))
                {
                    var oneShotPlayer = new MediaPlayer();
                    oneShotPlayer.Volume = volume;
                    oneShotPlayer.Open(new Uri(path));
                    audioPlayers[path] = oneShotPlayer;

                    oneShotPlayer.Play();
                    var Game = (Game)Application.OpenForms.Cast<Form>().Last();
                    oneShotPlayer.MediaEnded += (sender, e) => { StopPlaying(path); Game.btnMuteCall.Hide(); };
                }
                else
                {
                    var oneShotPlayer = new MediaPlayer();
                    oneShotPlayer.Volume = volume;
                    oneShotPlayer.Open(new Uri(path));
                    oneShotPlayers[path] = oneShotPlayer;

                    oneShotPlayer.Play();
                    oneShotPlayer.MediaEnded += (sender, e) => { StopPlaying(path); };
                }
            }
        }

        private static void LoopSound(object sender, EventArgs e, MediaPlayer player)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
        }
    }
}
