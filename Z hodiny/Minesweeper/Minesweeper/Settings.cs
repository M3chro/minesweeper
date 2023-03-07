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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SetNewDifficulty()
        {
            if (Easy.Checked)
            {
                SettingsData.Difficulty = Difficulty.Easy;
                SettingsData.MineCount = 10;
                SettingsData.ArrSize = 6;
            }
            else if (Normal.Checked)
            {
                SettingsData.Difficulty = Difficulty.Normal;
                SettingsData.MineCount = 20;
                SettingsData.ArrSize = 12;
            }
            else if (Hard.Checked)
            {
                SettingsData.Difficulty = Difficulty.Hard;
                SettingsData.MineCount = 100;
                SettingsData.ArrSize = 30;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            SetNewDifficulty();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetNewDifficulty();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            switch (SettingsData.Difficulty)
            {
                case Difficulty.Easy:
                    Easy.Checked = true;
                    break;
                case Difficulty.Normal:
                    Normal.Checked = true;
                    break;
                case Difficulty.Hard:
                    Hard.Checked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
