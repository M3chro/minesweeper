# Část 4

Správné souřadnice při kliknutí na plátno, odchytávání tlačítek + jednoduché generování min.

## Game:

```csharp
public partial class Game : Form
{
    Cell[,] cells;
    int size;
    int arrSize = 12;
    bool firstClick = true;
    Random random = new Random();

    public Game()
    {
        InitializeComponent();
        cells = new Cell[arrSize, arrSize];
        size = Platno.Width / arrSize;
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
            GenerateMines(x, y);
            firstClick = false;
        }
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
    }

    private void GenerateMines(int mouseX, int mouseY)
    {
        int mineCount = 0;
        int x, y;

        while (mineCount < 20)
        {
            x = random.Next(cells.GetLength(1));
            y = random.Next(cells.GetLength(0));

            if (cells[y, x].Value == 0 && x != mouseX && y != mouseY)
            {
                cells[y, x].Value = -1;
                mineCount++;
            }
        }
        Refresh();
    }
}
```

## Cell:

```csharp
public void Draw(Graphics g)
{
    if (value == -1)
    {
        g.FillEllipse(Brushes.Black, x * size + size / 3, y * size + size / 3, size / 3, size / 3);
    }

    g.DrawRectangle(Pens.Gainsboro, x * size, y * size, size, size);
}
```