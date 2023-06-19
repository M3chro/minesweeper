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
    public partial class GameForm : Form
    {
        GameLogic gameLogic;
        TableLayoutPanel panel;
        int timerCounter = 0;
   
        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameLogic = new GameLogic();
            gameLogic.GameOverEvent += GameOver;
            gameLogic.FlagCountChanged += gameLogic_FlagCountChanged;
            flagLabel.Text = gameLogic.FlagCounter.ToString();
            CreatePanel();
        }

        private void gameLogic_FlagCountChanged(object sender, int e)
        {
            flagLabel.Text = gameLogic.FlagCounter.ToString();
        }

        private void CreatePanel()
        {
            panel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Gainsboro,
                RowCount = gameLogic.Cells.GetLength(0),
                ColumnCount = gameLogic.Cells.GetLength(1)
            };

            // Blink fix, faster
            splitContainer1.Panel1.GetType().GetProperty("DoubleBuffered",
               System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
               .SetValue(splitContainer1.Panel1, true, null);

            panel.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(panel, true, null);

            for (int i = 0; i < panel.RowCount; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / gameLogic.Cells.GetLength(1)));
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / gameLogic.Cells.GetLength(0)));

                    Cell c = new Cell(j, i, SettingsData.DefaultColor, 100 / (gameLogic.Cells.GetLength(1) + gameLogic.Cells.GetLength(0)) * 5);
                    gameLogic.Cells[i, j] = c;
                    c.MouseClicked += Cell_MouseClicked;
                    c.Dock = DockStyle.Fill;
                    panel.Controls.Add(c);
                }
            }

            splitContainer1.Panel2.Controls.Add(panel);
        }

        private void Cell_MouseClicked(Cell c, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && gameLogic.FirstClick)
            {
                timer1.Start();
                gameLogic.GenerateMines(c.X, c.Y);
                gameLogic.NumberCells();
                gameLogic.FirstClick = false;
            }
            if (e.Button == MouseButtons.Left)
                gameLogic.RevealCell(c.X, c.Y);
            else if (e.Button == MouseButtons.Right && !gameLogic.FirstClick)
                gameLogic.MarkCell(c.X, c.Y);

            if (gameLogic.UncoveredAllCells())
                GameOver(won: true);
        }

        private void GameOver(bool won)
        {
            timer1.Stop();
            gameLogic.RevealAllMines();
            DialogResult result = MessageBox.Show(
                won ? "Vyhráls!\nChceš hrát znovu?" : "Prohráls!\nChceš hrát znovu?",
                "Konec hry",
                MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                ResetGame();
                ResetCounters();
            }
            else
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            timerLabel.Text = timerCounter.ToString();
        }

        private void ResetCounters()
        {
            timerCounter = 0;
            gameLogic.FlagCounter = SettingsData.MineCount;
            timerLabel.Text = "0";
            flagLabel.Text = gameLogic.FlagCounter.ToString();
        }

        private void ResetGame()
        {
            foreach (Cell c in panel.Controls)
            {
                gameLogic.SetDefaultValues(c);
            }
            gameLogic.FirstClick = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ResetCounters();
            ResetGame();
        }
    }
}
