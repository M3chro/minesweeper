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
    public partial class SettingsForm : Form
    {
        SettingsLogic settingsLogic;

        public SettingsForm()
        {
            InitializeComponent();
            settingsLogic = new SettingsLogic();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Easy.Checked)
                settingsLogic.SetEasyDifficulty();
            else if (Normal.Checked)
                settingsLogic.SetNormalDifficulty();
            else if (Hard.Checked)
                settingsLogic.SetHardDifficulty();
            else if (Custom.Checked)
                settingsLogic.SetCustomDifficulty((int)Mines.Value, (int)Width.Value, (int)Height.Value);
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
                settingsLogic.SetColor(PickColor.BackColor);
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
