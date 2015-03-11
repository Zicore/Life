using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Life
{
    public class LifeSaver
    {
        public LifeSaver()
        {

        }

        public String Save(Dictionary<Point, Cell> cells, GameMode mode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((int)mode);
            foreach (var cell in cells)
            {
                if (!cell.Value.Death)
                {
                    sb.Append(cell.Value.Position.X);
                    sb.Append(",");
                    sb.Append(cell.Value.Position.Y);
                    if (mode == GameMode.WireWorld)
                    {
                        WireCell wc = cell.Value as WireCell;
                        if (wc != null)
                        {
                            sb.Append(",");
                            sb.Append((int)wc.WireState);
                        }
                    }
                    sb.Append("|");
                }
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(sb.ToString()));
        }

        public Dictionary<Point, Cell> Load(String base64Str, out GameMode mode)
        {
            Dictionary<Point, Cell> cells = new Dictionary<Point, Cell>();
            mode = GameMode.GameOfLife;
            try
            {
                String result = Encoding.UTF8.GetString(Convert.FromBase64String(base64Str));
                int intMode = 0;

                if (int.TryParse(result.Substring(0, 1), out intMode))
                {
                    mode = (GameMode)intMode;
                    result = result.Substring(1, result.Length - 1);
                }
                //result = result.Replace("{", "");
                var points = result.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var point in points)
                {
                    try
                    {
                        String[] pointArr = point.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        Cell cell;
                        int x = int.Parse(pointArr[0]);
                        int y = int.Parse(pointArr[1]);
                        if (mode == GameMode.WireWorld)
                        {
                            int intState = int.Parse(pointArr[2]);
                            cell = new WireCell(cells, false) { Position = new Point(x, y), WireState = (WireState)intState, NextState =  (WireState)intState};
                        }
                        else
                        {
                            cell = new Cell(cells, false) { Position = new Point(x, y) };
                        }
                        //cell.Init();
                        cells.Add(cell.Position, cell);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
            return cells;
        }
    }
}
