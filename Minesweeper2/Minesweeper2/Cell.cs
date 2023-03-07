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
    public partial class Cell : UserControl
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Value { get; set; }
        public bool Marked { get; set; }
        public Color DefaultColor { get; private set; }
        public string Label
        {
            get { return TextLabel.Text; }
            set 
            {
                TextLabel.Text = Value == -1 ? "⬤" : value;
                if (_colors.ContainsKey(Value))
                {
                    TextLabel.ForeColor = _colors[Value];
                    if (Value == 0)
                    {
                        this.BackColor = Color.Gainsboro;
                    }
                }     
            }
        }
        private Dictionary<int, Color> _colors = new Dictionary<int, Color>
        {
            { 0, Color.Gainsboro },
            { 1, Color.Blue },
            { 2, Color.Green },
            { 3, Color.Red },
            { 4, Color.Teal },
            { 5, Color.DarkBlue },
            { 6, Color.DarkRed },
            { 7, Color.Black },
            { 8, Color.DarkGray }
        };        

        public event Action<Cell, MouseEventArgs> MouseClicked;

        public Cell()
        {
            InitializeComponent();
        }

        public Cell(int x, int y, Color defaultColor, int fontSize)
        {
            InitializeComponent();
            X = x;
            Y = y;
            Value = 0;
            DefaultColor = defaultColor;
            TextLabel.Font = new Font("Arial", fontSize);
            this.BackColor = defaultColor;
        }

        private void TextLabel_MouseClick(object sender, MouseEventArgs e)
        {
            MouseClicked?.Invoke(this, e);
        }
    }
}
