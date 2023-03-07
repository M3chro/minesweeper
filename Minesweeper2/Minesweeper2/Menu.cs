using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
            game.FormClosing += (s, args) => this.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
            settings.FormClosing += (s, args) => this.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
