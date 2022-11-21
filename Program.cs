using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {          

        static void Main(string[] args)
        {
            //int UIwidth = UI.GetLength(0); //gets the width of the UI array
            //int UIheight = UI.GetLength(1); //gets the length of the UI array
            int width = 64;
            int height = 32;
            int origx = Console.CursorLeft; 
            int origy = Console.CursorTop;
            int cursorLeftMain = origx + 1; //cursor position for printing to the main game area
            int cursorTopMain = origy + 1;
            int cursorTopChoice = origx + 20; //cursor position for printing to the player choice area
            int cursorLeftChoice = origy + 1;
            int cursorTopPrint = origx + 30; //sets cursor position for printing player output outside of the main game area/player choice area
            int cursorLeftPrint = origy;

            SetWindowSize(width, height);
            PrintUI(width, height);
            SetCursor(cursorLeftMain, cursorTopMain);
            Console.ReadKey();
            SetCursor(cursorLeftChoice, cursorTopChoice);
            Console.ReadKey();
            SetCursor(cursorLeftPrint, cursorTopPrint);
            Console.ReadKey();
        }
        public static void SetWindowSize(int width, int height) //sets the size of the window for gameplay
        {
            Console.SetWindowSize(width + 20, height + 1);
        }
        static void PrintUI(int width, int height)
        {
            Console.Write('╔');
            for (int c = 0; c < width; c++)
            {     
                Console.Write('═');
            }
            Console.Write('╗');
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write('║');
                for (int j = 0; j < width; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('║');
                Console.WriteLine();
            }
            Console.Write('╚');
            for (int c = 0; c < width; c++)
            {                
                Console.Write('═');            
            }
            Console.Write('╝');
            Console.WriteLine();
        }
        static void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
