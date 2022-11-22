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
        static bool GameOver;

        static string[] Story = (string[])Story.Clone(); //ugh
        static void Main(string[] args)
        {            
            int width = 96;
            int height = 32;
            int origx = Console.CursorLeft; 
            int origy = Console.CursorTop;
            int cursorTopMain = origy + 1; //cursor position for printing to the main game area
            int cursorLeftMain = origx + 1; 
            int cursorTopChoice = origx + 20; //cursor position for printing to the player choice area
            int cursorLeftChoice = origy + 1;
            int cursorTopPrint = origx + 34; //sets cursor position for printing player output outside of the main game area/player choice area
            int cursorLeftPrint = origy;
            GameOver = false;
            
            while (GameOver == false)
            {
                UI.PrintUI(width, height);
                SetCursor(cursorLeftMain, cursorTopMain);
                Console.ReadKey();
                Title.MainTitle();
                Console.ReadKey();
                SetCursor(cursorLeftChoice, cursorTopChoice);
                Console.ReadKey();
                Console.WriteLine(Story[0]);
                Console.ReadKey();
                SetCursor(cursorLeftPrint, cursorTopPrint);
                Console.ReadKey();
            }            
        }        
        
        static void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
