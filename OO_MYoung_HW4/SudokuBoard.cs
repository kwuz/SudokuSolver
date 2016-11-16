using System.Collections.Generic;
using System.IO;
using System;

namespace SudokuSolver
{
    public class SudokuBoard
    {
        public int size { get; set; }
        public List<char> header;
        public List<Block> collumns;
        public List<Block> rows;
        public List<Block> blocks;

        public void toString()
        {
            foreach(Block row in rows){
                foreach(Cell cell in row)
                {
                    Console.Write(cell.value);
                }
                Console.Write('\n');
            }
        }
    }

   // SudokuBoard loadBoard(inputFile)
   // {
   //     return 
   // }
}