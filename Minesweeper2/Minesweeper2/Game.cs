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
    public partial class Game : Form
    {
        Cell[,] cells;
        int width = SettingsData.Width;
        int height = SettingsData.Height;
        bool firstClick = true;
        Random random = new Random();
        int counter = 0;
        int flagCounter = SettingsData.MineCount;

        public Game()
        {
            InitializeComponent();
            cells = new Cell[height, width];
            flagLabel.Text = flagCounter.ToString();
            NewGame();
        }

        private void NewGame()
        {
            splitContainer1.Panel2.Controls.Clear();

            TableLayoutPanel panel = new TableLayoutPanel();
 
            splitContainer1.Panel1.GetType().GetProperty("DoubleBuffered",
               System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
               .SetValue(splitContainer1.Panel1, true, null);

            panel.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(panel, true, null);
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.Gainsboro;
            panel.RowCount = cells.GetLength(0);
            panel.ColumnCount = cells.GetLength(1);

            for (int i = 0; i < panel.RowCount; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / width));
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / height));

                    Cell c = new Cell(j, i, SettingsData.DefaultColor, 100 / (width + height) * 5);
                    cells[i, j] = c;
                    c.MouseClicked += Cell_MouseClicked;
                    c.Dock = DockStyle.Fill;
                    panel.Controls.Add(c);
                }
            }

            splitContainer1.Panel2.Controls.Add(panel);
        }

        private void Cell_MouseClicked(Cell c, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && firstClick)
            {
                timer1.Start();
                GenerateMines(c.X, c.Y);
                NumberCells();
                firstClick = false;
            }
            if (e.Button == MouseButtons.Left)
                RevealCell(c.X, c.Y);
            else if (e.Button == MouseButtons.Right && !firstClick)
                MarkCell(c.X, c.Y);

            if (UncoveredAllCells())
                GameOver(won: true);
        }

        private void GenerateMines(int mouseX, int mouseY)
        {
            int mineCount = 0;
            int x, y;
            List<Cell> emptyCells = new List<Cell>();
            for (int i = mouseY - 1; i <= mouseY + 1; i++)
            {
                if (i < 0 || i >= cells.GetLength(0))
                    continue;
                for (int j = mouseX - 1; j <= mouseX + 1; j++)
                {
                    if (j < 0 || j >= cells.GetLength(1))
                        continue;
                    emptyCells.Add(cells[i, j]);
                }
            }

            while (mineCount < SettingsData.MineCount)
            {
                x = random.Next(cells.GetLength(1));
                y = random.Next(cells.GetLength(0));

                if (cells[y, x].Value == 0 && !emptyCells.Contains(cells[y, x]))
                {
                    cells[y, x].Value = -1;
                    mineCount++;
                }
            }
        }

        private void NumberCells()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j= 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j].Value != -1)
                    {
                        cells[i, j].Value = CountNeighbours(j, i);
                    }          
                }
            }
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                if (i < 0 || i >= cells.GetLength(0))
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j >= cells.GetLength(1))
                        continue;
                    if (x == j && y == i)
                        continue;
                    if (cells[i, j].Value == -1)
                        count++;
                }
            }
            return count;
        }

        private void RevealCell(int x, int y)
        {
            if (cells[y, x].Label == "" && !cells[y, x].Marked)
            {
                cells[y, x].Label = cells[y, x].Value.ToString();

                if (cells[y, x].Value == 0)
                {
                    RevealNeighbouringCells(x, y);
                }
                else if (cells[y, x].Value == -1)
                {
                    cells[y, x].BackColor = Color.Red;
                    GameOver(won: false);
                }
            }
        }
        private void MarkCell(int x, int y)
        {
            if (cells[y, x].Label == "")
            {
                cells[y, x].Marked = !cells[y, x].Marked;
                if (cells[y, x].Marked)
                {
                    cells[y, x].BackColor = Color.Red;
                    flagCounter--;
                    flagLabel.Text = flagCounter.ToString();
                }        
                else
                {
                    cells[y, x].BackColor = cells[y, x].DefaultColor;
                    flagCounter++;
                    flagLabel.Text = flagCounter.ToString();
                }              
            }
        }

        private void RevealNeighbouringCells(int x, int y)
        {
            for (int i = y - 1; i <= y + 1; i++)
            {
                if (i < 0 || i >= cells.GetLength(0))
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j >= cells.GetLength(1))
                        continue;
                    if (x == j && y == i)
                        continue;
                    if (cells[i, j].Label == "" && !cells[i, j].Marked)
                    {
                        cells[i, j].Label = cells[i, j].Value.ToString();

                        if (cells[i, j].Value == 0)
                            RevealNeighbouringCells(j, i);
                    }
                }
            }
        }

        private bool UncoveredAllCells()
        {
            foreach (Cell c in cells)
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

        private void RevealAllMines()
        {
            foreach (Cell c in cells)
            {
                if (c.Value == -1)
                {
                    c.Marked = false;
                    c.Label = c.Value.ToString();
                }
            }
        }

        private void GameOver(bool won)
        {
            timer1.Stop();
            RevealAllMines();
            DialogResult result = MessageBox.Show(
                won ? "Vyhráls!\nChceš hrát znovu?" : "Prohráls!\nChceš hrát znovu?",
                "Konec hry",
                MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                NewGame();
                ResetValues();
                firstClick = true;
            }
            else
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            timerLabel.Text = counter.ToString();
        }

        private void ResetValues()
        {
            counter = 0;
            flagCounter = SettingsData.MineCount;
            timerLabel.Text = "0";
            flagLabel.Text = flagCounter.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ResetValues();
            NewGame();
            firstClick = true;
        }
    }
}
