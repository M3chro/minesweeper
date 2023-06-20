using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper2
{
    internal class SettingsLogic
    {
        public void SetEasyDifficulty()
        {
            SettingsData.Difficulty = Difficulty.Easy;
            SettingsData.MineCount = 10;
            SettingsData.Width = 6;
            SettingsData.Height = 6;
        }

        public void SetNormalDifficulty()
        {
            SettingsData.Difficulty = Difficulty.Normal;
            SettingsData.MineCount = 20;
            SettingsData.Width = 12;
            SettingsData.Height = 12;
        }

        public void SetHardDifficulty()
        {
            SettingsData.Difficulty = Difficulty.Hard;
            SettingsData.MineCount = 100;
            SettingsData.Width = 30;
            SettingsData.Height = 30;
        }

        public void SetCustomDifficulty(int mineCount, int width, int height)
        {
            SettingsData.Difficulty = Difficulty.Custom;
            SettingsData.MineCount = mineCount;
            SettingsData.Width = width;
            SettingsData.Height = height;

            // Adjust mine count if it exceeds the number of cells
            if ((SettingsData.Width * SettingsData.Height) - 9 <= SettingsData.MineCount)
                SettingsData.MineCount = (SettingsData.Width * SettingsData.Height) / 2;
        }

        public void SetColor(Color c)
        {
            SettingsData.DefaultColor = c;
        }
    }
}
