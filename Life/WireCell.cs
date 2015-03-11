using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Life
{
    public enum WireState
    {
        Empty = 0,
        Wire = 1,
        Head = 2,
        Tail = 3
    }

    public class WireCell : Cell
    {
        public WireCell(Dictionary<Point, Cell> cells)
            : base(cells)
        {
            this.WireState = WireState.Wire;
            this.NextState = WireState.Wire;
        }

        public WireCell(Dictionary<Point, Cell> cells, bool death)
            : base(cells, death)
        {
        }

        public override void Draw(Graphics g, int generation)
        {
            switch (WireState)
            {
                case WireState.Empty:
                    break;
                case WireState.Wire:
                    Draw(g, Brushes.Orange, DrawPanel.Translate(Position), generation);
                    break;
                case WireState.Head:
                    Draw(g, Brushes.DodgerBlue, DrawPanel.Translate(Position), generation);
                    break;
                case WireState.Tail:
                    Draw(g, Brushes.Firebrick, DrawPanel.Translate(Position), generation);
                    break;
                default:
                    break;
            }
        }

        public override Cell GetNeighbour(Cell cell, Dictionary<Point, Cell> cells, int x, int y, bool create)
        {
            Point p = new Point(cell.Position.X - (x * Cell.Size), cell.Position.Y - (y * Cell.Size));

            if (cells.ContainsKey(p))
            {
                return cells[p];
            }
            //if (create && !cell.Death)
            //{
            //    cells[p] = new Cell(cells) { Death = true, Position = p };

            //    return cells[p];
            //}
            return null;
        }

        public override int NeighboursAlive
        {
            get
            {
                int count = 0;
                GenerateNeighbourhood(this, _cells, false);
                for (int i = 0; i < Neighbourhood.Length; i++)
                {
                    WireCell c = Neighbourhood[i] as WireCell;
                    if (c != null && c.WireState == WireState.Head)
                        count++;
                }
                return count;
            }
        }

        private WireState _wireState = WireState.Empty;

        public WireState WireState
        {
            get { return _wireState; }
            set { _wireState = value; }
        }

        private WireState _nextState = WireState.Empty;

        public WireState NextState
        {
            get { return _nextState; }
            set { _nextState = value; }
        }
    }
}
