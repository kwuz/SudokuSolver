using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Cell
    {
        public char value;
        public List<char> possibleValues;
        public int row;
        public int collumn;
        public int block;

        public void clearAllPossibilities()
        {
            possibleValues.Clear();
        }

        public void clearPossibility(char num)
        {
            if (possibleValues.Contains(num))
                possibleValues.Remove(num);
        }
    }

}
