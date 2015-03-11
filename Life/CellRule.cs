using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Life
{
    public enum CellState
    {
        Stay,
        Live,
        Die
    }

    public class CellRule
    {
        private int _index = 0;
        CellState _state = CellState.Stay;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public CellState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public override string ToString()
        {
            return String.Format("Neighbours: {0} State:{1}", Index, State);
        }
    }
}
