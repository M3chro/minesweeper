# Část 5

Očíslování políček - číslo udává, kolik min se nachází v okolí.

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
            NumberCells();
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
}
```

## Cell:

```csharp
internal class Cell
{
    int x, y;
    int value;
    int size;
    bool revealed;
    bool marked;
    bool exploded;

    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public bool Revealed
    {
        get { return revealed; }
        set { revealed = value; }
    }
    public bool Marked
    {
        get { return marked; }
        set { marked = value; }
    }
    public bool Exploded
    {
        get { return exploded; }
        set { exploded = value; }
    }

    Font font;
    StringFormat sf;
    Rectangle r;

    public Cell(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;

        font = new Font("Arial", size / 3);
        sf = new StringFormat();
        sf.Alignment = StringAlignment.Center;
        sf.LineAlignment = StringAlignment.Center;

        r = new Rectangle(x * size, y * size, size, size);
    }

    public void Draw(Graphics g)
    {
        if (value == -1)
        {
            g.FillEllipse(Brushes.Black, x * size + size / 3, y * size + size / 3, size / 3, size / 3);
        }
        else if (value != -1 && value != 0)
        {
            g.FillRectangle(Brushes.WhiteSmoke, r);
            g.DrawString(
                value.ToString(),
                font,
                value == 1 ? Brushes.Blue
                : value == 2 ? Brushes.Green
                : value == 3 ? Brushes.Red
                : value == 4 ? Brushes.Teal
                : value == 5 ? Brushes.DarkBlue
                : value == 6 ? Brushes.DarkRed
                : value == 7 ? Brushes.Black
                : Brushes.DarkGray,
                r,
                sf
            );
        }
        else if (value == 0)
        {
            g.FillRectangle(Brushes.Gainsboro, r);
        }

        g.DrawRectangle(Pens.Gainsboro, r);
    }
}
```