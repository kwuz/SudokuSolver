using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {  
            //shhhh its fine this is how you print ascii art when you hate yourself                                                           
            Console.WriteLine("                                               ,----..          ,--.");
            Console.WriteLine("      .--.--.                     ,---,       /   /   \\     ,--/  /|               ");
            Console.WriteLine("     /  /    '.          ,--,   .'  .' `\\    /   .     : ,---,': / '         ,--,  ");
            Console.WriteLine("    |  :  /`. /        ,'_ /| ,---.'    \\  .   /   ;.  \\:   : '/ /        ,'_ /|  ");
            Console.WriteLine("    ;  |  |--`    .--. |  | : |   |  .`\\  |.   ;   /  ` ;|   '   ,    .--. |  | :  ");
            Console.WriteLine("    |  :  ;_    ,'_ /| :  . | :   : |  '  |;   |  ; \\ ; |'   |  /   ,'_ /| :  . |  ");
            Console.WriteLine("     \\  \\    `. |  ' | |  . . |   ' '  ;  :|   :  | ; | '|   ;  ;   |  ' | |  . .  ");
            Console.WriteLine("      `----.   \\|  | ' |  | | '   | ;  .  |.   |  ' ' ' ::   '   \\  |  | ' |  | |  ");
            Console.WriteLine("      __ \\  \\  |:  | | :  ' ; |   | :  |  ''   ;  \\; /  ||   |    ' :  | | :  ' ;  ");
            Console.WriteLine("     /  /`--'  /|  ; ' |  | ' '   : | /  ;  \\   \\  ',  / '   : |.  \\|  ; ' |  | '  ");
            Console.WriteLine("    '--'.     / :  | : ;  ; | |   | '` ,/    ;   :    /  |   | '_\\.':  | : ;  ; |  ");
            Console.WriteLine("      `--'---'  '  :  `--'   \\;   :  .'       \\   \\ .'   '   : |    '  :  `--'   \\ ");
            Console.WriteLine("                :  ,      .-./|   ,.'          `---`     ;   |,'    :  ,      .-./ ");
            Console.WriteLine("                 `--`----'    '---'                      '---'       `--`----'     ");
            Console.WriteLine("                                                                                   ");

            SudokuBoard board = new SudokuBoard();
            Console.WriteLine("Please specify an input file (or enter 't' for a default input file");
            string inputfile = Console.ReadLine();
            if (inputfile == "t")
                inputfile = "C:/Users/Kwuz/Documents/Visual Studio 2015/Projects/OO_MYoung_HW4/Input/Puzzle-9x9-0002.txt";
            Console.WriteLine("Please specify an output file (or enter 'o' for a default output file");
            string outputfile = Console.ReadLine();
            if (inputfile == "o")
                outputfile = "output.txt";

           // board = SudokuBoard.loadBoard(inputfile);

            Console.WriteLine("Execution Complete. Press Enter to Exit");
            Console.ReadLine();

        }
    }
}
