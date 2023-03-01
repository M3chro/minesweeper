using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
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
            if (revealed)
            {
                if (value == -1)
                {
                    if (exploded)
                    {
                        g.FillRectangle(Brushes.Red, r);
                    }
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
            }
            else if (marked)
            {
                g.FillRectangle(Brushes.Red, r);
            }
            
            g.DrawRectangle(Pens.Gainsboro, r);
        }
    }
}
