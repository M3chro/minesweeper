# Část 7

Upravení algoritmu na generování min - po prvním kliknutí se vždy musí rozevřít plocha.

## Game:

```csharp
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
```