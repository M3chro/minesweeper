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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SetNewData()
        {
            if (Easy.Checked)
            {
                SettingsData.Difficulty = Difficulty.Easy;
                SettingsData.MineCount = 10;
                SettingsData.Width = 6;
                SettingsData.Height = 6;
            }
            else if (Normal.Checked)
            {
                SettingsData.Difficulty = Difficulty.Normal;
                SettingsData.MineCount = 20;
                SettingsData.Width = 12;
                SettingsData.Height = 12;
            }
            else if (Hard.Checked)
            {
                SettingsData.Difficulty = Difficulty.Hard;
                SettingsData.MineCount = 100;
                SettingsData.Width = 30;
                SettingsData.Height = 30;
            }
            else if (Custom.Checked)
            {
                SettingsData.Difficulty = Difficulty.Custom;
                SettingsData.MineCount = (int)Mines.Value;
                SettingsData.Width = (int)Width.Value;
                SettingsData.Height = (int)Height.Value;
            }

            if ((SettingsData.Width * SettingsData.Height) - 9 <= SettingsData.MineCount)
                SettingsData.MineCount = (SettingsData.Width * SettingsData.Height) / 2;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetNewData();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PickColor.BackColor = colorDialog1.Color;
                SettingsData.DefaultColor = PickColor.BackColor;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PickColor.BackColor = SettingsData.DefaultColor;
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
                case Difficulty.Custom:
                    Custom.Checked = true;
                    Width.Enabled = true;
                    Height.Enabled = true;
                    Mines.Enabled = true;
                    Width.Value = SettingsData.Width;
                    Height.Value = SettingsData.Height;
                    Mines.Value = SettingsData.MineCount;
                    break;
                default:
                    break;
            }
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (Custom.Checked)
            {
                Width.Enabled = true;
                Height.Enabled = true;
                Mines.Enabled = true;
            }
            else
            {
                Width.Enabled = false;
                Height.Enabled = false;
                Mines.Enabled = false;
            }
        }
    }
}
