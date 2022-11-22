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
            int page = 0;
            string currPage = Story.story[page]; //gets the string at the 'page' index
            string[] strings = currPage.Split('%'); //prepares the split for the current page information
            
            while (GameOver == false)
            {
                UI.PrintUI(width, height);
                SetCursor(cursorLeftMain, cursorTopMain);
                Console.ReadKey();
                Title.MainTitle();
                Console.ReadKey();
                SetCursor(cursorLeftChoice, cursorTopChoice);
                Console.ReadKey();
                foreach (string s in strings)
                {                    
                    Console.WriteLine(s);
                }
                Console.ReadKey();
                Console.WriteLine(Story.story[page]);
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
