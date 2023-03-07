using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper2
{
    internal static class SettingsData
    {
        public static Difficulty Difficulty = Difficulty.Normal;
        public static int MineCount = 20;
        public static int Width = 12;
        public static int Height = 12;
        public static Color DefaultColor = Color.DarkSeaGreen;
    }
}
