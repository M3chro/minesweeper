# Část 3

Přidání cells do 2D pole a vykreslení na plátno.

## Game:

```csharp
public partial class Game : Form
{
    Cell[,] cells;
    int size;
    int arrSize = 12;

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
        Console.WriteLine("Test kliknutí");
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
}
```

## Cell:

```csharp
public void Draw(Graphics g)
{
    g.DrawRectangle(Pens.Gainsboro, x * size, y * size, size, size);
}
```