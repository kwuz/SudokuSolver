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
            SudokuBoard board = new SudokuSolver.SudokuBoard();
            int counter = 0;
            string line;
            if (OpenReader(fileName))
            {
                try
                {
                    //read in the size
                    line = Reader.ReadLine();
                    string[] splitLine = line.Split(null);
                    board.size = splitLine[0];
                    //read in the header
                    line = Reader.ReadLine();
                    splitLine = line.Split(null);
                    board.header = splitLine.ToList();
                    //read in board
                    while ((line = Reader.ReadLine())!= null)
                    {
                        Block row = new Block();
                        splitLine = line.Split(null);
                        foreach(string c in splitLine)
                        {
                            Cell cell = new Cell();
                            cell.value = (Convert.ToChar(c));
                            row.cells.Add(cell);
                        }
                        board.rows.Add(row);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"An Error occured when reading your file {fileName} : {e}");
                }
            }
            return board;
        }

        public override void Save(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
