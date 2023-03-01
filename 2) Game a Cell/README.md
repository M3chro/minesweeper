# Část 2

Tvoříme náš hlavní formulář - `Game` a třídu `Cell`.

## Game:

Přidáváme přes sadu nástrojů `PictureBox`, což se bude chovat jako naše hlavní plátno pro vykreslování grafických prvků samotné hry.
WinForms není úplně vhodné na tvorbu aplikací s dynamickým rozlišením, takže by bylo fajn pro naše účely zvolit si jednu velikost plátna, která vám vyhovuje, a už na ni nesahat.
Jelikož budeme pracovat s tím, že velikost herní plochy (kostiček) bude 12x12, tak si zvolte velikost takovou, aby se vám kostičky na plátno krásně vešly. (např. 780x780 (rozlišení/12 musí být **celé číslo**)).
Na naše Plátno si přidáme dvě události - `MouseClick` a `Paint`.

```csharp
public partial class Game : Form
{
    public Game()
    {
        InitializeComponent();
    }

    private void Platno_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Platno_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Test kliknutí");
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

    public Cell(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;
    }
}
```