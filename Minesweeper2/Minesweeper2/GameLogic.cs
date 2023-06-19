using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper2
{
    internal class GameLogic
    {
        public Cell[,] Cells { get; set; }
        public bool FirstClick { get; set; }
        public int FlagCounter { get; set; }

        public event Action<bool> GameOverEvent;
        public event EventHandler<int> FlagCountChanged;

        Random random;

        public GameLogic()
        {
            FirstClick = true;
            random = new Random();
            FlagCounter = SettingsData.MineCount;
            Cells = new Cell[SettingsData.Height, SettingsData.Width];
        }

        public void GenerateMines(int mouseX, int mouseY)
        {
            int mineCount = 0;
            int x, y;
            List<Cell> emptyCells = new List<Cell>();
            for (int i = mouseY - 1; i <= mouseY + 1; i++)
            {
                if (i < 0 || i >= Cells.GetLength(0))
                    continue;
                for (int j = mouseX - 1; j <= mouseX + 1; j++)
                {
                    if (j < 0 || j >= Cells.GetLength(1))
                        continue;
                    emptyCells.Add(Cells[i, j]);
                }
            }

            while (mineCount < SettingsData.MineCount)
            {
                x = random.Next(Cells.GetLength(1));
                y = random.Next(Cells.GetLength(0));

                if (Cells[y, x].Value == 0 && !emptyCells.Contains(Cells[y, x]))
                {
                    Cells[y, x].Value = -1;
                    mineCount++;
                }
            }
        }

        public void NumberCells()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    if (Cells[i, j].Value != -1)
                    {
                        Cells[i, j].Value = CountNeighbours(j, i);
                    }
                }
            }
        }

        public int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                if (i < 0 || i >= Cells.GetLength(0))
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j >= Cells.GetLength(1))
                        continue;
                    if (x == j && y == i)
                        continue;
                    if (Cells[i, j].Value == -1)
                        count++;
                }
            }
            return count;
        }

        public void RevealCell(int x, int y)
        {
            if (Cells[y, x].Label == "" && !Cells[y, x].Marked)
            {
                Cells[y, x].Label = Cells[y, x].Value.ToString();

                if (Cells[y, x].Value == 0)
                {
                    RevealNeighbouringCells(x, y);
                }
                else if (Cells[y, x].Value == -1)
                {
                    Cells[y, x].BackColor = Color.Red;
                    GameOverEvent?.Invoke(false);
                }
            }
        }

        public void RevealNeighbouringCells(int x, int y)
        {
            for (int i = y - 1; i <= y + 1; i++)
            {
                if (i < 0 || i >= Cells.GetLength(0))
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j >= Cells.GetLength(1))
                        continue;
                    if (x == j && y == i)
                        continue;
                    if (Cells[i, j].Label == "" && !Cells[i, j].Marked)
                    {
                        Cells[i, j].Label = Cells[i, j].Value.ToString();

                        if (Cells[i, j].Value == 0)
                            RevealNeighbouringCells(j, i);
                    }
                }
            }
        }

        public void MarkCell(int x, int y)
        {
            if (Cells[y, x].Label == "")
            {
                Cells[y, x].Marked = !Cells[y, x].Marked;
                if (Cells[y, x].Marked)
                {
                    Cells[y, x].BackColor = Color.Red;
                    FlagCounter--;
                }
                else
                {
                    Cells[y, x].BackColor = Cells[y, x].DefaultColor;
                    FlagCounter++;
                }
                FlagCountChanged?.Invoke(this, FlagCounter);
            }
        }

        public bool UncoveredAllCells()
        {
            foreach (Cell c in Cells)
            {
                if (c.Value != -1 && c.Label != "")
                    continue;
                else if (c.Value == -1 && c.Label == "")
                    continue;
                else
                    return false;
            }

            return true;
        }

        public void RevealAllMines()
        {
            foreach (Cell c in Cells)
            {
                if (c.Value == -1)
                {
                    c.Marked = false;
                    c.Label = c.Value.ToString();
                }
            }
        }

        public void SetDefaultValues(Cell c)
        {
            c.Value = 0;
            c.Label = "";
            c.Marked = false;
            c.BackColor = c.DefaultColor;
        }
    }
}
