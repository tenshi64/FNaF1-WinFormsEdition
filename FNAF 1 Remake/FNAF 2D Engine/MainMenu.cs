using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FNAF_2D_Engine
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private readonly Warning warning = (Warning)Application.OpenForms.Cast<Form>().Last();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            pbMenu.Size = new Size(1500, 700);
            pbMenu.Location = new Point((this.Size.Width / 2) - (pbMenu.Size.Width / 2), -40);

            AudioManager.PlayLoop(Environment.CurrentDirectory + @"\Assets\Audio\darkness music.wav", 1f);
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pbLogo.Parent = pbMenu;
            pbLogo.Location = new Point(this.Width / 2 - 550, this.Height / 2 - 350);
            pbLogo.BackColor = Color.Transparent;

            btnNewGame.Parent = pbMenu;
            btnNewGame.Location = new Point(this.Width / 2 - 620, this.Height / 2 + 130);
            btnNewGame.BackColor = Color.Transparent;

            btnContinue.Parent = pbMenu;
            btnContinue.Location = new Point(this.Width / 2 - 620, this.Height / 2 + 210);
            btnContinue.BackColor = Color.Transparent;

            btnQuit.Parent = pbMenu;
            btnQuit.Location = new Point(this.Width / 2 - 550, this.Height / 2 + 350);
            btnQuit.BackColor = Color.Transparent;

            pbVersion.Parent = pbMenu;
            pbVersion.Location = new Point(this.Width / 2 - 680, this.Height - 20);
            pbVersion.BackColor = Color.Transparent;

            btnGitHub.Parent = pbMenu;
            btnGitHub.Location = new Point(this.Width + 60, this.Height - 150);
            btnGitHub.BackColor = Color.Transparent;

            pbCredits.Parent = pbMenu;
            pbCredits.Location = new Point(this.Width - 95, this.Height);
            pbCredits.BackColor = Color.Transparent;
            warning.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_MouseEnter(object sender, EventArgs e)
        {
            btnNewGame.LoadAsync(@".\Assets\Buttons\new game hover.PNG");
        }

        private void btnContinue_MouseEnter(object sender, EventArgs e)
        {
            btnContinue.LoadAsync(@".\Assets\Buttons\continue hover.PNG");
        }

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.LoadAsync(@".\Assets\Buttons\continue.PNG");
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.LoadAsync(@".\Assets\Buttons\new game.PNG");
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tenshi64");
        }

        private void PlayNewspaperIntro(object sender, EventArgs e)
        {
            var newspaper = new NewspaperIntro();
            newspaper.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
