using System.Collections.Generic;
using System.IO;
using System;

namespace SudokuSolver
{
    public class SudokuBoard
    {
        public string size { get; set; }
        public List<string> header = new List<string>();
        public List<Block> collumns = new List<Block>();
        public List<Block> rows = new List<Block>();
        public List<Block> blocks = new List<Block>();

        public void Print()
        {
            foreach(Block row in rows){
                foreach(Cell cell in row)
                {
                    Console.Write(cell.value);
                    Console.Write(" ");
                }
                Console.Write('\n');
            }
        }
    }
}