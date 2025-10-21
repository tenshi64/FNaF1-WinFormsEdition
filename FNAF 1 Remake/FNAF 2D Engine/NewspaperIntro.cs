using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_2D_Engine
{
    public partial class NewspaperIntro : Form
    {
        public NewspaperIntro()
        {
            InitializeComponent();
        }

        private readonly MainMenu mainMenu = (MainMenu)Application.OpenForms.Cast<Form>().Last();
        private void NewspaperIntro_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pbNewspaper.Size = new Size(this.Width, this.Height);
            pbNewspaper.Location = new Point((this.Size.Width / 2) - (pbNewspaper.Size.Width / 2), (this.Size.Height / 2) - (pbNewspaper.Size.Height / 2));
            pbNight1.Location = new Point((this.Size.Width / 2) - (pbNight1.Size.Width / 2), (this.Size.Height / 2) - (pbNight1.Size.Height / 2));
            PlayGame();
        }

        private async void PlayGame()
        {
            await Task.Delay(8000);
            AudioManager.StopPlaying(Environment.CurrentDirectory + @"\Assets\Audio\darkness music.wav");
            pbNewspaper.Hide();
            AudioManager.PlayOneShot(Environment.CurrentDirectory + @"\Assets\Audio\blip3.wav", 1f);
            pbNight1.Show();
            await Task.Delay(3500);
            pbNight1.Hide();
            await Task.Delay(2500);
            var game = new Game();
            game.Show();
        }

        private void NewspaperIntro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewspaperIntro_Shown(object sender, EventArgs e)
        {
            mainMenu.Hide();
        }
    }
}
