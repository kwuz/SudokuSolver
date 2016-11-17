using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuSolver.IO
{
    public class txtImportExportStrategy : IOStrategy
    {
        public override SudokuBoard LoadBoard(string fileName)
        {
            SudokuBoard board = null;

            if (OpenReader(fileName))
            {
                //read in 
            }
            return board;
        }

        public override void Save(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
