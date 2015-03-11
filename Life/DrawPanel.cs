using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Life
{
    public enum GameMode
    {
        GameOfLife = 0,
        WireWorld = 1
    }

    [DesignTimeVisible(false)]
    public class DrawPanel : Panel
    {
        public static Point TranslationLast = new Point();

        private readonly List<Point> deadCells = new List<Point>();
        private readonly Pen linePen = Pens.LightGray;
        private Dictionary<Point, Cell> _cells = new Dictionary<Point, Cell>();
        protected bool _drawMode = false;
        private GameMode _gameMode = GameMode.WireWorld;
        protected bool _isMouseLeftDown = false;
        protected bool _isMouseRightDown = false;
        protected Point _lastPoint = new Point();
        protected bool _lastdrawMode = false;
        private List<CellRule> _rules = new List<CellRule>();
        private Point translationEnd = new Point();
        private Point translationStart = new Point();

        public DrawPanel()
        {
            DoubleBuffered = true;
            _rules.Add(new CellRule { Index = 0, State = CellState.Die });
            _rules.Add(new CellRule { Index = 1, State = CellState.Die });
            _rules.Add(new CellRule { Index = 2, State = CellState.Stay });
            _rules.Add(new CellRule { Index = 3, State = CellState.Live });
            _rules.Add(new CellRule { Index = 4, State = CellState.Die });
            _rules.Add(new CellRule { Index = 5, State = CellState.Die });
            _rules.Add(new CellRule { Index = 6, State = CellState.Die });
            _rules.Add(new CellRule { Index = 7, State = CellState.Die });
            _rules.Add(new CellRule { Index = 8, State = CellState.Die });
        }

        public GameMode GameMode
        {
            get { return _gameMode; }
            set
            {
                _gameMode = value;
                if (GameModeChanged != null)
                {
                    GameModeChanged(this, new EventArgs());
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<Point, Cell> Cells
        {
            get { return _cells; }
            set { _cells = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Cell SelectedCell { get; set; }

        public int Generation { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<CellRule> Rules
        {
            get { return _rules; }
            set { _rules = value; }
        }

        public static Point Translate(Point p)
        {
            return new Point(TranslationLast.X + p.X, TranslationLast.Y + p.Y);
        }

        public event EventHandler SelectionChanged;
        public event EventHandler CellsUpdated;
        public event EventHandler GameModeChanged;

        public void CalculateCycle()
        {
            var livingCells = new List<Point>();

            if (GameMode == GameMode.GameOfLife)
            {
                if (_rules.Count > 0)
                {
                    for (int i = 0; i < deadCells.Count; i++)
                    {
                        _cells.Remove(deadCells[i]);
                    }
                    deadCells.Clear();

                    foreach (var cell in _cells)
                    {
                        if (!cell.Value.Death)
                        {
                            livingCells.Add(cell.Value.Position);
                        }
                    }

                    for (int i = 0; i < livingCells.Count; i++)
                    {
                        if (_cells.ContainsKey(livingCells[i]))
                        {
                            _cells[livingCells[i]].Init();
                        }
                    }

                    CalculateNeighbours(_cells.Values, livingCells);
                    Generation++;
                }
            }
            else
            {
                //for (int i = 0; i < deadCells.Count; i++)
                //{
                //    _cells.Remove(deadCells[i]);
                //}
                //deadCells.Clear();

                foreach (var cell in _cells)
                {
                    if (!cell.Value.Death)
                    {
                        livingCells.Add(cell.Value.Position);
                    }
                }

                for (int i = 0; i < livingCells.Count; i++)
                {
                    if (_cells.ContainsKey(livingCells[i]))
                    {
                        _cells[livingCells[i]].Init();
                    }
                }

                CalculateNeighboursWireWorld(_cells.Values, livingCells);
                Generation++;
            }


            //else
            //{
            //    ////foreach (var cell in _cells)
            //    ////{
            //    ////    if (!cell.Value.Death)
            //    ////    {
            //    ////        livingCells.Add(cell.Value.Position);
            //    ////    }
            //    ////}

            //    ////for (int i = 0; i < livingCells.Count; i++)
            //    ////{
            //    ////    if (_cells.ContainsKey(livingCells[i]))
            //    ////    {
            //    ////        _cells[livingCells[i]].Init();
            //    ////    }
            //    ////}
            //    var lst = new List<Cell>();

            //    foreach (Cell cell in _cells.Values)
            //    {
            //        Cell c = cell;
            //        lst.Add(c);
            //    }

            //    for (int i = 0; i < lst.Count; i++)
            //    {
            //        Cell c = lst[i];
            //        if (c.Position.Y + Cell.Size * 4 < Height)
            //        {
            //            c.Position = new Point(c.Position.X, AddPosition(c.Position.Y, 1));
            //        }
            //    }
            //}
            Invalidate();
            if (CellsUpdated != null)
            {
                CellsUpdated(this, new EventArgs());
            }
        }

        public void CalculateNeighbours(IEnumerable<Cell> cells, List<Point> livingCells)
        {
            foreach (Cell cell in cells)
            {
                Cell c = cell;

                foreach (CellRule cellRule in _rules)
                {
                    if (cellRule.Index == c.NeighboursAlive)
                    {
                        if (cellRule.State == CellState.Die)
                        {
                            c.Marked = true;
                        }
                        if (cellRule.State == CellState.Stay)
                        {
                            //c.Marked = true;
                        }
                        if (cellRule.State == CellState.Live)
                        {
                            c.MarkedLiving = true;
                        }
                    }
                }
            }

            foreach (Cell c in _cells.Values)
            {
                if (c.Marked)
                {
                    c.Death = true;
                    c.Marked = false;
                }
                if (c.MarkedLiving)
                {
                    c.Death = false;
                    c.MarkedLiving = false;
                }
                if (c.Death)
                {
                    deadCells.Add(c.Position);
                }
                if (!c.Death)
                {
                    c.Generation++;
                }
            }
        }

        public void CalculateNeighboursWireWorld(IEnumerable<Cell> cells, List<Point> livingCells)
        {
            foreach (Cell cell in cells)
            {
                var c = cell as WireCell;

                if (c.WireState == WireState.Wire && (c.NeighboursAlive == 1 || c.NeighboursAlive == 2))
                {
                    c.NextState = WireState.Head;
                }
                if (c.WireState == WireState.Head)
                {
                    c.NextState = WireState.Tail;
                }
                if (c.WireState == WireState.Tail)
                {
                    c.NextState = WireState.Wire;
                }
            }

            foreach (WireCell c in _cells.Values)
            {
                c.WireState = c.NextState;
                //c.NextState = WireState.Empty;
            }
        }

        protected int AddPosition(int pos, int value)
        {
            return ((pos / Cell.Size) + value) * Cell.Size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;

            for (int h = 0; h < (Height / Cell.Size) + Cell.Size; h++)
            {
                g.DrawLine(linePen, 0, h * Cell.Size, Width, h * Cell.Size);
            }
            for (int w = 0; w < (Width / Cell.Size) + Cell.Size; w++)
            {
                g.DrawLine(linePen, w * Cell.Size, 0, w * Cell.Size, Height);
            }

            // Cursor
            Point p = CalculateMouseRoot(PointToClient(Cursor.Position));
            Cell.Draw(g, Brushes.NavajoWhite, Translate(p), Generation);

            foreach (var cell in _cells)
            {
                cell.Value.Draw(g, Generation);
            }

            base.OnPaint(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isMouseLeftDown || _isMouseRightDown)
            {
                if (GameMode == GameMode.GameOfLife)
                {
                    AddCells(e.Location, false, e.Button);
                }
                if (GameMode == GameMode.WireWorld)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        AddCellsWireWorld(e.Location, false, e.Button);
                    }
                }
            }
            Invalidate();
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMouseLeftDown = true;
                CheckMode(e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                _isMouseRightDown = true;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (GameMode == GameMode.GameOfLife)
            {
                AddCells(e.Location, true, e.Button);
            }
            if (GameMode == GameMode.WireWorld)
            {
                AddCellsWireWorld(e.Location, true, e.Button);
            }
            if (e.Button == MouseButtons.Left)
            {
                _isMouseLeftDown = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                _isMouseRightDown = false;
            }
            base.OnMouseUp(e);
        }

        protected Cell GetSelected(Point mouse)
        {
            Point p = CalculateMouseRoot(mouse);
            if (_cells.ContainsKey(p))
            {
                return _cells[p];
            }
            else
            {
                return null;
            }
        }

        protected void AddCells(Point mouse, bool isClick, MouseButtons mouseButtons)
        {
            Point p = CalculateMouseRoot(mouse);

            if (p != _lastPoint || _drawMode != _lastdrawMode)
            {
                if (_cells.ContainsKey(p))
                {
                    if (_cells[p].Death)
                    {
                        if (!_drawMode)
                        {
                            _cells[p].Death = false;
                            //_cells[p].Init();
                        }
                    }
                    else
                    {
                        if (!_drawMode)
                        {
                            _cells.Remove(p);
                            OnCellsUpdated();
                        }
                    }
                }
                else
                {
                    if (_drawMode)
                    {
                        _cells[p] = new Cell(_cells) { Position = p };
                        OnCellsUpdated();
                        //_cells[p].Init();
                    }
                }
            }

            _lastPoint = p;
        }

        protected void AddCellsWireWorld(Point mouse, bool isClick, MouseButtons mouseButtons)
        {
            Point p = CalculateMouseRoot(mouse);

            if (true)
            {
                if (_cells.ContainsKey(p))
                {
                    if (_cells[p].Death)
                    {
                        if (!_drawMode)
                        {
                            _cells[p].Death = false;
                            //_cells[p].Init();
                        }
                    }
                    else
                    {
                        if (mouseButtons == MouseButtons.Left)
                        {
                            if (!_drawMode)
                            {
                                _cells.Remove(p);
                                OnCellsUpdated();
                            }
                        }
                        if (mouseButtons == MouseButtons.Right)
                        {
                            var c = _cells[p] as WireCell;
                            if (c != null)
                            {
                                if (c.WireState == WireState.Head)
                                {
                                    c.WireState = WireState.Tail;
                                }
                                else if (c.WireState == WireState.Tail || c.WireState == WireState.Wire)
                                {
                                    c.WireState = WireState.Head;
                                }
                            }
                            OnCellsUpdated();
                        }
                    }
                }
                else
                {
                    if (_drawMode)
                    {
                        if (mouseButtons == MouseButtons.Left)
                        {
                            _cells[p] = new WireCell(_cells) { Position = p };
                        }
                        if (mouseButtons == MouseButtons.Right)
                        {
                            _cells[p] = new WireCell(_cells) { Position = p, WireState = WireState.Head };
                        }

                        OnCellsUpdated();
                        //_cells[p].Init();
                    }
                }
            }

            _lastPoint = p;
        }

        protected void OnCellsUpdated()
        {
            if (CellsUpdated != null)
            {
                CellsUpdated(this, new EventArgs());
            }
        }

        protected void CheckMode(Point p)
        {
            _lastdrawMode = _drawMode;
            _drawMode = !_cells.ContainsKey(CalculateMouseRoot(p));
        }

        public Point CalculateMouseRoot(Point p)
        {
            int x = (p.X / Cell.Size) * Cell.Size;
            int y = (p.Y / Cell.Size) * Cell.Size;

            return new Point(x, y);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            Invalidate();
            base.OnResize(eventargs);
        }

        public void Restart()
        {
            Cells.Clear();
            deadCells.Clear();
            Invalidate();
        }

        public void ClearDeadCells()
        {
            deadCells.Clear();
        }

        public void RandomLife()
        {
            Cells.Clear();
            var rnd = new Random();
            int t = rnd.Next(0, 50);
            for (int x = 0; x < Width / Cell.Size; x++)
            {
                for (int y = 0; y < Height / Cell.Size; y++)
                {
                    int r = rnd.Next(0, 100);
                    if (r <= t)
                    {
                        var c = new Cell(Cells, false) { Position = new Point(x * Cell.Size, y * Cell.Size) };
                        if (!Cells.ContainsKey(c.Position))
                        {
                            Cells.Add(c.Position, c);
                        }
                    }
                }
            }
            Invalidate();
        }
    }
}