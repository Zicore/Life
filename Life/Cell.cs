using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Life
{
    public class Cell
    {
        public Cell(Dictionary<Point, Cell> cells)
        {
            this._cells = cells;
            Neighbourhood = new Cell[8];
        }

        public void Init()
        {
            GenerateNeighbourhood(this, _cells, true);
        }

        public Cell(Dictionary<Point, Cell> cells, bool death)
        {
            this.Death = death;
            this._cells = cells;
            Neighbourhood = new Cell[8];
            GenerateNeighbourhood(this, _cells, true);
        }

        public Color HeatMapColor(decimal value, decimal min, decimal max)
        {
            decimal val = Math.Min((value - min) / (max - min),1);
            int r = Convert.ToByte(255 * val);
            int g = Convert.ToByte(255 * (1 - val));
            int b = 0;

            return Color.FromArgb(255, r, g, b);
        }

        protected Dictionary<Point, Cell> _cells;

        private bool _marked = false;
        public bool Marked
        {
            get { return _marked; }
            set { _marked = value; }
        }

        private bool _markedLiving = false;
        public bool MarkedLiving
        {
            get { return _markedLiving; }
            set { _markedLiving = value; }
        }

        private bool _death = false;
        public bool Death
        {
            get { return _death; }
            set
            {
                _death = value;
                if (_death)
                {
                    Generation = 0;
                }
            }
        }

        public Brush FromGeneration(int generation)
        {
            if (generation == 0)
            {
                return Brushes.LightCoral;
            }
            decimal value = (decimal)this.Generation / (decimal)generation;
            decimal max = (decimal)generation;
            Color color = HeatMapColor(value, 0, 1);
            return new SolidBrush(color);
        }

        private int _generation = 0;
        public int Generation
        {
            get { return _generation; }
            set { _generation = value; }
        }

        public static int Size = 10;

        private Point _position = new Point(0, 0);
        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }


        public virtual void Draw(Graphics g, int generation)
        {
            if (!Death)
            {
                Draw(g, FromGeneration(generation), DrawPanel.Translate(Position), generation);
            }
            else
            {
                Draw(g, Brushes.PapayaWhip, DrawPanel.Translate(Position), generation);
            }
        }

        public static void Draw(Graphics g, Brush brush, Point p, int generation)
        {
            var rect = new Rectangle(p.X + 1, p.Y + 1, Size - 1, Size - 1);
            g.FillRectangle(brush, rect);
        }

        private Cell[] _neighbourhood;
        public Cell[] Neighbourhood
        {
            get { return _neighbourhood; }
            set { _neighbourhood = value; }
        }

        public virtual int NeighboursAlive
        {
            get
            {
                int count = 0;
                GenerateNeighbourhood(this, _cells, false);
                for (int i = 0; i < Neighbourhood.Length; i++)
                {
                    if (Neighbourhood[i] != null && !Neighbourhood[i].Death)
                        count++;
                }
                return count;
            }
        }

        public virtual void GenerateNeighbourhood(Cell c, Dictionary<Point, Cell> cells, bool create)
        {
            //TopLeft
            c.Neighbourhood[0] = GetNeighbour(c, cells, -1, -1, create);

            //TopCenter
            c.Neighbourhood[1] = GetNeighbour(c, cells, 0, -1, create);

            //TopRight
            c.Neighbourhood[2] = GetNeighbour(c, cells, 1, -1, create);

            //BottomLeft
            c.Neighbourhood[3] = GetNeighbour(c, cells, -1, 1, create);

            //BottomCenter
            c.Neighbourhood[4] = GetNeighbour(c, cells, 0, 1, create);

            //BottomRight
            c.Neighbourhood[5] = GetNeighbour(c, cells, 1, 1, create);

            //CenterLeft
            c.Neighbourhood[6] = GetNeighbour(c, cells, -1, 0, create);

            //CenterRight
            c.Neighbourhood[7] = GetNeighbour(c, cells, 1, 0, create);
        }

        public virtual Cell GetNeighbour(Cell cell, Dictionary<Point, Cell> cells, int x, int y, bool create)
        {
            Point p = new Point(cell.Position.X - (x * Cell.Size), cell.Position.Y - (y * Cell.Size));

            if (cells.ContainsKey(p))
            {
                return cells[p];
            }
            if (create && !cell.Death)
            {
                cells[p] = new Cell(cells) { Death = true, Position = p };

                return cells[p];
            }
            return null;
        }
    }
}
