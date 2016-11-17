using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Block : IEnumerable<Cell>
    {
        public int size { get; set; }
        public List<Cell> cells = new List<Cell>();

        public IEnumerator<Cell> GetEnumerator()
        {
            return cells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CellEnum(cells.ToArray());
        }
    }

    public class CellEnum : IEnumerator
    {
        private readonly Cell[] _cells;
        private int _currentPosition = -1;

        public CellEnum(Cell[] cells)
        {
            _cells = cells;
        }

        public bool MoveNext()
        {
            return (++_currentPosition < _cells.Length);
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        object IEnumerator.Current { get { return Current; } }

        public Cell Current
        {
            get
            {
                return (_currentPosition >= 0 && _currentPosition < _cells.Length) ? _cells[_currentPosition] : null;
            }
        }
    }
}

