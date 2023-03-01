# Část 9

Přidání timeru, counteru vlaječek, reset tlačítka a odebrání anchoru.

## Game:

```csharp
public partial class Game : Form
{
    Cell[,] cells;
    int size;
    int arrSize = 12;
    bool firstClick = true;
    Random random = new Random();
    int counter = 0;
    int flagCounter = 20;

    public Game()
    {
        InitializeComponent();
        cells = new Cell[arrSize, arrSize];
        size = Platno.Width / arrSize;
        FlagLabel.Text = flagCounter.ToString();
        NewGame();
    }

    private void Platno_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        foreach (Cell c in cells)
        {
            c.Draw(e.Graphics);
        }
    }

    private void Platno_MouseClick(object sender, MouseEventArgs e)
    {
        int x = e.X / size;
        int y = e.Y / size;
        x = Math.Min(cells.GetLength(1) - 1, x);
        y = Math.Min(cells.GetLength(0) - 1, y);

        if (e.Button == MouseButtons.Left && firstClick)
        {
            Timer.Start();
            GenerateMines(x, y);
            NumberCells();
            firstClick = false;
        }
        if (e.Button == MouseButtons.Left)
        {
            RevealCell(x, y);
        }
        else if (e.Button == MouseButtons.Right && !firstClick)
        {
            MarkCell(x, y);
        }

        if (UncoveredAllCells())
            GameOver(won: true);
    }

    private void NewGame()
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells[i, j] = new Cell(j, i, size);
            }
        }
        Refresh();
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

        while (mineCount < 20)
        {
            x = random.Next(cells.GetLength(1));
            y = random.Next(cells.GetLength(0));

            if (cells[y, x].Value == 0 && !emptyCells.Contains(cells[y, x]))
            {
                cells[y, x].Value = -1;
                mineCount++;
            }
        }
        Refresh();
    }

    private void NumberCells()
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                if (cells[i, j].Value != -1)
                    cells[i, j].Value = CountNeighbours(j, i);
            }
        }
        Refresh();
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
        if (!cells[y, x].Revealed && !cells[y, x].Marked)
        {
            cells[y, x].Revealed = true;

            if (cells[y, x].Value == 0)
            {
                RevealNeighbouringCells(x, y);
            }
            else if (cells[y, x].Value == -1)
            {
                cells[y, x].Exploded = true;
                GameOver(won: false);
            }
            Refresh();
        }
    }

    private void MarkCell(int x, int y)
    {
        if (!cells[y, x].Revealed)
        {
            cells[y, x].Marked = !cells[y, x].Marked;
            if (cells[y, x].Marked)
            {
                flagCounter--;
                FlagLabel.Text = flagCounter.ToString();
            }
            else if (!cells[y, x].Marked)
            {
                flagCounter++;
                FlagLabel.Text = flagCounter.ToString();
            }
            Refresh();
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
                if (!cells[i, j].Revealed && !cells[i, j].Marked)
                {
                    cells[i, j].Revealed = true;

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
            if (c.Value != -1 && c.Revealed)
                continue;
            else if (c.Value == -1 && !c.Revealed)
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
                c.Revealed = true;
            }
        }

        Refresh();
    }

    private void GameOver(bool won)
    {
        Refresh();
        Timer.Stop();
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

    private void Restart_Click(object sender, EventArgs e)
    {
        Timer.Stop();
        ResetValues();
        NewGame();
        firstClick = true;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        counter++;
        TimerLabel.Text = counter.ToString();
    }

    private void ResetValues()
    {
        counter = 0;
        flagCounter = 20;
        TimerLabel.Text = "0";
        FlagLabel.Text = "20";
    }
}
```
