using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuSolver.IO
{
    public abstract class IOStrategy
    {
        protected StreamReader Reader { get; set; }
        protected StreamWriter Writer { get; set; }

        public abstract SudokuBoard LoadBoard(string fileName);
        public abstract void Save(string fileName);

        protected virtual bool OpenReader(string fileName)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(fileName);
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot open input file {fileName}, please try again. error = {e}");
            }
            return result;
        }

        protected virtual bool OpenWriter(string fileName)
        {
            bool result = false;
            try
            {
                Writer = new StreamWriter(fileName);
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot open output file {fileName}, error={e}");
            }
            return result;
        }
    }
}
