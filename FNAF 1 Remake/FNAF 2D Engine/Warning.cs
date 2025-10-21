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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pbWarning.Location = new Point((this.Size.Width / 2) - (pbWarning.Size.Width / 2), (this.Size.Height / 2) - (pbWarning.Size.Height / 2));
            ShowMenu();
        }

        private async void ShowMenu()
        {
            await Task.Delay(3000);
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
