using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Show();
            g.FormClosing += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            s.FormClosing += (se, args) => this.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
